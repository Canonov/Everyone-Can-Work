using HarmonyLib;
using Verse;

// ReSharper disable RedundantAssignment
// ReSharper disable InconsistentNaming

namespace EveryoneCanWork
{
    [HarmonyPatch(typeof(LifeStageWorkSettings), "IsDisabled")]
    public class LifeStageWorkSettings_IsDisabled_Patch
    {
        private static void Postfix(ref bool __result)
        {
            __result = false;
        }
    }
}