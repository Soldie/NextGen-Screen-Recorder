using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NextGen_Screen_Recorder
{
    public class StaticData
    {
        //A reference to MainForm
        public static Form1 MainForm;

        //A reference to Notification Tray Icon
        public static Icon NotificationTrayIcon;
    }

    public class Prefs
    {
        //Wether to Hide to Tray or Exit Application
        public static bool HideToTrayOnClose = true;

        public static void ReadPrefs()
        {
            
        }
    }
}
