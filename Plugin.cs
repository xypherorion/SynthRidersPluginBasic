using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using IllusionPlugin;
using UnityEngine.SceneManagement;
using UnityEngine;

namespace SynthRidersPluginBasic {
    public class Plugin : IPlugin {
        public string Name => "Synth Riders Plugin Basic";
        public string Version => "0.0.1";

        public bool writeLogOnExit = true;
        public static string logFilePath = "./Plugin.log";
        public static string LogFileData = "";

        public static void Log(string message) {
            Console.WriteLine("[{0}] {1}", "SynthRidersPluginBasic", message);
            LogFileData += message + "\n";
        }

        #region Unity Hooks
        public void OnApplicationStart() {
            Log("Hooking into activeSceneChanged");
            SceneManager.activeSceneChanged += SceneManagerOnActiveSceneChanged;
            Log("Hooking into SceneLoaded");
            SceneManager.sceneLoaded += SceneManager_sceneLoaded;
        }

        private void SceneManagerOnActiveSceneChanged(Scene arg0, Scene arg1) {
            Log("Active Scene Changed: " + arg0.name + " to " + arg1.name);
        }

        private void SceneManager_sceneLoaded(Scene arg0, LoadSceneMode arg1) {
            Log("Scene Loaded: " + arg0.name + " " + arg1.ToString());
        }

        public void OnApplicationQuit() {
            Log("Removing Hooks");
            SceneManager.activeSceneChanged -= SceneManagerOnActiveSceneChanged;
            SceneManager.sceneLoaded -= SceneManager_sceneLoaded;

            if (writeLogOnExit)
                File.WriteAllText(logFilePath, LogFileData, System.Text.Encoding.ASCII);
        }

        public void OnLevelWasLoaded(int level) {
            Log("Loaded Level #" + level.ToString());
        }

        public void OnLevelWasInitialized(int level) {
            Log("Initialized Level #" + level.ToString());
        }

        public void OnUpdate() {
        }

        public void OnFixedUpdate() {
        }
        #endregion
    }
}
