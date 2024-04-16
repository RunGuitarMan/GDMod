using Jotunn.Entities;
using Jotunn.Managers;
using Jotunn.Utils;

namespace GDMod.Prefabs
{
    public static class CustomItems
    {
        public static void CustomItemsPrefab()
        {
            var gameObject1 = PrefabManager.Instance.CreateClonedPrefab("SwampCargo2", "TrophyDraugr");
            var gameObject2 = PrefabManager.Instance.CreateClonedPrefab("MountainCargo2", "TrophyWolf");
            var gameObject3 = PrefabManager.Instance.CreateClonedPrefab("PlainsCargo2", "TrophyGoblinBrute");
            var gameObject4 = PrefabManager.Instance.CreateClonedPrefab("MistyCargo2", "TrophySeeker");
            var gameObject5 = PrefabManager.Instance.CreateClonedPrefab("MeadowCargo", "RawMeat");
            var gameObject6 = PrefabManager.Instance.CreateClonedPrefab("ForestCargo", "Bronze");
            var gameObject7 = PrefabManager.Instance.CreateClonedPrefab("SwampCargo", "Iron");
            var gameObject8 = PrefabManager.Instance.CreateClonedPrefab("MountainCargo", "Silver");
            var gameObject9 = PrefabManager.Instance.CreateClonedPrefab("PlainsCargo", "BlackMetal");
            var gameObject10 = PrefabManager.Instance.CreateClonedPrefab("MistyCargo", "Eitr");
            var gameObject11 = PrefabManager.Instance.CreateClonedPrefab("QuestBox", "chest_hildir1");
            var gameObject12 = PrefabManager.Instance.CreateClonedPrefab("FishCargo", "FishRaw");
            var gameObject13 = PrefabManager.Instance.CreateClonedPrefab("WoodCargo", "FineWood");
            var gameObject14 = PrefabManager.Instance.CreateClonedPrefab("FoodCargo", "BarleyFlour");
            var gameObject15 = PrefabManager.Instance.CreateClonedPrefab("PeltCargo", "DeerHide");
            var gameObject16 = PrefabManager.Instance.CreateClonedPrefab("PickaxeTerra", "PickaxeAntler");

            var prefab = PrefabManager.Instance.GetPrefab("Coins");
            
            var customItem = new CustomItem(gameObject5, false);
            customItem.ItemDrop.m_itemData.m_shared.m_teleportable = false;
            customItem.ItemDrop.m_itemData.m_shared.m_name = "Товары из Хьяртейка";
            customItem.ItemDrop.m_itemData.m_shared.m_description = "Товары из города Хьяртейк - места, с богатыми охотничьями угодьями";
            customItem.ItemDrop.m_itemData.m_shared.m_maxStackSize = 1;
            customItem.ItemDrop.m_itemData.m_shared.m_weight = 25f;
            
            var customItem2 = new CustomItem(gameObject6, false);
            customItem2.ItemDrop.m_itemData.m_shared.m_teleportable = false;
            customItem2.ItemDrop.m_itemData.m_shared.m_name = "Товары из Блеквуда";
            customItem2.ItemDrop.m_itemData.m_shared.m_description = "Товары из города Блэквуд - источника бронзы";
            customItem2.ItemDrop.m_itemData.m_shared.m_maxStackSize = 1;
            customItem2.ItemDrop.m_itemData.m_shared.m_weight = 25f;
            
            var customItem3 = new CustomItem(gameObject7, false);
            customItem3.ItemDrop.m_itemData.m_shared.m_teleportable = false;
            customItem3.ItemDrop.m_itemData.m_shared.m_name = "Товары из Ильдби";
            customItem3.ItemDrop.m_itemData.m_shared.m_description = "Товары из города Ильдби - железо добытое в склепах трудом и потом";
            customItem3.ItemDrop.m_itemData.m_shared.m_maxStackSize = 1;
            customItem3.ItemDrop.m_itemData.m_shared.m_weight = 25f;
            
            var customItem4 = new CustomItem(gameObject8, false);
            customItem4.ItemDrop.m_itemData.m_shared.m_teleportable = false;
            customItem4.ItemDrop.m_itemData.m_shared.m_name = "Товары из Скраннингена";
            customItem4.ItemDrop.m_itemData.m_shared.m_description = "Товары из города Скранинген - белое золото, что легко поддается обработке";
            customItem4.ItemDrop.m_itemData.m_shared.m_maxStackSize = 1;
            customItem4.ItemDrop.m_itemData.m_shared.m_weight = 25f;
            
            var customItem5 = new CustomItem(gameObject9, false);
            customItem5.ItemDrop.m_itemData.m_shared.m_teleportable = false;
            customItem5.ItemDrop.m_itemData.m_shared.m_name = "Товары из Йоргенхельда";
            customItem5.ItemDrop.m_itemData.m_shared.m_description = "Товары из города Йоргенхельд - метал, что чернее ночи. ";
            customItem5.ItemDrop.m_itemData.m_shared.m_maxStackSize = 1;
            customItem5.ItemDrop.m_itemData.m_shared.m_weight = 25f;
            
            var customItem6 = new CustomItem(gameObject10, false);
            customItem6.ItemDrop.m_itemData.m_shared.m_teleportable = false;
            customItem6.ItemDrop.m_itemData.m_shared.m_name = "Товары из Свартгула";
            customItem6.ItemDrop.m_itemData.m_shared.m_description = "Товары из города Свартгул - это вещество жизни, яд, который поглощает сам себя";
            customItem6.ItemDrop.m_itemData.m_shared.m_maxStackSize = 1;
            customItem6.ItemDrop.m_itemData.m_shared.m_weight = 25f;
            
            var customItem7 = new CustomItem(gameObject11, false);
            customItem7.ItemDrop.m_itemData.m_shared.m_teleportable = false;
            customItem7.ItemDrop.m_itemData.m_shared.m_name = "Тяжелый сундук";
            customItem7.ItemDrop.m_itemData.m_shared.m_description = "Содержимое этого ящика принадлежат купцу. Крайне тяжелый";
            customItem7.ItemDrop.m_itemData.m_shared.m_maxStackSize = 1;
            customItem7.ItemDrop.m_itemData.m_shared.m_weight = 25f;
            
            var customItem8 = new CustomItem(gameObject12, false);
            customItem8.ItemDrop.m_itemData.m_shared.m_teleportable = false;
            customItem8.ItemDrop.m_itemData.m_shared.m_name = "Груз свежей рыбы";
            customItem8.ItemDrop.m_itemData.m_shared.m_description = "Содержимое этого товара - свежепойманная, освежеванная рыба";
            customItem8.ItemDrop.m_itemData.m_shared.m_maxStackSize = 1;
            customItem8.ItemDrop.m_itemData.m_shared.m_weight = 25f;
            
            var customItem9 = new CustomItem(gameObject13, false);
            customItem9.ItemDrop.m_itemData.m_shared.m_teleportable = false;
            customItem9.ItemDrop.m_itemData.m_shared.m_name = "Груз многолетней древесины";
            customItem9.ItemDrop.m_itemData.m_shared.m_description = "Это дерево крайне прочное. Плотники дадут за него отличную цену!";
            customItem9.ItemDrop.m_itemData.m_shared.m_maxStackSize = 1;
            customItem9.ItemDrop.m_itemData.m_shared.m_weight = 25f;
            
            var customItem10 = new CustomItem(gameObject14, false);
            customItem10.ItemDrop.m_itemData.m_shared.m_teleportable = false;
            customItem10.ItemDrop.m_itemData.m_shared.m_name = "Мешок продуктов";
            customItem10.ItemDrop.m_itemData.m_shared.m_description = "В мешке местный урожай и продукты. Будьте осторожны - запах привлекает зверей!";
            customItem10.ItemDrop.m_itemData.m_shared.m_maxStackSize = 1;
            customItem10.ItemDrop.m_itemData.m_shared.m_weight = 25f;
            
            var customItem11 = new CustomItem(gameObject15, false);
            customItem11.ItemDrop.m_itemData.m_shared.m_teleportable = false;
            customItem11.ItemDrop.m_itemData.m_shared.m_name = "Тяжелый сундук";
            customItem11.ItemDrop.m_itemData.m_shared.m_description = "Шкуры редких горных оленей. Согреют даже в самый хлад!";
            customItem11.ItemDrop.m_itemData.m_shared.m_maxStackSize = 1;
            customItem11.ItemDrop.m_itemData.m_shared.m_weight = 25f;
            
            new CustomItem(prefab, false)
            {
                ItemDrop = { m_itemData = { m_shared = { m_weight = 0f, m_maxStackSize = 10000 } } }
            }.ItemDrop.m_itemData.m_shared.m_icons[0] = AssetUtils.LoadSpriteFromFile("Coins.png");
            
            var customItem12 = new CustomItem(gameObject16, false);
            customItem12.ItemDrop.m_itemData.m_shared.m_attackForce = 1f;
            customItem12.ItemDrop.m_itemData.m_shared.m_icons[0] = AssetUtils.LoadSpriteFromFile("pickaxe.png");
            
            var customItem13 = new CustomItem(gameObject1, false);
            customItem13.ItemDrop.m_itemData.m_shared.m_teleportable = false;
            customItem13.ItemDrop.m_itemData.m_shared.m_name = "Особый товар из Ильдби";
            customItem13.ItemDrop.m_itemData.m_shared.m_description = "Содержимое этого ящика - предметы, что можно найти только в болотах";
            customItem13.ItemDrop.m_itemData.m_shared.m_maxStackSize = 1;
            customItem13.ItemDrop.m_itemData.m_shared.m_weight = 25f;
            
            var customItem14 = new CustomItem(gameObject2, false);
            customItem14.ItemDrop.m_itemData.m_shared.m_teleportable = false;
            customItem14.ItemDrop.m_itemData.m_shared.m_name = "Особый товар из Скраннингена";
            customItem14.ItemDrop.m_itemData.m_shared.m_description = "Содержимое этого ящика - предметы, что можно найти только в горах";
            customItem14.ItemDrop.m_itemData.m_shared.m_maxStackSize = 1;
            customItem14.ItemDrop.m_itemData.m_shared.m_weight = 25f;
            
            var customItem15 = new CustomItem(gameObject3, false);
            customItem15.ItemDrop.m_itemData.m_shared.m_name = "Особый товар из Йоргенхельда";
            customItem15.ItemDrop.m_itemData.m_shared.m_description = "Содержимое этого ящика - предметы, что можно найти только на равнинах";
            customItem15.ItemDrop.m_itemData.m_shared.m_maxStackSize = 1;
            customItem15.ItemDrop.m_itemData.m_shared.m_weight = 25f;
            
            var customItem16 = new CustomItem(gameObject4, false);
            customItem16.ItemDrop.m_itemData.m_shared.m_teleportable = false;
            customItem16.ItemDrop.m_itemData.m_shared.m_name = "Особый товар из Свартгула";
            customItem16.ItemDrop.m_itemData.m_shared.m_description = "Содержимое этого ящика - предметы, что можно найти только в туманных землях";
            customItem16.ItemDrop.m_itemData.m_shared.m_maxStackSize = 1;
            customItem16.ItemDrop.m_itemData.m_shared.m_weight = 25f;
            
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
            
            PrefabManager.OnVanillaPrefabsAvailable -= CustomItemsPrefab;
        }
    }
}