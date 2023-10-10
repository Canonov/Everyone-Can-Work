using HarmonyLib;
using Verse;

namespace EveryoneCanWork
{
    [StaticConstructorOnStartup]
    public class StartupPatcher
    {

        static StartupPatcher()
        {
            var harmony = new Harmony("com.EveryoneCanWork.patches");
            harmony.PatchAll();
        }
        
    }
}