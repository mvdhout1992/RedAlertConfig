using System;
using System.Collections.Generic;
using System.Text;
using Nyerguds.Ini;

namespace RedAlertConfig
{
    class Files
    {
        public static IniFile RedAlertINI;
        public static IniFile DDrawINI;

        public static void Init()
        {
            // Check if our needed files exist and acquire a lock to them

            DDrawINI = new IniFile("ddraw.ini", BooleanMode.TRUE_FALSE);
            RedAlertINI = new IniFile("redalert.ini", BooleanMode.TRUE_FALSE);
            // FileStream.Lock()

        }
    }
}
