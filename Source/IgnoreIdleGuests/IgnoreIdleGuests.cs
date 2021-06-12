using System.Reflection;
using HarmonyLib;
using Verse;

namespace IgnoreIdleGuests
{
    [StaticConstructorOnStartup]
    public static class IgnoreIdleGuests
    {
        static IgnoreIdleGuests()
        {
            var harmony = new Harmony("Mlie.IgnoreIdleGuests");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}