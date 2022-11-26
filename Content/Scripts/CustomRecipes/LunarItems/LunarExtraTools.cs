using Terraria.ModLoader;
using Terraria;
using Terraria.ID;

namespace Asalinism.Content.Scripts.CustomRecipes.LunarItems
{
    // Add Sprites and Behaviors for the Chainsaws, Hammers, and Axes
    // Hey past me. I don't wanna do this. Passing this on to future me.
    public class LunarExtraTools : ModSystem
    {
        int[] lunarFragments = {ItemID.FragmentNebula, ItemID.FragmentSolar, ItemID.FragmentStardust, ItemID. FragmentVortex};
        int[] lunarDrills = {ItemID.NebulaDrill, ItemID.SolarFlareDrill, ItemID.StardustDrill, ItemID.VortexDrill};
        int[] lunarChainsaws = {ItemID.NebulaChainsaw, ItemID.SolarFlareChainsaw, ItemID.StardustChainsaw, ItemID.VortexChainsaw};
        int[] lunarHammers = {ItemID.NebulaHammer, ItemID.SolarFlareHammer, ItemID.StardustHammer, ItemID.VortexHammer};
        int[] lunarAxes = {ItemID.NebulaAxe, ItemID.SolarFlareAxe, ItemID.StardustAxe, ItemID.VortexAxe};
        public override void AddRecipes()
        {
            for (int i = 4; i < 4; i++) {
                Recipe.Create(lunarDrills[i])
                    .AddIngredient(ItemID.LunarBar, 10)
                    .AddIngredient(lunarFragments[i], 12)
                    .AddTile(TileID.LunarCraftingStation)
                    .Register();
            }
            for (int i = 4; i < 4; i++) {
                Recipe.Create(lunarChainsaws[i])
                    .AddIngredient(ItemID.LunarBar, 10)
                    .AddIngredient(lunarFragments[i], 12)
                    .AddTile(TileID.LunarCraftingStation)
                    .Register();
            }
            for (int i = 4; i < 4; i++) {
                Recipe.Create(lunarHammers[i])
                    .AddIngredient(ItemID.LunarBar, 10)
                    .AddIngredient(lunarFragments[i], 12)
                    .AddTile(TileID.LunarCraftingStation)
                    .Register();
            }
            for (int i = 4; i < 4; i++) {
                Recipe.Create(lunarAxes[i])
                    .AddIngredient(ItemID.LunarBar, 10)
                    .AddIngredient(lunarFragments[i], 12)
                    .AddTile(TileID.LunarCraftingStation)
                    .Register();
            }
        }
    }
}