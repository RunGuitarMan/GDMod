using System.Reflection;
using Jotunn.Entities;
using Jotunn.Managers;
using Jotunn.Utils;
using UnityEngine;

namespace GDMod.Prefabs
{
    public static class WarfareItems
    {
        private static readonly AssetBundle Fantasy = AssetUtils.LoadAssetBundleFromResources("FantasyArmoury", Assembly.GetExecutingAssembly());
        private static readonly AssetBundle Henrik = AssetUtils.LoadAssetBundleFromResources("henrikstests", Assembly.GetExecutingAssembly());
        private static readonly AssetBundle MagicBow = AssetUtils.LoadAssetBundleFromResources("MagicBows", Assembly.GetExecutingAssembly());
        
        public static void WarfareItemsPrefab()
        {
            var gameObject1 = (GameObject)Fantasy.LoadAsset("Shield_09_FA");
            var gameObject2 = (GameObject)Fantasy.LoadAsset("Shield_08_FA");
            var gameObject3 = (GameObject)Fantasy.LoadAsset("Shield_07_FA");
            var gameObject4 = (GameObject)Fantasy.LoadAsset("Shield_06_FA");
            var gameObject5 = (GameObject)Fantasy.LoadAsset("Shield_05_FA");
            var gameObject6 = (GameObject)Fantasy.LoadAsset("Shield_04_FA");
            var gameObject7 = (GameObject)Fantasy.LoadAsset("Shield_03_FA");
            var gameObject8 = (GameObject)Fantasy.LoadAsset("Shield_02_FA");
            var gameObject9 = (GameObject)Fantasy.LoadAsset("Shield_01_FA");
            var gameObject10 = (GameObject)Fantasy.LoadAsset("Axe_1H_07_FA");
            var gameObject11 = (GameObject)Fantasy.LoadAsset("Axe2H_01_FA");
            var gameObject12 = (GameObject)Fantasy.LoadAsset("Axe2H_02_FA");
            var gameObject13 = (GameObject)Fantasy.LoadAsset("Axe2H_03_FA");
            var gameObject14 = (GameObject)Fantasy.LoadAsset("Axe2H_04_FA");
            var gameObject15 = (GameObject)Fantasy.LoadAsset("Axe2H_05_FA");
            var gameObject16 = (GameObject)Fantasy.LoadAsset("Axe2H_06_FA");
            var gameObject17 = (GameObject)Fantasy.LoadAsset("Hammer_2H_01_FA");
            var gameObject18 = (GameObject)Fantasy.LoadAsset("Hammer_2H_02_FA");
            var gameObject19 = (GameObject)Fantasy.LoadAsset("Hammer_2H_03_FA");
            var gameObject20 = (GameObject)Fantasy.LoadAsset("Sword_2H_01_FA");
            var gameObject21 = (GameObject)Fantasy.LoadAsset("Sword_2H_02_FA");
            var gameObject22 = (GameObject)Fantasy.LoadAsset("Sword_2H_03_FA");
            var gameObject23 = (GameObject)Fantasy.LoadAsset("Sword_2H_04_FA");
            var gameObject24 = (GameObject)Fantasy.LoadAsset("Sword_2H_05_FA");
            var gameObject25 = (GameObject)Fantasy.LoadAsset("Sword_2H_06_FA");
            var gameObject26 = (GameObject)Fantasy.LoadAsset("Scythe2H_01_FA");
            var gameObject27 = (GameObject)Fantasy.LoadAsset("Staff_2H_01_FA");
            var gameObject28 = (GameObject)Fantasy.LoadAsset("Staff_2H_02_FA");
            var gameObject29 = (GameObject)Fantasy.LoadAsset("Staff_2H_03_FA");
            var gameObject30 = (GameObject)Fantasy.LoadAsset("Staff_2H_04_FA");
            var gameObject31 = (GameObject)Fantasy.LoadAsset("Staff_2H_05_FA");
            var gameObject32 = (GameObject)Fantasy.LoadAsset("Axe_1H_01_FA");
            var gameObject33 = (GameObject)Fantasy.LoadAsset("Axe_1H_02_FA");
            var gameObject34 = (GameObject)Fantasy.LoadAsset("Axe_1H_03_FA");
            var gameObject35 = (GameObject)Fantasy.LoadAsset("Axe_1H_04_FA");
            var gameObject36 = (GameObject)Fantasy.LoadAsset("Axe_1H_05_FA");
            var gameObject37 = (GameObject)Fantasy.LoadAsset("Axe_1H_06_FA");
            var gameObject38 = (GameObject)Fantasy.LoadAsset("Sword_1H_01_FA");
            var gameObject39 = (GameObject)Fantasy.LoadAsset("Sword_1H_02_FA");
            var gameObject40 = (GameObject)Fantasy.LoadAsset("Sword_1H_03_FA");
            var gameObject41 = (GameObject)Fantasy.LoadAsset("Sword_1H_04_FA");
            var gameObject42 = (GameObject)Fantasy.LoadAsset("Sword_1H_05_FA");
            var gameObject43 = (GameObject)Henrik.LoadAsset("HenriksTestSword");
            var gameObject44 = (GameObject)Henrik.LoadAsset("ScuffedSword");
            var gameObject45 = (GameObject)Henrik.LoadAsset("Megid");
            var gameObject46 = (GameObject)Henrik.LoadAsset("Musou_Isshin");
            var gameObject47 = (GameObject)Henrik.LoadAsset("Partizan");
            var gameObject48 = (GameObject)Henrik.LoadAsset("SkywardBlade");
            var gameObject49 = (GameObject)Henrik.LoadAsset("DarkSword");
            var gameObject50 = (GameObject)Henrik.LoadAsset("JadeCutter");
            var gameObject51 = (GameObject)Henrik.LoadAsset("TheFlute");
            var gameObject52 = (GameObject)Henrik.LoadAsset("HenrikMs");
            var gameObject53 = (GameObject)MagicBow.LoadAsset("BMB_Crossbow_Fiery");
            var gameObject54 = (GameObject)MagicBow.LoadAsset("BMB_Crossbow_Frost");
            var gameObject55 = (GameObject)MagicBow.LoadAsset("BMB_Crossbow_Lightning");
            var gameObject56 = (GameObject)MagicBow.LoadAsset("BMB_Crossbow_Spirit");
            var gameObject57 = (GameObject)MagicBow.LoadAsset("BMB_Crossbow_Toxic");
            var gameObject58 = (GameObject)MagicBow.LoadAsset("BMB_FieryBow");
            var gameObject59 = (GameObject)MagicBow.LoadAsset("BMB_FrozenBow");
            var gameObject60 = (GameObject)MagicBow.LoadAsset("BMB_LightningBow");
            var gameObject61 = (GameObject)MagicBow.LoadAsset("BMB_SpiritBow");
            var gameObject62 = (GameObject)MagicBow.LoadAsset("BMB_ToxicBow");
            
            var customItem = new CustomItem(gameObject1, false);
            customItem.ItemDrop.m_itemData.m_shared.m_itemType = (ItemDrop.ItemData.ItemType)5;
            
            var customItem2 = new CustomItem(gameObject2, false);
            customItem2.ItemDrop.m_itemData.m_shared.m_itemType = (ItemDrop.ItemData.ItemType)5;
            
            var customItem3 = new CustomItem(gameObject3, false);
            customItem3.ItemDrop.m_itemData.m_shared.m_itemType = (ItemDrop.ItemData.ItemType)5;
            
            var customItem4 = new CustomItem(gameObject4, false);
            customItem4.ItemDrop.m_itemData.m_shared.m_itemType = (ItemDrop.ItemData.ItemType)5;
            
            var customItem5 = new CustomItem(gameObject5, false);
            customItem5.ItemDrop.m_itemData.m_shared.m_itemType = (ItemDrop.ItemData.ItemType)5;
            
            var customItem6 = new CustomItem(gameObject6, false);
            customItem6.ItemDrop.m_itemData.m_shared.m_itemType = (ItemDrop.ItemData.ItemType)5;
            
            var customItem7 = new CustomItem(gameObject7, false);
            customItem7.ItemDrop.m_itemData.m_shared.m_itemType = (ItemDrop.ItemData.ItemType)5;
            
            var customItem8 = new CustomItem(gameObject8, false);
            customItem8.ItemDrop.m_itemData.m_shared.m_itemType = (ItemDrop.ItemData.ItemType)5;
            
            var customItem9 = new CustomItem(gameObject9, false);
            customItem9.ItemDrop.m_itemData.m_shared.m_itemType = (ItemDrop.ItemData.ItemType)5;
            
            var customItem10 = new CustomItem(gameObject10, false);
            var customItem11 = new CustomItem(gameObject11, false);
            var customItem12 = new CustomItem(gameObject12, false);
            var customItem13 = new CustomItem(gameObject13, false);
            var customItem14 = new CustomItem(gameObject14, false);
            var customItem15 = new CustomItem(gameObject15, false);
            var customItem16 = new CustomItem(gameObject16, false);
            var customItem17 = new CustomItem(gameObject17, false);
            var customItem18 = new CustomItem(gameObject18, false);
            var customItem19 = new CustomItem(gameObject19, false);
            var customItem20 = new CustomItem(gameObject20, false);
            var customItem21 = new CustomItem(gameObject21, false);
            var customItem22 = new CustomItem(gameObject22, false);
            var customItem23 = new CustomItem(gameObject23, false);
            var customItem24 = new CustomItem(gameObject24, false);
            var customItem25 = new CustomItem(gameObject25, false);
            var customItem26 = new CustomItem(gameObject26, false);
            var customItem27 = new CustomItem(gameObject27, false);
            var customItem28 = new CustomItem(gameObject28, false);
            var customItem29 = new CustomItem(gameObject29, false);
            var customItem30 = new CustomItem(gameObject30, false);
            var customItem31 = new CustomItem(gameObject31, false);
            var customItem32 = new CustomItem(gameObject32, false);
            var customItem33 = new CustomItem(gameObject33, false);
            var customItem34 = new CustomItem(gameObject34, false);
            var customItem35 = new CustomItem(gameObject35, false);
            var customItem36 = new CustomItem(gameObject36, false);
            var customItem37 = new CustomItem(gameObject37, false);
            var customItem38 = new CustomItem(gameObject38, false);
            var customItem39 = new CustomItem(gameObject39, false);
            var customItem40 = new CustomItem(gameObject40, false);
            var customItem41 = new CustomItem(gameObject41, false);
            var customItem42 = new CustomItem(gameObject42, false);
            var customItem43 = new CustomItem(gameObject43, false);
            var customItem44 = new CustomItem(gameObject44, false);
            var customItem45 = new CustomItem(gameObject45, false);
            var customItem46 = new CustomItem(gameObject46, false);
            var customItem47 = new CustomItem(gameObject47, false);
            var customItem48 = new CustomItem(gameObject48, false);
            var customItem49 = new CustomItem(gameObject49, false);
            var customItem50 = new CustomItem(gameObject50, false);
            var customItem51 = new CustomItem(gameObject51, false);
            var customItem52 = new CustomItem(gameObject52, false);
            var customItem53 = new CustomItem(gameObject53, false);
            var customItem54 = new CustomItem(gameObject54, false);
            var customItem55 = new CustomItem(gameObject55, false);
            var customItem56 = new CustomItem(gameObject56, false);
            var customItem57 = new CustomItem(gameObject57, false);
            var customItem58 = new CustomItem(gameObject58, false);
            var customItem59 = new CustomItem(gameObject59, false);
            var customItem60 = new CustomItem(gameObject60, false);
            var customItem61 = new CustomItem(gameObject61, false);
            var customItem62 = new CustomItem(gameObject62, false);
            
            ItemManager.Instance.AddItem(customItem);
            ItemManager.Instance.AddItem(customItem2);
            ItemManager.Instance.AddItem(customItem3);
            ItemManager.Instance.AddItem(customItem4);
            ItemManager.Instance.AddItem(customItem5);
            ItemManager.Instance.AddItem(customItem6);
            ItemManager.Instance.AddItem(customItem7);
            ItemManager.Instance.AddItem(customItem8);
            ItemManager.Instance.AddItem(customItem9);
            ItemManager.Instance.AddItem(customItem10);
            ItemManager.Instance.AddItem(customItem11);
            ItemManager.Instance.AddItem(customItem12);
            ItemManager.Instance.AddItem(customItem13);
            ItemManager.Instance.AddItem(customItem14);
            ItemManager.Instance.AddItem(customItem15);
            ItemManager.Instance.AddItem(customItem16);
            ItemManager.Instance.AddItem(customItem17);
            ItemManager.Instance.AddItem(customItem18);
            ItemManager.Instance.AddItem(customItem19);
            ItemManager.Instance.AddItem(customItem20);
            ItemManager.Instance.AddItem(customItem21);
            ItemManager.Instance.AddItem(customItem22);
            ItemManager.Instance.AddItem(customItem23);
            ItemManager.Instance.AddItem(customItem24);
            ItemManager.Instance.AddItem(customItem25);
            ItemManager.Instance.AddItem(customItem26);
            ItemManager.Instance.AddItem(customItem27);
            ItemManager.Instance.AddItem(customItem28);
            ItemManager.Instance.AddItem(customItem29);
            ItemManager.Instance.AddItem(customItem30);
            ItemManager.Instance.AddItem(customItem31);
            ItemManager.Instance.AddItem(customItem32);
            ItemManager.Instance.AddItem(customItem33);
            ItemManager.Instance.AddItem(customItem34);
            ItemManager.Instance.AddItem(customItem35);
            ItemManager.Instance.AddItem(customItem36);
            ItemManager.Instance.AddItem(customItem37);
            ItemManager.Instance.AddItem(customItem38);
            ItemManager.Instance.AddItem(customItem39);
            ItemManager.Instance.AddItem(customItem40);
            ItemManager.Instance.AddItem(customItem41);
            ItemManager.Instance.AddItem(customItem42);
            ItemManager.Instance.AddItem(customItem43);
            ItemManager.Instance.AddItem(customItem44);
            ItemManager.Instance.AddItem(customItem45);
            ItemManager.Instance.AddItem(customItem46);
            ItemManager.Instance.AddItem(customItem47);
            ItemManager.Instance.AddItem(customItem48);
            ItemManager.Instance.AddItem(customItem49);
            ItemManager.Instance.AddItem(customItem50);
            ItemManager.Instance.AddItem(customItem51);
            ItemManager.Instance.AddItem(customItem52);
            ItemManager.Instance.AddItem(customItem53);
            
            customItem53.ItemDrop.m_itemData.m_shared.m_itemType = (ItemDrop.ItemData.ItemType)4;
            ItemManager.Instance.AddItem(customItem54);
            
            customItem54.ItemDrop.m_itemData.m_shared.m_itemType = (ItemDrop.ItemData.ItemType)4;
            ItemManager.Instance.AddItem(customItem55);
            
            customItem55.ItemDrop.m_itemData.m_shared.m_itemType = (ItemDrop.ItemData.ItemType)4;
            ItemManager.Instance.AddItem(customItem56);
            
            customItem56.ItemDrop.m_itemData.m_shared.m_itemType = (ItemDrop.ItemData.ItemType)4;
            ItemManager.Instance.AddItem(customItem57);
            
            customItem57.ItemDrop.m_itemData.m_shared.m_itemType = (ItemDrop.ItemData.ItemType)4;
            ItemManager.Instance.AddItem(customItem58);
            
            customItem58.ItemDrop.m_itemData.m_shared.m_itemType = (ItemDrop.ItemData.ItemType)4;
            ItemManager.Instance.AddItem(customItem59);
            
            customItem59.ItemDrop.m_itemData.m_shared.m_itemType = (ItemDrop.ItemData.ItemType)4;
            ItemManager.Instance.AddItem(customItem60);
            
            customItem60.ItemDrop.m_itemData.m_shared.m_itemType = (ItemDrop.ItemData.ItemType)4;
            ItemManager.Instance.AddItem(customItem61);
            
            customItem61.ItemDrop.m_itemData.m_shared.m_itemType = (ItemDrop.ItemData.ItemType)4;
            ItemManager.Instance.AddItem(customItem62);
            
            customItem62.ItemDrop.m_itemData.m_shared.m_itemType = (ItemDrop.ItemData.ItemType)4;
            
            PrefabManager.OnVanillaPrefabsAvailable -= WarfareItemsPrefab;
        }
    }
}