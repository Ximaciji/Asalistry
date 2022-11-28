using Terraria.ModLoader;
using Terraria;
using Terraria.ID;
using Terraria.Localization;

namespace Asalinism.Content.Scripts.CustomRecipes // Optimizing
{
    public class WingsUpgrade : ModSystem
    {
        int[][] Wings = new int[][] {
        new int[] { ItemID.CreativeWings },
        new int[] {ItemID.AngelWings, ItemID.DemonWings},
        new int[] {ItemID.FairyWings, ItemID.BeeWings, ItemID.ButterflyWings},
        new int[] {ItemID.HarpyWings, ItemID.BatWings, ItemID.BoneWings},
        new int[] {ItemID.FrozenWings, ItemID.FlameWings},
        new int[] {ItemID.GhostWings, ItemID.BeetleWings},
        new int[] {ItemID.SpookyWings, ItemID.TatteredFairyWings},
        new int[] {ItemID.BetsyWings, ItemID.RainbowWings, ItemID.FishronWings, ItemID.FestiveWings, ItemID.MothronWings},
        new int[] {ItemID.WingsSolar, ItemID.WingsNebula, ItemID.WingsStardust, ItemID.WingsVortex},
        new int[] {ItemID.RedsWings, ItemID.DTownsWings, ItemID.WillsWings, ItemID.CrownosWings, ItemID.CenxsWings, ItemID.BejeweledValkyrieWing, ItemID.Yoraiz0rWings, ItemID.JimsWings, ItemID.SkiphsWings, ItemID.LokisWings, ItemID.ArkhalisWings, ItemID.LeinforsWings, ItemID.GhostarsWings, ItemID.SafemanWings, ItemID.FoodBarbarianWings, ItemID.GroxTheGreatWings},

        };

        int[][] WingsIngredients = new int[][] {
            new int[] {ItemID.SoulofLight, ItemID.SoulofNight, 10, 10},
            new int[] {ItemID.PixieDust, ItemID.TatteredBeeWing, ItemID.ButterflyDust, 50, 1, 1},
            new int[] {ItemID.GiantHarpyFeather, ItemID.BrokenBatWing, ItemID.BoneFeather, 1, 1, 1},
            new int[] {ItemID.IceFeather, ItemID.FireFeather, 1, 1},
            new int[] {ItemID.SpectreBar, ItemID.BeetleHusk, 8, 8},
            new int[] {ItemID.SpookyTwig, ItemID.BlackFairyDust, 1, 1},
            new int[] {ItemID.FragmentSolar, ItemID.FragmentNebula, ItemID.FragmentStardust, ItemID.FragmentVortex, 10, 10, 10, 10}
        };

        string[] WingsRecipeCalls = { "ItemID.CreativeWings", "ItemID.AngelWings", "ItemID.FairyWings", "ItemID.HarpyWings", "ItemID.FrozenWings", "ItemID.GhostWings", "ItemID.SpookyWings", "ItemID.BetsyWings", "ItemID.WingsSolar", "ItemID.RedsWings"};
        

        public override void AddRecipeGroups()
        {
            for (int i = 0; i < Wings.GetLength(0); i++) {
                RecipeGroup WingsRecipes = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(Wings[i][0])}", Wings[i]);
                RecipeGroup.RegisterGroup(WingsRecipeCalls[i], WingsRecipes);
            }
        }
        static void UpgradableWings(int[][] wings, int newWings, int wingSetLength, string[] WingsRecipeCalls, int oldWings, int ingredient, int amount) {
            Recipe.Create(wings[newWings][wingSetLength-1])
                .AddRecipeGroup(WingsRecipeCalls[oldWings])
                .AddIngredient(ingredient, amount)
                .AddTile(TileID.Anvils)
                .Register();
        }
        public override void AddRecipes()
        {
            Recipe.Create(ItemID.CreativeWings)
                .AddIngredient(ItemID.Bird, 10)
                .AddIngredient(ItemID.CopperBar, 10)
                .AddTile(TileID.Anvils)
                .Register();
            for (int j = 0; j < Wings.GetLength(0); j++) {
                for (int i = 0; i < Wings[j].GetLength(0); i++) {
                    Recipe.Create(Wings[j][i])
                            .AddRecipeGroup(WingsRecipeCalls[j])
                            .AddTile(TileID.Anvils)
                            .Register();
                }
            }
            
            int wingSet = 1;
            while (wingSet < 7) {
                for (int i = 0; i < Wings[wingSet].GetLength(0); i++) {
                    Recipe.Create(Wings[wingSet][i])
                    .AddRecipeGroup(WingsRecipeCalls[wingSet-1])
                    .AddIngredient(WingsIngredients[wingSet-1][i], WingsIngredients[wingSet-1][i+(WingsIngredients[wingSet-1].GetLength(0)/2)])
                    .AddTile(TileID.Anvils)
                    .Register();
                }
                wingSet++;
            }
            for (int i = 0; i < 4; i++) {
                Recipe.Create(Wings[8][i])
                    .AddRecipeGroup(WingsRecipeCalls[7])
                    .AddIngredient(WingsIngredients[6][i], WingsIngredients[6][i+(WingsIngredients[6].GetLength(0)/2)])
                    .AddTile(TileID.LunarCraftingStation)
                    .Register();
            }   
        }
    }
}