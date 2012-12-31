using System;
using System.Collections.Generic;
using System.Text;
using Nyerguds.Ini;
using System.IO;
using System.Windows.Forms;

namespace RedAlertConfig
{
    class Files
    {
        public static IniFile RedAlertINI;
        public static IniFile DDrawINI;
        public static string Path_;

        public static void Init()
        {
            char seperator = System.IO.Path.DirectorySeparatorChar;
            Path_ = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            DDrawINI = new IniFile(Path_ + seperator + "ddraw.ini", false, BooleanMode.TRUE_FALSE, Encoding.Default);
            RedAlertINI = new IniFile(Path_ + seperator + "redalert.ini", false, BooleanMode.YES_NO, Encoding.Default);

            Check_Required_File("ddraw.dll");
            Check_Required_File("ForceAMrules.ini");
            Check_Required_File("thipx32.dll");
            Check_Required_File("ForceAMRulesFastBuildSpeed.ini");
            Check_Required_File("ForceAMrules.ini");
        }

        public static void Check_Required_File(string file)
        {
            String path = Path_ + Path.DirectorySeparatorChar + "ConfigToolFiles"
                + Path.DirectorySeparatorChar + file;
            if (!File.Exists(path))
            {
                MessageBox.Show(String.Format("File '{0}' can't be found in the ConfigToolFiles folder, " +
                "this is a file neccessary for this application to run so please restore it.", file), 
                    "Required data file not found");

                Environment.Exit(0);
            }
        }
    }


}
