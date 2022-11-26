using Terraria.ModLoader;
using Terraria;
using Terraria.ID;
using Terraria.Localization;

namespace Asalinism.Content.Scripts.CustomRecipes.LunarItems
{
    public class LunarExchange : ModSystem
    {
        int[] SetOneWeapons = {ItemID.SolarEruption, ItemID.VortexBeater, ItemID.NebulaArcanum, ItemID.StardustCellStaff};
        int[] SetTwoWeapons = {ItemID.DayBreak, ItemID.Phantasm, ItemID.NebulaBlaze, ItemID.StardustDragonStaff};
        int[] SetThreeWeapons = {ItemID.StarWrath, ItemID.Celeb2, ItemID.LunarFlareBook, ItemID.MoonlordTurretStaff};
        int[] SetFourWeapons = {ItemID.Meowmere, ItemID.SDMG, ItemID.LastPrism, ItemID.RainbowCrystalStaff};
        public override void AddRecipeGroups()
        {
            RecipeGroup Tier1LunarWeapons = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.SolarEruption)}", ItemID.SolarEruption, ItemID.VortexBeater, ItemID.NebulaArcanum, ItemID.StardustCellStaff);
            RecipeGroup.RegisterGroup(nameof(ItemID.SolarEruption), Tier1LunarWeapons);
            RecipeGroup Tier2LunarWeapons = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.DayBreak)}", ItemID.DayBreak, ItemID.Phantasm, ItemID.NebulaBlaze, ItemID.StardustDragonStaff);
            RecipeGroup.RegisterGroup(nameof(ItemID.DayBreak), Tier2LunarWeapons);
            RecipeGroup Tier3LunarWeapons = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.StarWrath)}", ItemID.StarWrath, ItemID.Celeb2, ItemID.LunarFlareBook, ItemID.MoonlordTurretStaff);
            RecipeGroup.RegisterGroup(nameof(ItemID.StarWrath), Tier3LunarWeapons);
            RecipeGroup Tier4LunarWeapons = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.Meowmere)}", ItemID.Meowmere, ItemID.SDMG, ItemID.LastPrism, ItemID.RainbowCrystalStaff);
            RecipeGroup.RegisterGroup(nameof(ItemID.Meowmere), Tier4LunarWeapons);
        }
        public override void AddRecipes()
        {
            // I can probably use a nested for loop for this, but I'm worried about the RecipeGroup Problem
            for (int i = 0; i < 4; i++) {
                Recipe.Create(SetOneWeapons[i])
                    .AddRecipeGroup(nameof(ItemID.SolarEruption))
                    .AddTile(TileID.LunarCraftingStation)
                    .Register();
            }
            for (int i = 0; i < 4; i++) {
                Recipe.Create(SetTwoWeapons[i])
                    .AddRecipeGroup(nameof(ItemID.DayBreak))
                    .AddTile(TileID.LunarCraftingStation)
                    .Register();
            }
            for (int i = 0; i < 4; i++) {
                Recipe.Create(SetThreeWeapons[i])
                    .AddRecipeGroup(nameof(ItemID.StarWrath))
                    .AddTile(TileID.LunarCraftingStation)
                    .Register();
            }
            for (int i = 0; i < 4; i++) {
                Recipe.Create(SetFourWeapons[i])
                    .AddRecipeGroup(nameof(ItemID.Meowmere))
                    .AddTile(TileID.LunarCraftingStation)
                    .Register();
            }
            for (int i = 0; i < 4; i++) {
                Recipe.Create(SetOneWeapons[i])
                    .AddIngredient(SetTwoWeapons[i])
                    .AddTile(TileID.LunarCraftingStation)
                    .Register();
            }
            for (int i = 0; i < 4; i++) {
                Recipe.Create(SetTwoWeapons[i])
                    .AddIngredient(SetOneWeapons[i])
                    .AddTile(TileID.LunarCraftingStation)
                    .Register();
            }
            for (int i = 0; i < 4; i++) {
                Recipe.Create(SetThreeWeapons[i])
                    .AddIngredient(SetFourWeapons[i])
                    .AddTile(TileID.LunarCraftingStation)
                    .Register();
            }
            for (int i = 0; i < 4; i++) {
                Recipe.Create(SetFourWeapons[i])
                    .AddIngredient(SetThreeWeapons[i])
                    .AddTile(TileID.LunarCraftingStation)
                    .Register();
            }
            // Terrarian Made of 9999 Dirt :)
        }
    }
}