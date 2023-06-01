using BepInEx;
using HarmonyLib;
using BepInEx.Configuration;
using Jotunn.Managers;
using UnityEngine;
using Jotunn.Entities;
using Jotunn.Configs;

namespace GDMod
{
    [BepInPlugin(PluginGUID, PluginName, PluginVersion)]
    [BepInDependency(Jotunn.Main.ModGuid)]
    public class Main : BaseUnityPlugin
    {
        public const string PluginGUID = "com.jotunn.GDMod";
        public const string PluginName = "GDMod";
        public const string PluginVersion = "1.0.0";

        public static Harmony harmony = new Harmony(PluginGUID);

        public void Awake()
        {
            PrefabManager.OnVanillaPrefabsAvailable += CloneBoss;
            PrefabManager.OnVanillaPrefabsAvailable += CustomOre;
            harmony?.PatchAll();
        }

        public void OnDestroy()
        {
            harmony?.UnpatchSelf();
        }

        public void CloneBoss()
        {
            GameObject gameObject = PrefabManager.Instance.CreateClonedPrefab("CustomBoss", "Bonemass"); //Bonemass можно менять на любого моба. От него унаследуются хар-ки
            CustomCreature customBoss = new CustomCreature(gameObject, false); //CustomBoss - имя для призыва(Spawn CustomBoss)
            /*
            var configB = new CreatureConfig()
            configB.AddDropConfig(new DropConfig  //Лут
            {
                Item = "CopperOre",
                Chance = 100f,
                LevelMultiplier = false,
                MinAmount = 10,
                MaxAmount = 20,
                //OnePerPlayer = true
            });
            /*
            
            /*
            configB.AddSpawnConfig(new SpawnConfig //Где будет по дефолту спавниться
            {
                Name = "",
                SpawnChance = 100,
                SpawnInterval = 20f,
                SpawnDistance = 1f,
                Biome = Heightmap.Biome.Meadows,
                MinLevel = 3
            });*/

            //customBoss = new CustomCreature("CustomBoss", "Bonemass", configB); //Раскомментировать, чтоб применить настройки выше
            var customB = customBoss.Prefab.GetComponent<Humanoid>();

            customB.m_name = "SomeNameOfBoss"; //Имя боса
            customB.m_health = 1000; //Хп-шки
            //customB.m_runSpeed = 0;
            //customB.m_walkSpeed = 0;
            //customB.m_damageModifiers.m_fire = 0; Добавить урон огнем
            CreatureManager.Instance.AddCreature(customBoss);
            PrefabManager.OnVanillaPrefabsAvailable -= CloneBoss;
        }
        public void CustomOre()
        {
            GameObject gameObject = PrefabManager.Instance.CreateClonedPrefab("CustomOre", "CopperOre");
            CustomItem customItem = new CustomItem(gameObject, false);
            customItem.ItemDrop.m_itemData.m_shared.m_name = "Руда";
            customItem.ItemDrop.m_itemData.m_shared.m_description = "Руда для доставки";
            ItemManager.Instance.AddItem(customItem);
            PrefabManager.OnVanillaPrefabsAvailable -= CustomOre;

        }


    }
}