using Jotunn.Configs;
using Jotunn.Entities;
using Jotunn.Managers;
using Jotunn.Utils;
using UnityEngine;

namespace GDMod.Prefabs
{
    public static class Economy
    {
        
        public static void EconomyPrefab()
        {
            var gameObject1 = PrefabManager.Instance.CreateClonedPrefab("GDCoin", "Ruby");
            gameObject1.GetComponent<Renderer>().material.color = new Color(238, 130, 238);
            
            var customItem = new CustomItem(gameObject1, false, new ItemConfig
            {
                Name = "Роскошь",
                Description = "Викингам известна роскошь. Любой торговец отдаст любые сбережения, чтобы заполучить её."
            });
            customItem.ItemDrop.m_itemData.m_shared.m_maxStackSize = 100000;
            customItem.ItemDrop.m_itemData.m_shared.m_weight = 0f;
            customItem.ItemDrop.m_itemData.m_shared.m_value = 10;
            customItem.ItemDrop.m_itemData.m_shared.m_icons[0] = AssetUtils.LoadSpriteFromFile("prem.png");
            ItemManager.Instance.AddItem(customItem);

            var gameObject2 = PrefabManager.Instance.CreateClonedPrefab("Wood2", "Wood");
            var customItem2 = new CustomItem(gameObject2, false, new ItemConfig
            {
                Name = "Береста",
                Description = "Кора дерева, что вы содрали"
            });
            customItem2.ItemDrop.m_itemData.m_shared.m_maxStackSize = 50;
            customItem2.ItemDrop.m_itemData.m_shared.m_weight = 1f;
            customItem2.ItemDrop.m_itemData.m_shared.m_icons[0] = AssetUtils.LoadSpriteFromFile("wood1.png");
            ItemManager.Instance.AddItem(customItem2);

            var recipeConfig = new RecipeConfig();
            recipeConfig.Item = "Wood2";
            recipeConfig.AddRequirement(new RequirementConfig("Wood", 2, 0, false));
            recipeConfig.CraftingStation = CraftingStations.Workbench;
            ItemManager.Instance.AddRecipe(new CustomRecipe(recipeConfig));

            var gameObject3 = PrefabManager.Instance.CreateClonedPrefab("Wood3", "Wood");
            var customItem3 = new CustomItem(gameObject3, false, new ItemConfig
            {
                Name = "Опилки",
                Description = "Мягая на ощупь стужка. Вы измельчили древесную кору."
            });
            customItem3.ItemDrop.m_itemData.m_shared.m_maxStackSize = 50;
            customItem3.ItemDrop.m_itemData.m_shared.m_weight = 1f;
            customItem3.ItemDrop.m_itemData.m_shared.m_icons[0] = AssetUtils.LoadSpriteFromFile("wood2.png");
            ItemManager.Instance.AddItem(customItem3);

            var recipeConfig2 = new RecipeConfig();
            recipeConfig2.Item = "Wood3";
            recipeConfig2.AddRequirement(new RequirementConfig("Wood2", 2, 0, false));
            recipeConfig2.CraftingStation = CraftingStations.Workbench;
            ItemManager.Instance.AddRecipe(new CustomRecipe(recipeConfig2));
            
            var gameObject4 = PrefabManager.Instance.CreateClonedPrefab("Wood4", "Wood");
            var customItem4 = new CustomItem(gameObject4, false, new ItemConfig
            {
                Name = "Грубый лист",
                Description = "Лист, что вы получили путем высушивания и сдавливания опилок"
            });
            customItem4.ItemDrop.m_itemData.m_shared.m_maxStackSize = 50;
            customItem4.ItemDrop.m_itemData.m_shared.m_weight = 1f;
            customItem4.ItemDrop.m_itemData.m_shared.m_icons[0] = AssetUtils.LoadSpriteFromFile("wood3.png");
            ItemManager.Instance.AddItem(customItem4);

            var recipeConfig3 = new RecipeConfig();
            recipeConfig3.Item = "Wood4";
            recipeConfig3.AddRequirement(new RequirementConfig("Wood3", 2, 0, false));
            recipeConfig3.CraftingStation = CraftingStations.Workbench;
            ItemManager.Instance.AddRecipe(new CustomRecipe(recipeConfig3));

            var gameObject5 = PrefabManager.Instance.CreateClonedPrefab("Wood5", "Wood");
            var customItem5 = new CustomItem(gameObject5, false, new ItemConfig
            {
                Name = "Свитки",
                Description = "Путем длительной древообработки вы получили прочный рулон гладкого материала. Думаю за него предложат хорошую цену"
            });
            customItem5.ItemDrop.m_itemData.m_shared.m_maxStackSize = 50;
            customItem5.ItemDrop.m_itemData.m_shared.m_weight = 1f;
            customItem5.ItemDrop.m_itemData.m_shared.m_icons[0] = AssetUtils.LoadSpriteFromFile("wood4.png");
            ItemManager.Instance.AddItem(customItem5);

            var recipeConfig4 = new RecipeConfig();
            recipeConfig4.Item = "Wood5";
            recipeConfig4.AddRequirement(new RequirementConfig("Wood4", 2, 0, false));
            recipeConfig4.CraftingStation = CraftingStations.Workbench;
            ItemManager.Instance.AddRecipe(new CustomRecipe(recipeConfig4));

            var gameObject6 = PrefabManager.Instance.CreateClonedPrefab("Stone2", "Stone");
            var customItem6 = new CustomItem(gameObject6, false, new ItemConfig
            {
                Name = "Разбитый камень",
                Description = "Лишь попытка найти что-то действительно ценное"
            });
            customItem6.ItemDrop.m_itemData.m_shared.m_maxStackSize = 50;
            customItem6.ItemDrop.m_itemData.m_shared.m_weight = 1f;
            customItem6.ItemDrop.m_itemData.m_shared.m_icons[0] = AssetUtils.LoadSpriteFromFile("stone1.png");
            ItemManager.Instance.AddItem(customItem6);

            var recipeConfig5 = new RecipeConfig();
            recipeConfig5.Item = "Stone2";
            recipeConfig5.AddRequirement(new RequirementConfig("Stone", 2, 0, false));
            recipeConfig5.CraftingStation = CraftingStations.Workbench;
            ItemManager.Instance.AddRecipe(new CustomRecipe(recipeConfig5));



            var gameObject7 = PrefabManager.Instance.CreateClonedPrefab("Stone3", "Stone");
            var customItem7 = new CustomItem(gameObject7, false, new ItemConfig
            {
                Name = "Гранированный камень",
                Description = "Камень очищенный от ненужных примесей"
            });
            customItem7.ItemDrop.m_itemData.m_shared.m_maxStackSize = 50;
            customItem7.ItemDrop.m_itemData.m_shared.m_weight = 1f;
            customItem7.ItemDrop.m_itemData.m_shared.m_icons[0] = AssetUtils.LoadSpriteFromFile("stone2.png");
            ItemManager.Instance.AddItem(customItem7);

            var recipeConfig6 = new RecipeConfig();
            recipeConfig6.Item = "Stone3";
            recipeConfig6.AddRequirement(new RequirementConfig("Stone2", 2, 0, false));
            recipeConfig6.CraftingStation = CraftingStations.Workbench;
            ItemManager.Instance.AddRecipe(new CustomRecipe(recipeConfig6));
            
            var gameObject8 = PrefabManager.Instance.CreateClonedPrefab("Stone4", "Stone");
            var customItem8 = new CustomItem(gameObject8, false, new ItemConfig
            {
                Name = "Безделушка",
                Description = "Этот кусок слегка поблескивает. Может придать ему форму?"
            });
            customItem8.ItemDrop.m_itemData.m_shared.m_maxStackSize = 50;
            customItem8.ItemDrop.m_itemData.m_shared.m_weight = 1f;
            customItem8.ItemDrop.m_itemData.m_shared.m_icons[0] = AssetUtils.LoadSpriteFromFile("stone3.png");
            ItemManager.Instance.AddItem(customItem8);

            var recipeConfig7 = new RecipeConfig();
            recipeConfig7.Item = "Stone4";
            recipeConfig7.AddRequirement(new RequirementConfig("Stone3", 2, 0, false));
            recipeConfig7.CraftingStation = CraftingStations.Workbench;
            ItemManager.Instance.AddRecipe(new CustomRecipe(recipeConfig7));
            
            var gameObject9 = PrefabManager.Instance.CreateClonedPrefab("Stone5", "Stone");
            var customItem9 = new CustomItem(gameObject9, false, new ItemConfig
            {
                Name = "Драгоценный камень",
                Description = "Отполированная и очищенная руда превратилась в нечто прекрасное"
            });
            customItem9.ItemDrop.m_itemData.m_shared.m_maxStackSize = 50;
            customItem9.ItemDrop.m_itemData.m_shared.m_weight = 1f;
            customItem9.ItemDrop.m_itemData.m_shared.m_icons[0] = AssetUtils.LoadSpriteFromFile("stone4.png");
            ItemManager.Instance.AddItem(customItem9);

            var recipeConfig8 = new RecipeConfig();
            recipeConfig8.Item = "Stone5";
            recipeConfig8.AddRequirement(new RequirementConfig("Stone4", 2, 0, false));
            recipeConfig8.CraftingStation = CraftingStations.Workbench;
            ItemManager.Instance.AddRecipe(new CustomRecipe(recipeConfig8));
            PrefabManager.OnVanillaPrefabsAvailable -= EconomyPrefab;
        }
    }
}