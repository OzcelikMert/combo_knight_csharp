using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ComboKnight {
    class KeysPress {
        [DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);
        const uint KEYEVENTF_EXTENDEDKEY = 0x0001;
      public static int press() {
            //Press the key
            keybd_event((byte)KeyChange.Key1, 0, KEYEVENTF_EXTENDEDKEY | 0, 0);
            return 0;
        }

        [DllImport("user32.dll", EntryPoint = "keybd_event")]
        public static extern void keybd_event2(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);
        public static int press2() {
            //Press the key
            /*'Unable to find an entry point named 'keybd_event2' in DLL 'user32.dll'.'*/
            keybd_event2((byte)KeyChange.Key2, 0, KEYEVENTF_EXTENDEDKEY | 0, 0);
            return 0;
        }

        [DllImport("user32.dll", EntryPoint = "keybd_event")]
        public static extern void keybd_event3(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);
        public static int press3() {
            //Press the key
            keybd_event3((byte)KeyChange.Key3, 0, KEYEVENTF_EXTENDEDKEY | 0, 0);
            return 0;
        }

    }
}
