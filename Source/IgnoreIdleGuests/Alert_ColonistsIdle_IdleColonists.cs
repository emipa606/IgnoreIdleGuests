using System.Collections.Generic;
using HarmonyLib;
using RimWorld;
using Verse;

namespace IgnoreIdleGuests;

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

        __result.RemoveAll(pawn =>
            pawn.WorkTagIsDisabled(WorkTags.AllWork) || pawn.GuestStatus == GuestStatus.Guest ||
            pawn.questTags?.Any() == true);
    }
}