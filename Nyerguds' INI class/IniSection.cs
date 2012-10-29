/*
 * This file is FREE. This file can freely be copied, edited, mutilated, compiled,
 * printed out and burned in bizarre rituals, or used in supervillain(*) activities.
 * I don't care, as long as you leave this notice(**) when distributing it.
 * 
 * Originally created by Nyerguds.
 * 
 * (*)  Supervillain activities are the ONLY criminal activities for which use of
 *      this code is endorsed by the original author
 * (**) If less than 20% of my original code remains, don't bother.
 */

using System;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Nyerguds.ini
{

    /// <summary>
    /// This class represents a single section in an ini-file, containing
    /// a set of keys and their values. The class contains methods to convert the
    /// values to and from their intended type when fetching and storing them.
    /// </summary>
    public class IniSection
    {
        ///< summary>The keys read from the ini file</summary>
        private List<String> iniKeys;
        /// <summary>Lower case versions of the keys read from the ini file, for quick case-insensitive comparison<summary>
        private List<String> iniKeysLower;
        /// <summary>The values associated to the keys</summary>
        private List<String> iniValues;
        /// <summary>The name of the ini section</summary>
        private String name;

        /// <summary>Returns the name of this ini section</summary>
        /// <returns>The name of this ini section</returns>
        public String getName()
        {
            return name;
        }

        /// <summary>Sets the name of this ini section.</summary>
        /// <param name="name">The new name for this ini section</param>
        public void setName(String name)
        {
            this.name = name;
        }

        /// <summary>Creates a new Ini section object with the specified name</summary>
        /// <param name="name">The name for this ini section</param>
        public IniSection(String name)
        {
            this.name = name;
            iniKeys = new List<String>();
            iniKeysLower = new List<String>();
            iniValues = new List<String>();
        }

        /// <summary>Gets a String from the ini section</summary>
        /// <param name="key">The name of the key</param>
        /// <param name="defaultValue">The default value to return in case the key was not found</param>
        /// <param name="success">An output parameter containing a boolean which is set to 'false' if the fetch failed and the default value was returned, and to 'true' if the value was successfully fetched.</param>
        /// <returns>The found value, or the given default value if the fetch failed</returns>
        public String getStringValue(String key, String defaultValue, out Boolean success)
        {
            if (key == null || key.Length == 0)
                throw new ArgumentException("Key can not be empty");
            int index = iniKeysLower.IndexOf(key.ToLower());
            success = index > -1;
            if (success)
                return iniValues[index];
            return defaultValue;
        }

        /// <summary>Sets a String value in the ini section.</summary>
        /// <param name="key">The name of the key</param>
        /// <param name="value">Value to write</param>
        public void setStringValue(String key, String value)
        {
            if (key == null || key.Length == 0)
                throw new ArgumentException("Key can not be empty");
            int index = iniKeysLower.IndexOf(key.ToLower());
            Boolean success = index > -1;
            if (success)
                iniValues[index] = value;
            else
            {
                iniKeys.Add(key);
                iniKeysLower.Add(key.ToLower());
                iniValues.Add(value);
            }
        }

        /// <summary>Gets an Integer from the ini section.</summary>
        /// <param name="key">The name of the key</param>
        /// <param name="defaultValue">The default value to return in case the key was not found</param>
        /// <param name="success">An output parameter containing a boolean which is set to 'false' if the fetch failed and the default value was returned.</param>
        /// <returns>The found value, or the given default value if the fetch failed.</returns>
        public int getIntValue(String key, int defaultValue, out Boolean success)
        {
            String value = getStringValue(key, defaultValue.ToString(), out success);
            if (success)
            {
                try
                {
                    value = splitOffComment(value)[0];
                    int intvalue = int.Parse(value);
                    return intvalue;
                }
                catch (Exception e)
                {
                    success = false;
                }
            }
            return defaultValue;
        }

        /// <summary>Sets an Integer value in the ini section.</summary>
        /// <param name="key">The name of the key</param>
        /// <param name="value">Value to write</param>
        /// <param name="removeComments">True to remove any comments put behind the value. The default behaviour is to filter out the comment and paste it behind the new value</param>
        public void setIntValue(String key, int value, Boolean removeComments)
        {
            Boolean exists = true;
            String strValue = getStringValue(key, String.Empty, out exists);
            String comment = String.Empty;
            if (exists && removeComments)
                comment = splitOffComment(strValue)[1];
            strValue = value.ToString() + comment;
            setStringValue(key, strValue);
        }

        /// <summary>Gets a Character from the ini section.</summary>
        /// <param name="key">The name of the key</param>
        /// <param name="defaultValue">The default value to return in case the key was not found</param>
        /// <param name="success">An output parameter containing a boolean which is set to 'false' if the fetch failed and the default value was returned.</param>
        /// <returns>The found value, or the given default value if the fetch failed.</returns>
        public char getCharValue(String key, char defaultValue, out Boolean success)
        {
            String value = getStringValue(key, defaultValue.ToString(), out success);
            if (success)
            {
                try
                {
                    char charvalue = splitOffComment(value)[0][0];
                    return charvalue;
                }
                catch // out of bounds
                {
                    success = false;
                }
            }
            return defaultValue;
        }

        /// <summary>Sets a Character value in the ini section.</summary>
        /// <param name="key">The name of the key</param>
        /// <param name="value">Value to write</param>
        /// <param name="removeComments">True to remove any comments put behind the value. The default behaviour is to filter out the comment and paste it behind the new value</param>
        public void setCharValue(String key, char value, Boolean removeComments)
        {
            Boolean exists = true;
            String strValue = getStringValue(key, String.Empty, out exists);
            String comment = String.Empty;
            if (exists && removeComments)
                comment = splitOffComment(strValue)[1];
            strValue = value.ToString() + comment;
            setStringValue(key, strValue);
        }

        /// <summary>Gets a Boolean from the ini section. Note that the string-to-boolean conversion method actually only checks the first character.</summary>
        /// <param name="key">The name of the key</param>
        /// <param name="defaultValue">The default value to return in case the key was not found</param>
        /// <param name="success">An output parameter containing a boolean which is set to 'false' if the fetch failed and the default value was returned.</param>
        /// <returns>The found value, or the given default value if the fetch failed.</returns>
        public Boolean getBoolValue(String key, Boolean defaultValue, out Boolean success)
        {
            String value = getStringValue(key, defaultValue.ToString(), out success);
            Boolean returnvalue = defaultValue;
            if (success && value.Length > 0)
            {
                value = splitOffComment(value)[0];
                if (value.Length < 1)
                {
                    success = false;
                    return defaultValue;
                }
                switch (Char.ToLower(value[0]))
                {
                    case 'y': // yes
                    case 't': // true
                    case 'a': // aye / active / activated
                    case 'e': // enabled
                        returnvalue = true; break;
                    case 'n': // no / nay
                    case 'f': // false
                    case 'd': // disabled / deactivated
                    case 'i': // inactive
                        returnvalue = false; break;
                    default:
                        try
                        {
                            int intvalue = int.Parse(value);
                            if (intvalue == 0) returnvalue = false;
                            else if (intvalue == 1) returnvalue = true;
                            else success = false;
                        }
                        catch (Exception e)
                        {
                            success = false;
                        }
                        break;
                }
            }
            else
            {
                success = false;
            }
            return returnvalue;
        }

        /// <summary>Sets a Boolean value in the ini section, in the chosen boolean save mode.</summary>
        /// <param name="key">The name of the key</param>
        /// <param name="value">Value to write</param>
        /// <param name="booleanmode">The BooleanMode (True/False, Yes/No, 1/0, etc) to use for saving Booleans as String.</param>
        /// <param name="removeComments">True to remove any comments put behind the value. The default behaviour is to filter out the comment and paste it behind the new value</param>
        public void setBoolValue(String key, Boolean value, BooleanMode booleanmode, Boolean removeComments)
        {
            Boolean exists = true;
            String strValue = getStringValue(key, String.Empty, out exists);
            String comment = String.Empty;
            if (exists && removeComments)
                comment = splitOffComment(strValue)[1];

            switch (booleanmode)
            {
                case BooleanMode.ONE_ZERO:
                    strValue = (value ? "1" : "0"); break;
                case BooleanMode.YES_NO:
                    strValue = (value ? "Yes" : "No"); break;
                case BooleanMode.ENABLED_DISABLED:
                    strValue = (value ? "Enabled" : "Disabled"); break;
                case BooleanMode.ACTIVE_INACTIVE:
                    strValue = (value ? "Active" : "Inactive"); break;
                case BooleanMode.AYE_NAY:
                    strValue = (value ? "Aye" : "Nay"); break;
                default: // includes True/False
                    strValue = value.ToString(); break;
            }
            strValue += comment;
            setStringValue(key, strValue);
        }

        /// <summary>Splits the comment off the given string value, and returns the two parts in a String array.</summary>
        /// <param name="value">The string to split</param>
        /// <returns>A 2-element string array with the value as first element and the split off comment as second value.</returns>
        private String[] splitOffComment(String value)
        {

            int spaceOffset = value.IndexOf(" ");
            int semicolonOffset = value.IndexOf(";");
            // Code to make sure the selected space offset is the first space of a
            // whitespace section before the semicolon. 
            // Code is currently disabled, because this function should only be used
            // for compact values like bools, ints and chars that don't use spaces.
            //*/
            if (semicolonOffset > spaceOffset)
                while (!Regex.Match(value.Substring(spaceOffset, semicolonOffset), "^[ \t]*$").Success)
                {
                    spaceOffset++;
                }
            //*/
            int commentOffset;
            String[] returnval = new String[2];
            if (spaceOffset >= 0 && semicolonOffset >= 0)
                commentOffset = Math.Min(spaceOffset, semicolonOffset);
            else if (spaceOffset >= 0)
                commentOffset = spaceOffset;
            else
                commentOffset = semicolonOffset;
            if (commentOffset > -1)
            {
                returnval[0] = value.Substring(0, commentOffset);
                returnval[1] = value.Substring(commentOffset);
            }
            else
            {
                returnval[0] = value;
                returnval[1] = String.Empty;
            }
            return returnval;
        }

        /// <summary>Removes a key from the ini section.</summary>
        /// <param name="key">The key to remove</param>
        public void removeKey(String key)
        {
            key = key.ToLower();
            int index = -1;
            for (int i = 0; i < iniKeysLower.Count; i++)
            {
                if (iniKeysLower[i].Equals(key))
                {
                    index = i;
                    break;
                }
            }
            if (index > -1)
            {
                iniKeys.RemoveAt(index);
                iniKeysLower.RemoveAt(index);
                iniValues.RemoveAt(index);
            }
        }

        /// <summary>Removes all keys in the ini section.</summary>
        public void clear()
        {
            iniKeys.Clear();
            iniKeysLower.Clear();
            iniValues.Clear();
        }

        /// <summary>Gets all keys from the ini section.</summary>
        /// <returns>A copy of the list of all key names in the ini section</returns>
        public List<String> getKeys()
        {
            return new List<String>(iniKeys);
        }

        /// <summary>Gets all lower case keys from the ini section.</summary>
        /// <returns>A copy of the list of all lower case key names in the ini section</returns>
        public List<String> getLowerCaseKeys()
        {
            return new List<String>(iniKeysLower);
        }

        /// <summary>Returns a copy of the ini section's key-value pairs map.</summary>
        /// <returns>A Dictionary with the key-value pairs</returns>
        public Dictionary<String, String> getKeyValuePairs()
        {
            return getKeyValuePairs(false);
        }

        /// <summary>Returns a copy of the ini section's key-value pairs map.</summary>
        /// <param name="lowercasekeys">True to return the keys as lowercase strings, for easier case-insensitive search.</param>
        /// <returns>A Dictionary with the key-value pairs</returns>
        public Dictionary<String, String> getKeyValuePairs(Boolean lowercasekeys)
        {
            Dictionary<String, String> dictionary = new Dictionary<String, String>();
            for (int i = 0; i < iniKeys.Count; i++)
                dictionary.Add((lowercasekeys ? iniKeysLower[i] : iniKeys[i]), iniValues[i]);
            return dictionary;
            /*
            // Requires .net 3.5 to work. Replaced because it's the only thing keeping it from running on 2.0.
            return iniKeys
                    .Select((k, i) => new { k, v = iniValues[i] })
                        .ToDictionary(x => (lowercasekeys ? x.k.ToLower() : x.k), x => x.v);
            //*/
        }

        public String toString()
        {
            return this.name;
        }
    }
}