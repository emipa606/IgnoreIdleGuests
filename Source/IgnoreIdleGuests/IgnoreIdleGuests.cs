using System.Reflection;
using HarmonyLib;
using Verse;

namespace IgnoreIdleGuests;

[StaticConstructorOnStartup]
public static class IgnoreIdleGuests
{
    static IgnoreIdleGuests()
    {
        new Harmony("Mlie.IgnoreIdleGuests").PatchAll(Assembly.GetExecutingAssembly());
    }
}