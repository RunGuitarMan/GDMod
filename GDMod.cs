using BepInEx;
using GDMod.Prefabs;
using HarmonyLib;
using Jotunn.Managers;

namespace GDMod
{
    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
    public class Main : BaseUnityPlugin
    {
        private static readonly Harmony Harmony = new Harmony("GrayDwarfMod");

        private const string PluginGuid = "GrayDwarfMod";
        private const string PluginName = "GDMod";
        private const string PluginVersion = "2.1.0";
        
        public void Awake()
        {
            PrefabManager.OnVanillaPrefabsAvailable += GdItems.GdItemsPrefab;
            PrefabManager.OnVanillaPrefabsAvailable += CustomItems.CustomItemsPrefab;
            PrefabManager.OnVanillaPrefabsAvailable += WarfareItems.WarfareItemsPrefab;
            PrefabManager.OnVanillaPrefabsAvailable += CustomMobs.CustomMobsPrefab;
            PrefabManager.OnVanillaPrefabsAvailable += CustomArmor.CustomArmorPrefab;
            PrefabManager.OnVanillaPrefabsAvailable += Economy.EconomyPrefab;
            
            var harmonyLocal = Harmony;
            if (harmonyLocal != null)
            {
                harmonyLocal.PatchAll();
            }
        }

        public void OnDestroy()
        {
            var harmonyLocal = Harmony;
            harmonyLocal?.UnpatchSelf();
        }
    }
}
