using Terraria.ModLoader;
using Terraria;
using Terraria.ID;
using Terraria.Localization;

namespace Asalinism.Content.Scripts.CustomRecipes
{
    public class WoodArmor : ModSystem
    {
        int[][] WoodenArmor = new int[][] {
            new int[] {ItemID.WoodHelmet, ItemID.RichMahoganyHelmet, ItemID.EbonwoodHelmet, ItemID.ShadewoodHelmet, ItemID.PearlwoodHelmet, ItemID.BorealWoodHelmet, ItemID.PalmWoodHelmet},
            new int[] {ItemID.WoodBreastplate, ItemID.RichMahoganyBreastplate, ItemID.EbonwoodBreastplate, ItemID.ShadewoodBreastplate, ItemID.PearlwoodBreastplate, ItemID.BorealWoodBreastplate, ItemID.PalmWoodBreastplate},
            new int[] {ItemID.WoodGreaves, ItemID.RichMahoganyGreaves, ItemID.EbonwoodGreaves, ItemID.ShadewoodGreaves, ItemID.PearlwoodGreaves, ItemID.BorealWoodGreaves, ItemID.PalmWoodGreaves}
        };
        int[] WoodenIngredient = new int[] {ItemID.Wood, ItemID.RichMahogany, ItemID.Ebonwood, ItemID.Shadewood, ItemID.Pearlwood, ItemID.BorealWood, ItemID.PalmWood};
        string [] WoodenRecipeCalls = {"ItemID.WoodHelmet", "ItemID.WoodenBreastplate", "ItemID.WoodenGreaves"};
        public override void AddRecipeGroups()
        {
            for (int i = 0; i < WoodenArmor.GetLength(0); i++) {
                RecipeGroup WoodenRecipes = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(WoodenArmor[i][0])}", WoodenArmor[i]);
                RecipeGroup.RegisterGroup(WoodenRecipeCalls[i], WoodenRecipes);
            }
        }
        public override void AddRecipes()
        {
            
            for (int j = 0; j < WoodenArmor.GetLength(0); j++) {
                for (int i = 0; i < WoodenArmor[j].GetLength(0); i++) {
                    Recipe.Create(WoodenArmor[j][i])
                    .AddRecipeGroup(WoodenRecipeCalls[j])
                    .AddIngredient(WoodenIngredient[i], 10)
                    .AddTile(TileID.WorkBenches)
                    .Register();
                }
            }
        }
    }
}