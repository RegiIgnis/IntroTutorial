using RedLoader;
using SonsSdk;
using static RedLoader.RLog;

namespace IntroTutorial;

public class IntroTutorial : SonsMod
{
    public IntroTutorial()
    {

        // Uncomment any of these if you need a method to run on a specific update loop.

        //OnUpdateCallback = OnWorldUpdate;
        //OnLateUpdateCallback = MyLateUpdateMethod;
        //OnFixedUpdateCallback = MyFixedUpdateMethod;
        //OnGUICallback = MyGUIMethod;

        HarmonyPatchAll = true;
        // Uncomment this to automatically apply harmony patches in your assembly.
    }

    protected override void OnInitializeMod()
    {
        // Do your early mod initialization which doesn't involve game or sdk references here
        Config.Init();
    }

    protected override void OnSdkInitialized()
    {
        // Do your mod initialization which involves game or sdk references here
        // This is for stuff like UI creation, event registration etc.
        IntroTutorialUi.Create();
        //SettingsRegistry.CreateSettings(this, null, typeof(Config));
    }

    protected override void OnGameStart()
    {
        // This is called once the player spawns in the world and gains control.
        Msg("MyMessage");
        Msg("John");
        SonsTools.ShowMessage("Test",10.5f);
        Msg("");
        Warning("Warning Test");
        Error("Error Test");
        WriteLine(11);
        MsgDirect(System.Drawing.Color.Green, "MsgDirect Test");
        BigError("", "BigError");
        Debug("Debug");
        SonsTools.ShowMessage("SonsTools Show");
    }
}

// Press F9 to open the console in game. Thats where the message testing testing will appear.