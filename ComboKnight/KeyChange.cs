using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboKnight {
    class KeyChange {
        public static byte DefaultKey1 = 0;
        public static byte DefaultKey2 = 0;
        public static byte DefaultKey3 = 0;

        public static byte Key1 = 0;
        public static byte Key2 = 0;
        public static byte Key3 = 0;

        public static void Change1() {
            Key1 = SettingsWindow.KeyValue1;
            DefaultKey1 = SettingsWindow.KeyValue1;
            if (Key1==1) {
              Key1 = 0x31;
            } else if (Key1 == 2) {
                Key1 = 0x32;
            } else if (Key1 == 3) {
                Key1 = 0x33;
            } else if (Key1 == 4) {
                Key1 = 0x34;
            } else if (Key1 == 5) {
                Key1 = 0x35;
            } else if (Key1 == 6) {
                Key1 = 0x36;
            } else if (Key1 == 7) {
                Key1 = 0x37;
            } else if (Key1 == 8) {
                Key1 = 0x38;
            } else if (Key1 == 9) {
                Key1 = 0x52;
            } else {
                Key1 = 0;
            }

        }

        public static void Change2() {
            Key2 = SettingsWindow.KeyValue2;
            DefaultKey2 = SettingsWindow.KeyValue2;
            if (Key2 == 1) {
                Key2 = 0x31;
            } else if (Key2 == 2) {
                Key2 = 0x32;
            } else if (Key2 == 3) {
                Key2 = 0x33;
            } else if (Key2 == 4) {
                Key2 = 0x34;
            } else if (Key2 == 5) {
                Key2 = 0x35;
            } else if (Key2 == 6) {
                Key2 = 0x36;
            } else if (Key2 == 7) {
                Key2 = 0x37;
            } else if (Key2 == 8) {
                Key2 = 0x38;
            } else if (Key2 == 9) {
                Key2 = 0x52;
            } else {
                Key2 = 0;
            }

        }

        public static void Change3() {
            Key3 = SettingsWindow.KeyValue3;
            DefaultKey3 = SettingsWindow.KeyValue3;
            if (Key3 == 1) {
                Key3 = 0x31;
            } else if (Key3 == 2) {
                Key3 = 0x32;
            } else if (Key3 == 3) {
                Key3 = 0x33;
            } else if (Key3 == 4) {
                Key3 = 0x34;
            } else if (Key3 == 5) {
                Key3 = 0x35;
            } else if (Key3 == 6) {
                Key3 = 0x36;
            } else if (Key3 == 7) {
                Key3 = 0x37;
            } else if (Key3 == 8) {
                Key3 = 0x38;
            } else if (Key3 == 9) {
                Key3 = 0x52;
            } else {
                Key3 = 0;
            }

        }

        public static void AllChangeStart() { 
            Change1();
            Change2();
            Change3();
        }

    }
}
