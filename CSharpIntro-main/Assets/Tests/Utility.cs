using System;
using System.Reflection;

using UnityEditor;

namespace Editor.Tests
{
    public static class Utility
    {
        public static void ClearLogConsole()
        {
            Assembly assembly = Assembly.GetAssembly(typeof(SceneView));
            Type logEntries = assembly.GetType("UnityEditor.LogEntries");
            MethodInfo clearConsoleMethod = logEntries.GetMethod("Clear");
            clearConsoleMethod!.Invoke(new object(), null);
        }
    }
}
