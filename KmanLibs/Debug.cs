using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace KmanLibs
{
    public static class Debug
    {
        public static void Log(object Message)
        {
            UnityEngine.Debug.Log("LOG: " + DateTime.UtcNow.ToString() + " : " + Message);
        }

        public static void LogError(object Message)
        {
            UnityEngine.Debug.LogError("ERROR: " + DateTime.UtcNow.ToString() + " : " + Message);
        }
    }
}
