using Terraria.ModLoader;
using Terraria;
using Terraria.ID;
using Terraria.Localization;

namespace Asalinism.Content.Common.Recipes.Minerals.Upgrades.PreHardmode
{
    public class Bows : ModSystem
    {
        int[][] UpgradeMaterial = new int[][]
        {
        new int[] { ItemID.CopperBow, ItemID.TinBow, ItemID.CopperBar, ItemID.TinBar },
        new int[] { ItemID.IronBow, ItemID.LeadBow, ItemID.IronBar, ItemID.LeadBar },
        new int[] { ItemID.SilverBow, ItemID.TungstenBow, ItemID.SilverBar, ItemID.TungstenBar },
        new int[] { ItemID.GoldBow, ItemID.PlatinumBow, ItemID.GoldBar, ItemID.PlatinumBar },
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
        public override void AddRecipes()
        {
            for (int i = 1; i < 4; i++) {
                for (int j = 0; j < 2; j++) {
                    Recipe.Create(UpgradeMaterial[i][j])
                        .AddIngredient(UpgradeMaterial[i-1][j], 1)
                        .AddIngredient(UpgradeMaterial[i][j+2], 5)
                        .AddTile(TileID.Anvils)
                        .Register();
                    Recipe.Create(UpgradeMaterial[i][j])
                        .AddIngredient(UpgradeMaterial[i-1][DetermineSwap(j)], 1)
                        .AddIngredient(UpgradeMaterial[i][j+2], 5)
                        .AddTile(TileID.Anvils)
                        .Register();
                }
            }      
        }
    }
}