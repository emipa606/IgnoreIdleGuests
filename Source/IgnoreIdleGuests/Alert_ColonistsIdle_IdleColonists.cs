using System.Collections.Generic;
using System.Linq;
using HarmonyLib;
using RimWorld;
using Verse;

namespace IgnoreIdleGuests
{
    [HarmonyPatch(typeof(Alert_ColonistsIdle), "IdleColonists", MethodType.Getter)]
    public class Alert_ColonistsIdle_IdleColonists
    {
        [HarmonyPostfix]
        public static void Postfix(ref List<Pawn> __result)
        {
            if (!__result.Any())
            {
                return;
            }

            var ignorePawns = __result.Where(pawn => pawn.WorkTagIsDisabled(WorkTags.AllWork)).ToList();

            __result.RemoveAll(pawn => ignorePawns.Contains(pawn));
        }
    }
}