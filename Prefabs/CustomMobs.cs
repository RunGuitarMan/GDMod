using Jotunn.Configs;
using Jotunn.Entities;
using Jotunn.Managers;

namespace GDMod.Prefabs
{
    public static class CustomMobs
    {
        public static void CustomMobsPrefab()
        {
            var creatureConfig1 = new CreatureConfig();
            creatureConfig1.AddDropConfig(new DropConfig
            {
                Item = "Coins",
                Chance = 0f
            });
            
            var creatureConfig2 = new CreatureConfig();
            creatureConfig2.AddDropConfig(new DropConfig
            {
                Item = "Coins",
                Chance = 0f
            });
            
            var creatureConfig3 = new CreatureConfig();
            creatureConfig3.AddDropConfig(new DropConfig
            {
                Item = "Coins",
                Chance = 0f
            });
            
            var creatureConfig4 = new CreatureConfig();
            creatureConfig4.AddDropConfig(new DropConfig
            {
                Item = "Coins",
                Chance = 0f
            });
            
            var customCreature = new CustomCreature("DraugrNone", "Draugr_Ranged", creatureConfig1);
            var customCreature2 = new CustomCreature("SkeletonNone", "Skeleton", creatureConfig2);
            var customCreature3 = new CustomCreature("SurtlingNone", "Surtling", creatureConfig3);
            var customCreature4 = new CustomCreature("HatchlingNone", "Hatchling", creatureConfig4);
            
            CreatureManager.Instance.AddCreature(customCreature);
            CreatureManager.Instance.AddCreature(customCreature2);
            CreatureManager.Instance.AddCreature(customCreature3);
            CreatureManager.Instance.AddCreature(customCreature4);
            
            PrefabManager.OnVanillaPrefabsAvailable -= CustomMobsPrefab;
        }
    }
}