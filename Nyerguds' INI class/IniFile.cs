﻿/*
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
using System.IO;

namespace Nyerguds.ini
{
	/// <summary>
	/// <p>This class represents a standard type ini file, which uses sections specified
	/// by a string between square brackets, and key-value pairs separated by the
	/// "equal" sign without any spaces padding the separator.</p>
	/// <p>Example:</p>
	/// <p>[Section]
	/// <br />Key1=value1
	/// <br />Key2=value2</p>
	/// <p>Keys and section names are treated as case insensitive, but the case used
	/// when first reading or creating a key or section will be preserved. For
	/// compatibility reasons, it is possible to force the ini system to write
	/// all of its keys with an upper case starting letter.</p>
	/// <p>Lines starting with a semicolon are seen as comments, and
	/// ignored by the reading system. For non-string data, there is a function to
	/// preserve comments put behind a value. There is no functionality for editing
	/// comments though.</p>
    /// </summary>
	public class IniFile
	{
	    protected String filePath;
	
	    public static BooleanMode DEFAULT_BOOLEANMODE = BooleanMode.YES_NO;
	    public static Boolean DEFAULT_REMOVECOMMENTS = false;
	    public static Encoding ENCODING_DOS_US() { return Encoding.GetEncoding(437); }
	    public static Encoding DEFAULT_ENCODING = Encoding.UTF8;
	
	    protected List<IniSection> iniSections;
        protected List<String> removedSections;
        
	    /// <summary>When enabled, this makes sure all ini keys that get saved start with a capital letter.</summary>
	    protected Boolean initialCaps=true;
	    protected Encoding encoding;
	    protected String fileContents=null;
	    
	    /// <summary>When enabled, this makes sure all ini keys that get saved start with a capital letter.</summary>
	    /// <returns>true if the ini is set to convert the first letter of every key to upper case when writing to the file</returns>
	    public Boolean getInitialCaps()
	    {
	        return initialCaps;
	    }
	
	    /// <summary>When enabled, this makes sure all ini keys that get saved start with a capital letter.</summary>
	    /// <param name="initialCaps">Boolean that determines whether the ini will convert the first letter of every key to upper case when writing to the file</param>
	    public void setInitialCaps(Boolean initialCaps)
	    {
	        this.initialCaps = initialCaps;
	    }
	
	    /// <summary>Returns the path used as input and output file.</summary>
	    /// <returns>The path used as input and output file.</returns>
	    public String getFilePath()
	    {
	        return filePath;
	    }
	    
	    /// <summary>
	    /// Changes the file path to use as input and output file. This does not
        /// do an automatic read or write of that path. Use <b>readIniFile</b>
        /// to change the path and do an automatic read.
        /// </summary>
        /// @param filePath  the path to use as input and output file.
	    public void setFilePath(String filePath)
	    {
	        this.filePath = filePath;
	    }
	    
	    /// <summary>Retrieves the virtual file contents of the INI object. Can only be used if no path was given to the ini file.</summary>
	    /// <returns>The contents of the ini file object.</returns>
	    public String getFileContents()
	    {
	        return fileContents;
	    }
	    
	    /// <summary>Gets the character encoding currently set to be used by the IniFile object for I/O operations.</summary>
	    /// <returns>the character encoding used for handling I/O</returns>
	    public Encoding getEncoding()
	    {
	        return encoding;
	    }
	
	    /// <summary>Sets the character encoding to be used by the IniFile object for I/O operations.</summary>
        /// @param encoding  the character encoding to be used for handling I/O
	    public void setEncoding(Encoding encoding)
	    {
	        this.encoding = encoding;
	    }
	

        /// <summary>
        ///     Creates an object for reading, editing and writing an ini file.
        /// </summary>
        /// <param name="filePath">Path of the file to read</param>
        /// <param name="initialCaps">Write back all ini keys with initial capital letter</param>
        /// <param name="textEncoding">Text encoding to use for reading (and writing) the file</param>
        public IniFile(String filePath, Boolean initialCaps, Encoding textEncoding)
        {
            if (textEncoding == null) throw new ArgumentNullException("textEncoding");
            if (filePath == null)     throw new ArgumentNullException("filePath");
            this.removedSections = new List<String>(); 
            this.initialCaps = initialCaps;
            readIniFile(filePath, textEncoding);
        }

        /// <summary>
        ///     Creates an object for reading, editing and writing an ini file,
        ///     with the default DOS U.S. ASCII-437 encoding.
        /// </summary>
        /// <param name="filePath">Path of the file to read</param>
        /// <param name="initialCaps">Write back all ini keys with initial capital letter</param>
        public IniFile(String filePath, Boolean initialCaps) : this(filePath, initialCaps, DEFAULT_ENCODING) { }

        /// <summary>
        ///     Creates an object for reading, editing and writing an ini file.
        ///     set to write back all ini keys with initial capital letter.
        /// </summary>
        /// <param name="filePath">Path of the file to read</param>
        /// <param name="textEncoding">Text encoding to use for reading (and writing) the file</param>
        public IniFile(String filePath, Encoding textEncoding): this(filePath, true, textEncoding) { }

        /// <summary>
        ///     Creates an object for reading, editing and writing an ini file,
        ///     set to write back all ini keys with initial capital letter, and
        ///     with the default DOS U.S. ASCII-437 encoding.
        /// </summary>
        /// <param name="filePath">Path of the file to read</param>
        public IniFile(String filePath) : this(filePath, true, DEFAULT_ENCODING) { }

        /// <summary>
        ///     Creates an object for reading, editing and writing an ini file
        ///     that doesn't necessarily exist yet.
        /// </summary>
        /// <param name="filePath">Path of the file to read</param>
        /// <param name="filecontents">String with the file contents in it</param>
        /// <param name="initialCaps">Write back all ini keys with initial capital letter</param>
        /// <param name="textEncoding">Text encoding to use for reading (and writing) the file</param>
        public IniFile(String filePath, String filecontents, Boolean initialCaps, Encoding textEncoding)
        {
            this.filePath = filePath;
            this.encoding = textEncoding;
            this.removedSections = new List<String>();
            byte[] byteArray = encoding.GetBytes(filecontents);
            MemoryStream stream = new MemoryStream(byteArray);
            StreamReader reader = new StreamReader(stream, encoding, false);
            this.iniSections = readIniContents(reader, encoding);
        }

        /// <summary>
        ///     Creates an object for reading, editing and writing an ini file
        ///     that doesn't necessarily exist yet,
        ///     set to write back all ini keys with initial capital letter, and
        ///     with the default DOS U.S. ASCII-437 encoding.
        /// </summary>
        /// <param name="filePath">Path of the file to read</param>
        /// <param name="filecontents">String with the file contents in it</param>
        public IniFile(String filePath, String filecontents) : this(filePath, filecontents, true, DEFAULT_ENCODING) { }

        /// <summary>
        ///     Creates an object for reading, editing and writing an ini file
        ///     that doesn't necessarily exist yet
        ///     set to write back all ini keys with initial capital letter.
        /// </summary>
        /// <param name="filePath">Path of the file to read</param>
        /// <param name="filecontents">String with the file contents in it</param>
        /// <param name="textEncoding">Text encoding to use for reading (and writing) the file</param>
        public IniFile(String filePath, String filecontents, Encoding textEncoding) : this(filePath, filecontents, true, textEncoding) { }

        /// <summary>
        ///     Creates an object for reading, editing and writing an ini file
        ///     that doesn't necessarily exist yet,
        ///     with the default DOS U.S. ASCII-437 encoding.
        /// </summary>
        /// <param name="filePath">Path of the file to read</param>
        /// <param name="filecontents">String with the file contents in it</param>
        /// <param name="initialCaps">Write back all ini keys with initial capital letter</param>
        public IniFile(String filePath, String filecontents, Boolean initialCaps) : this(filePath, filecontents, initialCaps, DEFAULT_ENCODING) { }

	    /// <summary>
	    /// Sets the path for the ini file to a new string; and reads that file.
        /// This function does a complete reset of the object's data.
        /// </summary>
        /// @param iniFilePath   Path of the file to read
	    public void readIniFile(String iniFilePath)
	    {
	        this.readIniFile(iniFilePath, encoding);
	    }
	
	    /// <summary>
	    /// Sets the path for the ini file to a new string; and reads that file.
        /// This function does a complete reset of the object's data.
        /// </summary>
	    /// <param name="iniFilePath">Path of the file to read</param>
	    /// <param name="charEncoding">Character encoding to use</param>
	    public void readIniFile(String iniFilePath, Encoding charEncoding)
	    {
	        this.filePath = iniFilePath;
	        this.encoding = charEncoding;
            if (File.Exists(filePath))
            {
	            StreamReader stream = null;
	            try
	            {
	                stream = new StreamReader(filePath, encoding, false);
	            }
	            catch {}
	            this.iniSections = readIniContents(stream, encoding);
	        }
	        else
	            this.iniSections = new List<IniSection>();
	    }
	
	    /// <summary>Reads the ini contents of a stream, and returns it as a list of ini sections.</summary>
	    /// <param name="stream>the InputStream to read the ini data from.</param>
	    /// <returns>A List of IniSection objects with the read data.</returns>
	    protected List<IniSection> readIniContents(StreamReader stream, Encoding charEncoding)
	    {
	        List<IniSection> readIniSections = new List<IniSection>();
	        if (stream == null)
	            return readIniSections;
	        try
	        {
	            String input = null;
	            IniSection iniSection = null;
	            String[] keyValue;
	
	            List<String> initext = readLinesFromTextStream(stream, charEncoding);
	            
	            for (int i = 0; i < initext.Count; i++)
	            {
	                input = initext[i];
	                if (input.StartsWith("[") && input.Contains("]"))
	                {
	                    String sectionName = input.Substring(1, input.IndexOf("]")-1);
	                    if (!sectionName.Contains("[")) // valid ini section
	                    {
	                        iniSection = null;
	                        int sectionIndex = -1;
	                        for (int j = 0; j < readIniSections.Count; j++)
	                        {
	                            IniSection testsec = readIniSections[j];
	                            if (testsec.getName().Equals(sectionName))
	                            sectionIndex = j;
	                        }
	                        if (sectionIndex > -1)
	                        {
	                            iniSection = readIniSections[sectionIndex];
	                        }
	                        if (iniSection == null) // doesn't exist yet
	                        {
	                            iniSection = new IniSection(sectionName);
	                            readIniSections.Add(iniSection);
	                        }
	                        else // section already exists; don't allow merging of different same-name sections. (needed for correct deleting of extra ini entries)
	                            iniSection = null;
	                    }
	                }
	                else if (iniSection!=null) // ini section was found (everything before first ini section is ignored)
	                {
	                    keyValue = getKeyAndValue(input);
	                    if (keyValue!=null && keyValue.Length == 2)
	                        iniSection.setStringValue(keyValue[0], keyValue[1]);
	
	                }
	            }
	        }
	        catch (Exception e) { }
	        return readIniSections;
	    }
	
	    /// <summary>Writes the modified ini object to the internally stored ini path.
        /// Note that the writing system does not technically overwrite the existing
        /// file; it just fills in the data, adds new sections, and adds and removes
        /// keys to adjust the file to the stored data. Unknown sections are not
        /// removed, and comments in the file are left untouched.</summary>
	    public void writeIni()
	    {
	        writeIni(this.filePath, this.encoding);
	    }
	
	    /// <summary>
	    /// Writes the modified ini object to a file.
        /// This function will not change the internal path set for the ini;
        /// it just allows saving a copy elsewhere. Note that if the target file
        /// already exists, the writing system does not technically overwrite the
        /// existing file; it just fills in the data, adds new sections, and adds and
        /// removes keys to adjust the file to the stored data. Unknown sections are
        /// not removed, and comments in the file are left untouched.
        /// </summary>
	    /// <param name="iniFilePath">Filename to write to</param>
	    /// <param name="charEncoding">Character encoding to use</param>
	    public void writeIni(String iniFilePath, Encoding charEncoding)
	    {
	        List<String> initext;
	        try
	        {
                //initext = new List<String>(File.ReadAllLines(iniFilePath, encoding));
	            StreamReader stream = null;
	            try
	            {
	                stream = new StreamReader(filePath, charEncoding, false);
	            }
	            catch {}
	            initext = readLinesFromTextStream(stream, charEncoding);
	        }
	        catch(Exception e)
	        {
	            initext = new List<String>();
	        }
	
	        foreach(IniSection section in iniSections)
	        {
	            // writes keys in original case
	            Dictionary<String, String> keypairs = section.getKeyValuePairs();
	            
	            foreach(KeyValuePair<String, String> iniPair in keypairs)
	            {
	                String newline = iniPair.Key;
	                if (initialCaps)
	                {
	                    newline = Char.ToUpper(newline[0]) + newline.Substring(1,newline.Length-1);
	                }
	                newline+= "=" + iniPair.Value;
                    int linenumber = findLine(initext, section.getName(), iniPair.Key);
	                if (linenumber >= 0)
	                    initext[linenumber] = newline;
	                else
	                {
                        linenumber = findLastSectionLine(initext, section.getName(), false) + 1;
	                    if (linenumber > 0)
	                        initext.Insert(linenumber, newline);
	                    else
	                    {
	                        if (initext.Count > 0)
	                            initext.Add("");
                            initext.Add("[" + section.getName() + "]");
	                        initext.Add(newline);
	
	                    }
	                }
	            }
	
	            // Removes all keys that are not in the section object. Does not remove empty sections.
	            // Looks up keys as case insensitive.
	            Dictionary<String, String> keypairsLower = section.getKeyValuePairs(true);
                int firstLine = findLine(initext, section.getName(), null);
                int lastLine = findLastSectionLine(initext, section.getName(), false);
	            if (firstLine >= 0 && firstLine + keypairsLower.Count < lastLine)
	            {
	                for (int line = lastLine; line > firstLine; line--)
	                {
	                    String[] keyVal = getKeyAndValue(initext[line]);
	                    if (keyVal != null && keyVal.Length == 2
	                            && keyVal[0] != null
	                            && !keypairsLower.ContainsKey(keyVal[0].ToLower()))
	                    {
	                        initext.RemoveAt(line);
	                    }
	                }
	            }
	        }
            // Remove explicitly removed sections
            foreach (String section in removedSections)
            {
                int firstLine = findLine(initext, section, null);
                int lastLine = findLastSectionLine(initext, section, true);

                initext.RemoveRange(firstLine, lastLine - firstLine + 1);
            }


	        /*
	        // trim all empty lines off the end of the file
	        while ((initext.Count > 0 && initext[initext.Count - 1].Equals("")))
	        {
	            initext.RemoveAt(initext.Count-1);
	        }
	        //*/
	        if (iniFilePath == null)
	        {
	            this.fileContents = "";
	            foreach (String line in initext)
	                fileContents += line + @"\n";

                byte[] byteArray = charEncoding.GetBytes(fileContents);
                MemoryStream stream = new MemoryStream(byteArray);
                StreamReader reader = new StreamReader(stream, charEncoding, false);
	            this.iniSections = readIniContents(reader, charEncoding);
	        }
	        else
	        {
	            StreamWriter sw = null;
	            IOException ex = null;
                try
                {
                    sw = new StreamWriter(iniFilePath, false, charEncoding);
                    foreach (String line in initext)
                        sw.WriteLine(line);
                }
                catch (IOException e) { }
	            finally
	            {
	                try
	                {
	                    if (sw !=null)
	                        sw.Close();
	                }
	                catch{}
	            }
	            readIniFile(iniFilePath);
	        }
	    }
	
	    /// <summary>Finds the line of a specific section's key.</summary>
	    /// <param name="inifile">The ini file, as List of Strings</param>
	    /// <param name="inisection">The name of the section the key has to in</param>
	    /// <param name="inikey">The name of the key. If null, the index of the section will be returned.</param>
	    /// <returns>The index in the inifile List which holds the key</returns>
	    protected int findLine(List<String> inifile, String inisection, String inikey)
	    {
            if (inifile == null)
                throw new ArgumentNullException("inifile");
            if (inisection == null)
                throw new ArgumentNullException("inisection");
            String sectionName = null;
	        Boolean sectionfound = false;
	        inisection = inisection.ToLower();
	        if (inikey!=null)
	            inikey = inikey.ToLower();
	        for (int linenumber = 0; linenumber < inifile.Count; linenumber++)
	        {
	            String s = inifile[linenumber];
	            if (s.StartsWith("[") && s.Contains("]"))
	            {
	                sectionName = s.Substring(1, s.IndexOf("]")-1).ToLower();
	                sectionfound = sectionName.Equals(inisection);
	                if (inikey == null && sectionfound)
	                    return linenumber;
	            }
	            else if (sectionfound) // correct ini section was found
	            {
	                String[] keyVal = getKeyAndValue(s);
	                if (keyVal!=null && keyVal[0] != null && keyVal[0].ToLower().Equals(inikey))
	                    return linenumber;
	            }
	        }
	        return -1;
	    }
	
	    /// <summary>This function finds the last key line of an ini section, allowing new keys to be added behind it.</summary>
	    /// <param name="inifile">The ini file, as List of Strings</param>
	    /// <param name="inisection">The name of the section</param>
        /// <param name="includeBlanks">True if all blank lines after the section should be counted too</param>
	    /// <returns>The index of the last key in this section before a new section or the end of the file.</returns>
	    protected int findLastSectionLine(List<String> inifile, String inisection, Boolean includeBlanks)
	    {
	        int lastLine = inifile.Count-1;
	        Boolean sectionfound = false;
	        Boolean sectionwasfound = false;
	        inisection = inisection.ToLower();
            for (int linenumber = 0; linenumber < inifile.Count; linenumber++)
	        {
	            String sectionName = null;
	            String s = inifile[linenumber];
	            if (s.StartsWith("[") && s.Contains("]"))
	            {
	                sectionName = s.Substring(1, s.IndexOf("]")-1).ToLower();
	                sectionwasfound = sectionfound;
	                sectionfound = sectionName.Equals(inisection);
	                // requested section was encountered last time, and the start of the new one was found now.
	                if (sectionwasfound && !sectionfound)
	                {
	                    lastLine = linenumber - 1;
	                    break;
	                }
	            }
	        }
	        // trim off commented and non-key lines
	        if (sectionwasfound || sectionfound)
	        {
                int origLastLine = lastLine;

	            while (lastLine > 0 && !isValidKeyLine(inifile[lastLine]))
	                lastLine--;

                if (!includeBlanks)
                    return lastLine;
                else
                {
                    while (lastLine < origLastLine && inifile.Count > lastLine + 1 && String.Empty.Equals(inifile[lastLine + 1]))
                        lastLine++;
                    return lastLine;
                }

	        }
	        return -1;
	    }
	
	    /// <summary>Returns the value of the line, and returns the key name in the out parameter</summary>
	    /// <param name="input">input line of text</param>
	    /// <returns>A 2-element String array containing the key name and value</returns>
	    protected String[] getKeyAndValue(String input)
	    {
	        if (!isValidKeyLine(input))
	            return null;
	        
	        int separator = input.IndexOf('=');
	        if (separator < 1)
	            return null;
	                    
	        String[] returnval = new String[2];
	        returnval[0] = input.Substring(0, separator);
	        returnval[1] = input.Substring(separator + 1);
	        return returnval;
	    }
	
	    /// <summary>Gets a String from the ini file</summary>
	    /// <param name="sectionName">The name of the section the key should be in</param>
	    /// <param name="key">The name of the key</param>
	    /// <param name="defaultValue">The default value to return in case the key was not found</param>
	    /// <returns>The found value, or the given default value.</returns>
	    public String getStringValue(String sectionName, String key, String defaultValue)
	    {
            Boolean rb = true;
	        return getStringValue(sectionName, key, defaultValue, out rb);
	    }
	
	    /// <summary>Gets a String from the ini file</summary>
	    /// <param name="sectionName">The name of the section the key should be in</param>
	    /// <param name="key">The name of the key</param>
	    /// <param name="defaultValue">The default value to return in case the key was not found</param>
	    /// <param name="success">An output parameter containing a boolean which is set to 'false'if the fetch failed and the default value was returned.</param>
	    /// <returns>The found value, or the given default value if the fetch failed</returns>
	    public String getStringValue(String sectionName, String key, String defaultValue, out Boolean success)
	    {
	        IniSection iniSection = getSection(sectionName);
	        if (iniSection == null)
	        {
	            success = false;
	            return defaultValue;
	        }
	        return iniSection.getStringValue(key, defaultValue, out success);
	    }
	
	    /// <summary>Sets a String value in the ini file. This action does not save the file.</summary>
	    /// <param name="sectionName">The name of the section the key should be in</param>
	    /// <param name="key">The name of the key</param>
	    /// <param name="value">Value to write</param>
	    public void setStringValue(String sectionName, String key, String value)
	    {
	        IniSection iniSection = getSection(sectionName, true);
	        iniSection.setStringValue(key, value);
	    }
	
	    /// <summary>Gets an Integer from the ini file.</summary>
	    /// <param name="sectionName">The name of the section the key should be in</param>
	    /// <param name="key">The name of the key</param>
	    /// <param name="defaultValue">The default value to return in case the key was not found</param>
	    /// <returns>The found value, or the given default value if the fetch failed</returns>
	    public int getIntValue(String sectionName, String key, int defaultValue)
	    {
	        Boolean rb = true;
	        return getIntValue(sectionName, key, defaultValue, out rb);
	    }
	    
	    /// <summary>Gets an Integer from the ini file.</summary>
	    /// <param name="sectionName">The name of the section the key should be in</param>
	    /// <param name="key">The name of the key</param>
	    /// <param name="defaultValue">The default value to return in case the key was not found</param>
	    /// <param name="success">An output parameter containing a boolean which is set to 'false' if the fetch failed and the default value was returned.</param>
	    /// <returns>The found value, or the given default value if the fetch failed.</returns>
        public int getIntValue(String sectionName, String key, int defaultValue, out Boolean success)
	    {
	        IniSection iniSection = getSection(sectionName);
	        if (iniSection == null)
	        {
	            success = false;
	            return defaultValue;
	        }
	        return iniSection.getIntValue(key, defaultValue, out success);
	    }
	
	    /// <summary>Sets an Integer value in the ini file. This action does not save the file.</summary>
	    /// <param name="sectionName">The name of the section the key should be in</param>
	    /// <param name="key">The name of the key</param>
	    /// <param name="value">Value to write</param>
	    public void setIntValue(String sectionName, String key, int value)
	    {
	        this.setIntValue(sectionName, key, value, DEFAULT_REMOVECOMMENTS);
	    }
	
	    /// <summary>Sets an Integer value in the ini file. This action does not save the file.</summary>
	    /// <param name="sectionName">The name of the section the key should be in</param>
	    /// <param name="key">The name of the key</param>
	    /// <param name="value">Value to write</param>
	    /// <param name="removeComments">True to remove any comments put behind the value. The default behaviour is to filter out the comment and paste it behind the new value.</param>
	    public void setIntValue(String sectionName, String key, int value, Boolean removeComments)
	    {
	        IniSection iniSection = getSection(sectionName,true);
	        iniSection.setIntValue(key, value, removeComments);
	    }
	
	    /// <summary>Gets a Character from the ini file.</summary>
	    /// <param name="sectionName">The name of the section the key should be in</param>
	    /// <param name="key">The name of the key</param>
	    /// <param name="defaultValue">The default value to return in case the key was not found</param>
	    /// <returns>The found value, or the given default value if the fetch failed.</returns>
	    public char getCharValue(String sectionName, String key, char defaultValue)
	    {
	        Boolean rb = true;
	        return getCharValue(sectionName, key, defaultValue, out rb);
	    }
	
	    /// <summary>Gets a Character from the ini file.</summary>
	    /// <param name="sectionName">The name of the section the key should be in</param>
	    /// <param name="key">The name of the key</param>
	    /// <param name="defaultValue">The default value to return in case the key was not found</param>
	    /// <param name="success">An output parameter containing a boolean which is set to 'false' if the fetch failed and the default value was returned.</param>
	    /// <returns>The found value, or the given default value if the fetch failed.</returns>
        public char getCharValue(String sectionName, String key, char defaultValue, out Boolean success)
	    {
	        IniSection iniSection = getSection(sectionName);
	        if (iniSection == null)
	        {
	            success = false;
	            return defaultValue;
	        }
	        return iniSection.getCharValue(key, defaultValue, out success);
	    }
	
	    /// <summary>Sets a Character value in the ini file. This action does not save the file.</summary>
	    /// <param name="sectionName">The name of the section the key should be in</param>
	    /// <param name="key">The name of the key</param>
	    /// <param name="value">Value to write</param>
	    public void setCharValue(String sectionName, String key, char value)
	    {
	        this.setCharValue(sectionName, key, value, DEFAULT_REMOVECOMMENTS);
	    }
	
	    /// <summary>Sets a Character value in the ini file. This action does not save the file.</summary>
	    /// <param name="sectionName">The name of the section the key should be in</param>
	    /// <param name="key">The name of the key</param>
	    /// <param name="value">Value to write</param>
	    /// <param name="removeComments">True to remove any comments put behind the value. The default behaviour is to filter out the comment and paste it behind the new value.</param>
	    public void setCharValue(String sectionName, String key, char value, Boolean removeComments)
	    {
	        IniSection iniSection = getSection(sectionName, true);
	        iniSection.setCharValue(key, value, removeComments);
	    }
	
	    /// <summary>Gets a Boolean from the ini file.</summary>
	    /// <param name="sectionName">The name of the section the key should be in</param>
	    /// <param name="key">he name of the key</param>
        /// <param name="defaultValue">The default value to return in case the key was not found</param>
	    public Boolean getBoolValue(String sectionName, String key, Boolean defaultValue)
	    {
	        Boolean rb = true;
	        return getBoolValue(sectionName, key, defaultValue, out rb);
	    }
	    
	    /// <summary>
	    /// Gets a Boolean from the ini file. Note that the string-to-boolean
        /// conversion method actually only checks the first character.
        /// </summary>
	    /// <param name="sectionName">The name of the section the key should be in</param>
	    /// <param name="key">The name of the key</param>
	    /// <param name="defaultValue">The default value to return in case the key was not found</param>
	    /// <param name="success">An output parameter containing a boolean which is set to 'false' if the fetch failed and the default value was returned.</param>
	    /// <returns>The found value, or the given default value if the fetch failed.</returns>
	    public Boolean getBoolValue(String sectionName, String key, Boolean defaultValue, out Boolean success)
	    {
	        IniSection iniSection = getSection(sectionName);
	        if (iniSection == null)
	        {
	            success = false;
	            return defaultValue;
	        }
	        return iniSection.getBoolValue(key, defaultValue, out success);
	    }
	
	    /// <summary>Sets a Boolean value in the ini file, as Yes or No. This action does not save the file.</summary>
	    /// <param name="sectionName">The name of the section the key should be in</param>
	    /// <param name="key">The name of the key</param>
	    /// <param name="value">Value to write</param>
	    public void setBoolValue(String sectionName, String key, Boolean value)
	    {
	        this.setBoolValue(sectionName, key, value, DEFAULT_BOOLEANMODE, DEFAULT_REMOVECOMMENTS);
	    }
	
	    /// <summary>Sets a Boolean value in the ini file, as Yes or No. This action does not save the file.</summary>
	    /// <param name="sectionName">The name of the section the key should be in</param>
	    /// <param name="key">The name of the key</param>
	    /// <param name="value">Value to write</param>
	    /// <param name="removeComments">True to remove any comments put behind the value. The default behaviour is to filter out the comment and paste it behind the new value.</param>
	    public void setBoolValue(String sectionName, String key, Boolean value, Boolean removeComments)
	    {
	        this.setBoolValue(sectionName, key, value, DEFAULT_BOOLEANMODE, removeComments);
	    }
	
	    /// <summary>Sets a Boolean value in the ini file, in the chosen boolean save mode.
        /// This action does not save the file.</summary>
	    /// <param name="sectionName">The name of the section the key should be in</param>
	    /// <param name="key">The name of the key</param>
	    /// <param name="value">Value to write</param>
	    /// <param name="booleanmode">The BooleanMode (True/False, Yes/No, 1/0, etc) to use for saving Booleans as String.</param>
	    /// <param name="removeComments">True to remove any comments put behind the value. The default behaviour is to filter out the comment and paste it behind the new value.</param>
	    public void setBoolValue(String sectionName, String key, Boolean value, BooleanMode booleanmode, Boolean removeComments)
	    {
	        IniSection iniSection = getSection(sectionName,true);
	        iniSection.setBoolValue(key, value, booleanmode, removeComments);
	    }
	
	    /// <summary>Removes the specified key from the specified section</summary>
	    /// <param name="sectionName">The name of the section the key should be in</param>
	    /// <param name="key">The name of the key</param>
	    public void removeKey(String sectionName, String key)
	    {
	        IniSection iniSection = getSection(sectionName);
	        if (iniSection == null) return;
	        iniSection.removeKey(key);
	    }
	
	    /// <summary>Removes all keys in a section.</summary>
        /// @param sectionName    The name of the section
	    public void clearSection(String sectionName)
	    {
	        IniSection iniSection = getSection(sectionName);
	        if (iniSection == null) return;
	        iniSection.clear();
	    }
	    
	    /// <summary>Gets all keys from a section.</summary>
	    /// <param name="sectionName">The name of the section</param>
	    /// <returns>A list of all key names in the section</returns>
	    public List<String> getSectionKeys(String sectionName)
	    {
	        return this.getSectionKeys(sectionName,false);
	    }

        /// <summary>
        /// Removes a section from the ini file, and marks it for deletion on the next rewrite.
        /// </summary>
        /// <param name="sectionName"></param>
        public void removeSection(String sectionName)
        {
            for (int i = 0; i < iniSections.Count; i++)
            {
                IniSection testsec = iniSections[i];
                if (testsec.getName().ToLower().Equals(sectionName.ToLower()))
                {
                    removedSections.Add(testsec.getName());
                    iniSections.RemoveAt(i);
                    break;
                }
            }
        }


	    /// <summary>Gets all keys from a section.</summary>
	    /// <param name="sectionName">The name of the section</param>
	    /// <param name="lowercasekeys">True to return the keys as lowercase strings, for easier case-insensitive search.</param>
	    /// <returns>A list of all key names in the section.</returns>
	    public List<String> getSectionKeys(String sectionName, Boolean lowercasekeys)
	    {
	        IniSection iniSection = getSection(sectionName);
	        if (iniSection == null) return null;
	        if (lowercasekeys)
	            return iniSection.getKeys();
	        else
	            return iniSection.getLowerCaseKeys();
	    }
	    
	    /// <summary>Returns a copy of a specified section's key-value pairs map.</summary>
	    /// <param name="sectionName">The name of the section</param>
	    /// <returns>A Map with the key-value pairs</returns>
	    public Dictionary<String, String> getSectionContent(String sectionName)
	    {
	        IniSection iniSection = getSection(sectionName);
	        if (iniSection == null) return null;
	        return iniSection.getKeyValuePairs();
	    }
	
	    /// <summary>Returns a copy of a specified section's key-value pairs map.</summary>
	    /// <param name="sectionName">The name of the section</param>
	    /// <param name="lowercasekeys">True to return the keys as lowercase strings, for easier case-insensitive search.</param>
	    /// <returns>A Map with the key-value pairs</returns>
        public Dictionary<String, String> getSectionContent(String sectionName, Boolean lowercasekeys)
	    {
	        IniSection iniSection = getSection(sectionName);
	        if (iniSection == null) return null;
	        return iniSection.getKeyValuePairs(lowercasekeys);
	    }

        public List<String> getSectionNames()
        {
            List<String> sectionNames = new List<String>();
            foreach (IniSection section in iniSections)
                sectionNames.Add(section.getName());
            return sectionNames;
        }

	    /// <summary>Gets a section by name. Returns null if the section was not found.</summary>
	    /// <param name="sectionName">The name of the section</param>
	    /// <returns>The IniSection object, or null if not found.</returns>
	    protected IniSection getSection(String sectionName)
	    {
	        return getSection(sectionName, false);
	    }
	
	    /// <summary>Gets a section by name.</summary>
	    /// <param name="sectionName">The name of the section</param>
	    /// <param name="createWhenNotFound">If the section was not found, create a new section with that name and return that.</param>
	    /// <returns>The retrieved or new IniSection object with that name.</returns>
	    protected IniSection getSection(String sectionName, Boolean createWhenNotFound)
	    {
	        IniSection iniSection = null;
	
	        for (int i = 0; i < iniSections.Count; i++)
	        {
	            IniSection testsec = iniSections[i];
                if (testsec.getName().ToLower().Equals(sectionName.ToLower()))
	            {
	                iniSection = testsec;
	                break;
	            }
	        }
	
	        if (iniSection == null && createWhenNotFound) // doesn't exist yet
	        {
	            iniSection = new IniSection(sectionName);
	            iniSections.Add(iniSection);
	        }
	        return iniSection;
	    }
	    
	    /// <summary>Reads lines of text from a stream, and returns it as a List of strings.</summary>
	    /// <param name="stream">The stream to read as file</param>
	    /// <param name="charEncoding">The character encoding to use when reading the file</param>
	    /// <returns>A List of Strings, each String representing one line   </param>from the original text.</returns>
	    protected List<String> readLinesFromTextStream(StreamReader stream, Encoding charEncoding)
	    {
	        List<String> text = new List<String>();
	        String input = null;
	        
	        try
	        {
	            while ((input = stream.ReadLine()) != null)
	            {
	                text.Add(input);
	            }
	        }
	        finally
	        {
				stream.Close();
	        }
	        return text;
	    }
	    
	    /// <summary>A quick test to see if a line contains a valid ini key.</summary>
	    /// <param name="line">The input to test</param>
	    /// <returns>True if the line is not a comment, has key with a length greater than zero, and contains the '=' separator.</returns>
	    protected Boolean isValidKeyLine(String line)
	    {
	        return line.Length > 0 // contains data
	                && line[0] != ';' // is not a comment
                    && line[0] != '=' // key is not empty
	                && line.Contains("="); // contains separator
	    }

    }
}