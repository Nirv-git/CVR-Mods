using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Text.RegularExpressions;

namespace MuteTTS
{
    class Utils
    {
        public static string RemoveNewLine(string line, string replaceWith)
        {//https://stackoverflow.com/a/8196219
            return Regex.Replace(line, @"\r\n?|\n", replaceWith);
        }

        public static KeyCode ParseKeycode(string keybindString, KeyCode defaultCode)
        {
            if (Enum.TryParse(keybindString, true, out KeyCode keybind))
                return keybind;
            else
                return defaultCode;
        }

        public static bool IsLayerEnabled(int mask, int layer)
        {
            if ((mask & (1 << layer)) != 0)
                return true;
            else return false;
        }
    }
}
