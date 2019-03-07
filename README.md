# SynthRidersPluginBasic
A Basic SynthRiders Plugin

Requirements:
Synth Riders

Harmony (https://github.com/pardeike/Harmony)
Ensure that you select (as of this writing) .NET 3.5 in the project options
Build Harmony and copy the resultant DLL to SynthRiders/SynthRiders_Data/Managed/

Locate DLL References for this project in your SynthRiders/SynthRiders_Data/Managed/ folder
Change the output folder for the project to your "SynthRiders/Plugins" folder
Build

Run Synthriders with --verbose to confirm it works

You should see something similar to the following upon starting the game and seeing the Warning Screen:

> SynthRiders
> Running on Unity 2017.4.6f1
> -----------------------------
> Loading plugins from G:\Games\Steam\steamapps\common\SynthRiders\Plugins and found 1
> -----------------------------
> Synth Riders Plugin Basic: 0.0.1
> -----------------------------
> [SynthRidersPluginBasic] Hooking into activeSceneChanged
> [SynthRidersPluginBasic] Hooking into SceneLoaded
> Setting breakpad minidump AppID = 885000
> Steam_SetMinidumpSteamID:  Caching Steam ID:  76561197967433797 [API loaded no]
> [SynthRidersPluginBasic] Active Scene Changed:  to 0.AWarning
> [SynthRidersPluginBasic] Scene Loaded: 0.AWarning 2
> [SynthRidersPluginBasic] Loaded Level #0
> [SynthRidersPluginBasic] Initialized Level #0
