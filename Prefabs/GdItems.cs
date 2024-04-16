using Jotunn.Configs;
using Jotunn.Entities;
using Jotunn.Managers;
using Jotunn.Utils;
using UnityEngine;

namespace GDMod.Prefabs
{
    public static class GdItems
    {
        private static readonly AssetBundle Items = AssetUtils.LoadAssetBundleFromResources("questitems");

        public static void GdItemsPrefab()
        {
            var gameObject1 = (GameObject)Items.LoadAsset("questitem_whetstone");
            var gameObject2 = (GameObject)Items.LoadAsset("questitem_wind_essence");
            var gameObject3 = (GameObject)Items.LoadAsset("questitem_wraiths_breath");
            var gameObject4 = (GameObject)Items.LoadAsset("questitem_dragoneyes");
            var gameObject5 = (GameObject)Items.LoadAsset("questitem_scroll_red");
            var gameObject6 = (GameObject)Items.LoadAsset("questitem_scroll_green");
            var gameObject7 = (GameObject)Items.LoadAsset("questitem_scroll_yellow");
            var gameObject8 = (GameObject)Items.LoadAsset("questitem_scroll_purple");
            var gameObject9 = (GameObject)Items.LoadAsset("questitem_scroll_blue");
            var gameObject10 = (GameObject)Items.LoadAsset("questitem_scroll_black");
            var gameObject11 = (GameObject)Items.LoadAsset("questitem_necklace_green");
            var gameObject12 = (GameObject)Items.LoadAsset("questitem_necklace_red");
            var gameObject13 = (GameObject)Items.LoadAsset("questitem_pot_01");
            var gameObject14 = (GameObject)Items.LoadAsset("questitem_iceball");
            var gameObject15 = (GameObject)Items.LoadAsset("questitem_goblet");
            var gameObject16 = (GameObject)Items.LoadAsset("questitem_coinpurse");
            var gameObject17 = (GameObject)Items.LoadAsset("questitem_ghostlyheart");
            var gameObject18 = (GameObject)Items.LoadAsset("questitem_dragonheart");
            var gameObject19 = (GameObject)Items.LoadAsset("questitem_griffinfeather");
            var gameObject20 = (GameObject)Items.LoadAsset("questitem_book_01");
            var gameObject21 = (GameObject)Items.LoadAsset("questitem_book_02");
            var gameObject22 = (GameObject)Items.LoadAsset("questitem_book_03");
            var gameObject23 = (GameObject)Items.LoadAsset("questitem_book_04");
            var gameObject24 = (GameObject)Items.LoadAsset("questitem_straw_doll");
            
            var customItem = new CustomItem(gameObject1, false, new ItemConfig
            {
                Name = "Оселок",
                Description = "Шероховатый камень, используемый для заточки лезвий"
            });
            customItem.ItemDrop.m_itemData.m_shared.m_teleportable = false;
            customItem.ItemDrop.m_itemData.m_shared.m_maxStackSize = 1;
            customItem.ItemDrop.m_itemData.m_shared.m_weight = 25f;
            
            var customItem2 = new CustomItem(gameObject2, false, new ItemConfig
            {
                Name = "Эссенция ветра",
                Description = "Странно сплоченный и твердый шар ветра, случайные порывы которого обдают вашу руку"
            });
            customItem2.ItemDrop.m_itemData.m_shared.m_teleportable = false;
            customItem2.ItemDrop.m_itemData.m_shared.m_maxStackSize = 1;
            customItem2.ItemDrop.m_itemData.m_shared.m_weight = 25f;
            CustomItem customItem3 = new CustomItem(gameObject3, false, new ItemConfig
            {
                Name = "Дыхание призрака",
                Description = "Разлитое дыхание призрака по бутылкам. Пахнет ужасно"
            });
            customItem3.ItemDrop.m_itemData.m_shared.m_teleportable = false;
            customItem3.ItemDrop.m_itemData.m_shared.m_maxStackSize = 1;
            customItem3.ItemDrop.m_itemData.m_shared.m_weight = 25f;
            CustomItem customItem4 = new CustomItem(gameObject4, false, new ItemConfig
            {
                Name = "Глаз дракона",
                Description = "Глаз дракона, вы все еще можете почувствовать его зловещий блеск"
            });
            customItem4.ItemDrop.m_itemData.m_shared.m_teleportable = false;
            customItem4.ItemDrop.m_itemData.m_shared.m_maxStackSize = 1;
            customItem4.ItemDrop.m_itemData.m_shared.m_weight = 25f;
            CustomItem customItem5 = new CustomItem(gameObject5, false, new ItemConfig
            {
                Name = "Свиток в красном переплете",
                Description = "Свиток папируса, вылинявший и хрупкий"
            });
            CustomItem customItem6 = new CustomItem(gameObject6, false, new ItemConfig
            {
                Name = "Свиток особой трансмогрификации",
                Description = "Свиток для трансмогрификации вашей экипировки"
            });
            customItem6.ItemDrop.m_itemData.m_shared.m_icons[0] = AssetUtils.LoadSpriteFromFile("sq1.png");
            CustomItem customItem7 = new CustomItem(gameObject7, false, new ItemConfig
            {
                Name = "Свиток в желтом переплете",
                Description = "Свиток папируса, вылинявший и хрупкий"
            });
            CustomItem customItem8 = new CustomItem(gameObject8, false, new ItemConfig
            {
                Name = "Свиток трансмогрификации",
                Description = "Свиток для трансмогрификации вашей экипировки"
            });
            customItem8.ItemDrop.m_itemData.m_shared.m_icons[0] = AssetUtils.LoadSpriteFromFile("sq2.png");
            CustomItem customItem9 = new CustomItem(gameObject9, false, new ItemConfig
            {
                Name = "Свиток в синем переплете",
                Description = "Свиток папируса, вылинявший и хрупкий"
            });
            CustomItem customItem10 = new CustomItem(gameObject10, false, new ItemConfig
            {
                Name = "Свиток знаний",
                Description = "Свиток папируса, наполненный знаниями"
            });
            customItem10.ItemDrop.m_itemData.m_shared.m_icons[0] = AssetUtils.LoadSpriteFromFile("sq3.png");
            CustomItem customItem11 = new CustomItem(gameObject11, false, new ItemConfig
            {
                Name = "Зеленое ожерелье с подвеской",
                Description = "Изысканный кулон, свисающий с золотой и серебряной цепочки"
            });
            customItem11.ItemDrop.m_itemData.m_shared.m_teleportable = false;
            customItem11.ItemDrop.m_itemData.m_shared.m_maxStackSize = 1;
            customItem11.ItemDrop.m_itemData.m_shared.m_weight = 25f;
            CustomItem customItem12 = new CustomItem(gameObject12, false, new ItemConfig
            {
                Name = "Красное ожерелье с подвеской",
                Description = "Простой красный кристалл, свисающий с золотой цепочки"
            });
            customItem12.ItemDrop.m_itemData.m_shared.m_teleportable = false;
            customItem12.ItemDrop.m_itemData.m_shared.m_maxStackSize = 1;
            customItem12.ItemDrop.m_itemData.m_shared.m_weight = 25f;
            CustomItem customItem13 = new CustomItem(gameObject13, false, new ItemConfig
            {
                Name = "Потускневший горшок",
                Description = "Потускневший железный горшок"
            });
            customItem13.ItemDrop.m_itemData.m_shared.m_teleportable = false;
            customItem13.ItemDrop.m_itemData.m_shared.m_maxStackSize = 1;
            customItem13.ItemDrop.m_itemData.m_shared.m_weight = 25f;
            CustomItem customItem14 = new CustomItem(gameObject14, false, new ItemConfig
            {
                Name = "Ледяной шар",
                Description = "Относительно совершенная ледяная сфера"
            });
            customItem14.ItemDrop.m_itemData.m_shared.m_teleportable = false;
            customItem14.ItemDrop.m_itemData.m_shared.m_maxStackSize = 1;
            customItem14.ItemDrop.m_itemData.m_shared.m_weight = 25f;
            CustomItem customItem15 = new CustomItem(gameObject15, false, new ItemConfig
            {
                Name = "Медный кубок",
                Description = "Украшенный медный кубок"
            });
            customItem15.ItemDrop.m_itemData.m_shared.m_teleportable = false;
            customItem15.ItemDrop.m_itemData.m_shared.m_maxStackSize = 1;
            customItem15.ItemDrop.m_itemData.m_shared.m_weight = 25f;
            CustomItem customItem16 = new CustomItem(gameObject16, false, new ItemConfig
            {
                Name = "Кожаный кошелек для монет",
                Description = "Простой кожаный кошелек для монет, застегивающийся на кожаные завязки"
            });
            customItem16.ItemDrop.m_itemData.m_shared.m_teleportable = false;
            customItem16.ItemDrop.m_itemData.m_shared.m_maxStackSize = 1;
            customItem16.ItemDrop.m_itemData.m_shared.m_weight = 25f;
            CustomItem customItem17 = new CustomItem(gameObject17, false, new ItemConfig
            {
                Name = "Призрачное сердце",
                Description = "Холодное пурпурное пламя, которое, кажется, излучает злобу и ненависть"
            });
            customItem17.ItemDrop.m_itemData.m_shared.m_teleportable = false;
            customItem17.ItemDrop.m_itemData.m_shared.m_maxStackSize = 1;
            customItem17.ItemDrop.m_itemData.m_shared.m_weight = 25f;
            CustomItem customItem18 = new CustomItem(gameObject18, false, new ItemConfig
            {
                Name = "Драконье сердце",
                Description = "Единственное бьющееся сердце дракона, теперь холодный и безжизненный кусок мяса синего цвета"
            });
            customItem18.ItemDrop.m_itemData.m_shared.m_teleportable = true;
            customItem18.ItemDrop.m_itemData.m_shared.m_maxStackSize = 10000;
            customItem18.ItemDrop.m_itemData.m_shared.m_weight = 0f;
            CustomItem customItem19 = new CustomItem(gameObject19, false, new ItemConfig
            {
                Name = "Перо грифона",
                Description = "Шелковистое перо из гривы грифона"
            });
            customItem19.ItemDrop.m_itemData.m_shared.m_teleportable = false;
            customItem19.ItemDrop.m_itemData.m_shared.m_maxStackSize = 1;
            customItem19.ItemDrop.m_itemData.m_shared.m_weight = 25f;
            CustomItem customItem20 = new CustomItem(gameObject20, false, new ItemConfig
            {
                Name = "Потрепанная книга",
                Description = "Эта книга знавала лучшие времена, ее корешок потрескался, а страницы пожелтели"
            });
            customItem20.ItemDrop.m_itemData.m_shared.m_teleportable = false;
            customItem20.ItemDrop.m_itemData.m_shared.m_maxStackSize = 1;
            customItem20.ItemDrop.m_itemData.m_shared.m_weight = 25f;
            CustomItem customItem21 = new CustomItem(gameObject21, false, new ItemConfig
            {
                Name = "Старая книга",
                Description = "Эта книга старая и потрепанная, она слишком долго пролежала среди стихий. Содержит знания тактик ведения боя"
            });
            customItem21.ItemDrop.m_itemData.m_shared.m_teleportable = false;
            customItem21.ItemDrop.m_itemData.m_shared.m_maxStackSize = 1;
            customItem21.ItemDrop.m_itemData.m_shared.m_weight = 1f;
            CustomItem customItem22 = new CustomItem(gameObject22, false, new ItemConfig
            {
                Name = "Книга древней магии",
                Description = "Эта книга древняя по любым меркам, обложка потрескалась и сделана из какой-то кожи животного происхождения, а страницы стали хрупкими от старости."
            });
            customItem22.ItemDrop.m_itemData.m_shared.m_teleportable = false;
            customItem22.ItemDrop.m_itemData.m_shared.m_maxStackSize = 1;
            customItem22.ItemDrop.m_itemData.m_shared.m_weight = 1f;
            CustomItem customItem23 = new CustomItem(gameObject23, false, new ItemConfig
            {
                Name = "Потрепанная книга тайн",
                Description = "Эта книга выглядит так, словно кто-то выбросил ее на улицу и оставил там.  Обложка в пятнах и порвана, да и страницы выглядят не лучше."
            });
            customItem23.ItemDrop.m_itemData.m_shared.m_teleportable = false;
            customItem23.ItemDrop.m_itemData.m_shared.m_maxStackSize = 1;
            customItem23.ItemDrop.m_itemData.m_shared.m_weight = 1f;
            CustomItem customItem24 = new CustomItem(gameObject24, false, new ItemConfig
            {
                Name = "Соломенная кукла",
                Description = "Простая кукла, сделанная из соломы и бечевки."
            });
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
            
            PrefabManager.OnVanillaPrefabsAvailable -= GdItemsPrefab;
        }
    }
}