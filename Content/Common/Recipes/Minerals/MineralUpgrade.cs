using Terraria.ModLoader;
using Terraria;
using Terraria.ID;
using Terraria.Localization;

namespace Asalistry.Content.Common.Recipes.Minerals
{
    public class MineralUpgrade : ModSystem
    {
        int[][] SwapMinerals = new int[][]
        {
        new int[] { ItemID.CopperBar, ItemID.TinBar },
        new int[] { ItemID.IronBar, ItemID.LeadBar },
        new int[] { ItemID.SilverBar, ItemID.TungstenBar },
        new int[] { ItemID.GoldBar, ItemID.PlatinumBar },
        new int[] { ItemID.DemoniteBar, ItemID.CrimtaneBar },
        new int[] { ItemID.HellstoneBar , ItemID.HellstoneBar },
        new int[] { ItemID.CobaltBar, ItemID.PalladiumBar },
        new int[] { ItemID.MythrilBar, ItemID.OrichalcumBar },
        new int[] { ItemID.AdamantiteBar, ItemID.TitaniumBar },
        new int[] { ItemID.CopperOre, ItemID.TinOre },
        new int[] { ItemID.IronOre, ItemID.LeadOre },
        new int[] { ItemID.SilverOre, ItemID.TungstenOre },
        new int[] { ItemID.GoldOre, ItemID.PlatinumOre },
        new int[] { ItemID.DemoniteOre, ItemID.CrimtaneOre },
        new int[] { ItemID.CobaltOre, ItemID.PalladiumOre },
        new int[] { ItemID.MythrilOre, ItemID.OrichalcumOre },
        new int[] { ItemID.AdamantiteOre, ItemID.TitaniumOre }
        };
        static int DetermineSwap(int j) {
            int n = 2;
            if (j == 0) {
                n = 1;
            }
            else if (j == 1) {
                n = 0;
            }
            return n;
        }
        public override void AddRecipeGroups()
        {
            RecipeGroup RecipeTiles = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(TileID.Extractinator)}", TileID.Extractinator, TileID.Anvils);
            RecipeGroup.RegisterGroup(nameof(TileID.Extractinator), RecipeTiles);
        }
        public override void AddRecipes()
        {
            for (int i = 0; i < 17; i++) {
                for(int j = 0; j < 2; j++) {
                    Recipe.Create(SwapMinerals[i][j])   
                        .AddTile(TileID.Anvils)
                        .AddIngredient(SwapMinerals[i][DetermineSwap(j)], 1)
                        .Register();
                }
            }
        }
    }
}