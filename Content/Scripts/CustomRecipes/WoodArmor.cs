using Terraria.ModLoader;
using Terraria;
using Terraria.ID;
using Terraria.Localization;

namespace Asalinism.Content.Scripts.CustomRecipes
{
    public class WoodArmor : ModSystem
    {
        int[] woodenHelmets = {ItemID.WoodHelmet, ItemID.RichMahoganyHelmet, ItemID.EbonwoodHelmet, ItemID.ShadewoodHelmet, ItemID.PearlwoodHelmet, ItemID.BorealWoodHelmet, ItemID.PalmWoodHelmet};
        int[] woodenBreastplates = {ItemID.WoodBreastplate, ItemID.RichMahoganyBreastplate, ItemID.EbonwoodBreastplate, ItemID.ShadewoodBreastplate, ItemID.PearlwoodBreastplate, ItemID.BorealWoodBreastplate, ItemID.PalmWoodBreastplate};
        int[] woodenGreaves = {ItemID.WoodGreaves, ItemID.RichMahoganyGreaves, ItemID.EbonwoodGreaves, ItemID.ShadewoodGreaves, ItemID.PearlwoodGreaves, ItemID.BorealWoodGreaves, ItemID.PalmWoodGreaves};
        int[] woodenMaterial = {ItemID.Wood, ItemID.RichMahogany, ItemID.Ebonwood, ItemID.Shadewood, ItemID.Pearlwood, ItemID.BorealWood, ItemID.PalmWood};
        public override void AddRecipeGroups()
        {
            RecipeGroup WoodHelmets = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.WoodHelmet)}", ItemID.WoodHelmet, ItemID.RichMahoganyHelmet, ItemID.EbonwoodHelmet, ItemID.ShadewoodHelmet, ItemID.PearlwoodHelmet, ItemID.BorealWoodHelmet, ItemID.PalmWoodHelmet);
            RecipeGroup.RegisterGroup(nameof(ItemID.WoodHelmet), WoodHelmets);

            RecipeGroup WoodBreastplates = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.WoodBreastplate)}", ItemID.WoodBreastplate, ItemID.RichMahoganyBreastplate, ItemID.EbonwoodBreastplate, ItemID.ShadewoodBreastplate, ItemID.PearlwoodBreastplate, ItemID.BorealWoodBreastplate, ItemID.PalmWoodBreastplate);
            RecipeGroup.RegisterGroup(nameof(ItemID.WoodBreastplate), WoodBreastplates);

            RecipeGroup WoodGreaves = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.WoodGreaves)}", ItemID.WoodGreaves, ItemID.RichMahoganyGreaves, ItemID.EbonwoodGreaves, ItemID.ShadewoodGreaves, ItemID.PearlwoodGreaves, ItemID.BorealWoodGreaves, ItemID.PalmWoodGreaves);
            RecipeGroup.RegisterGroup(nameof(ItemID.WoodGreaves), WoodGreaves);
        }
        static void CraftWoodArmor(int helm, int breast, int Greaves, int wood) {
            Recipe.Create(helm)
                .AddIngredient(wood, 3)
                .AddRecipeGroup(nameof(ItemID.WoodHelmet))
                .AddTile(TileID.WorkBenches)
                .Register();
            Recipe.Create(breast)
                .AddIngredient(wood, 3)
                .AddRecipeGroup(nameof(ItemID.WoodBreastplate))
                .AddTile(TileID.WorkBenches)
                .Register();
            Recipe.Create(Greaves)
                .AddIngredient(wood, 3)
                .AddRecipeGroup(nameof(ItemID.WoodGreaves))
                .AddTile(TileID.WorkBenches)
                .Register();
        }
        public override void AddRecipes()
        {
            for (int i = 0; i < 7; i++) {
                CraftWoodArmor(woodenHelmets[i], woodenBreastplates[i], woodenGreaves[i], woodenMaterial[i]);
            }
        }
    }
}