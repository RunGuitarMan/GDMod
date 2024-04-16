using System.Reflection;
using Jotunn.Entities;
using Jotunn.Managers;
using Jotunn.Utils;
using UnityEngine;

namespace GDMod.Prefabs
{
    public static class CustomArmor
    {
        private static readonly AssetBundle Eikthyr = AssetUtils.LoadAssetBundleFromResources("eikthyrarmorset", Assembly.GetExecutingAssembly());
        private static readonly AssetBundle PlateArmor = AssetUtils.LoadAssetBundleFromResources("platearmor", Assembly.GetExecutingAssembly());
        
        public static void CustomArmorPrefab()
        {
            var gameObject1 = (GameObject)Eikthyr.LoadAsset("ArmorEikthyrChest");
            var gameObject2 = (GameObject)Eikthyr.LoadAsset("HelmetEikthyr");
            var gameObject3 = (GameObject)Eikthyr.LoadAsset("ArmorEikthyrLegs");
            
            var customItem = new CustomItem(gameObject1, false);
            var customItem2 = new CustomItem(gameObject2, false);
            var customItem3 = new CustomItem(gameObject3, false);
            
            ItemManager.Instance.AddItem(customItem);
            ItemManager.Instance.AddItem(customItem2);
            ItemManager.Instance.AddItem(customItem3);
            
            var gameObject4 = (GameObject)PlateArmor.LoadAsset("ArmorPlateIronHelmetJD");
            var gameObject5 = (GameObject)PlateArmor.LoadAsset("ArmorPlateIronChestJD");
            var gameObject6 = (GameObject)PlateArmor.LoadAsset("ArmorPlateIronLegsJD");
            
            var customItem4 = new CustomItem(gameObject4, false);
            var customItem5 = new CustomItem(gameObject5, false);
            var customItem6 = new CustomItem(gameObject6, false);
            
            ItemManager.Instance.AddItem(customItem4);
            ItemManager.Instance.AddItem(customItem5);
            ItemManager.Instance.AddItem(customItem6);
            
            PrefabManager.OnVanillaPrefabsAvailable -= CustomArmorPrefab;
        }
    }
}