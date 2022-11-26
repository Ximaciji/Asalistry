using Terraria.ModLoader;
using Terraria;
using Terraria.ID;
using Terraria.Localization;

namespace Asalinism.Content.Scripts.CustomRecipes
{
    public class WingsUpgrade : ModSystem
    {
        int[] SpiritWings = {ItemID.AngelWings, ItemID.DemonWings, ItemID.SoulofLight, ItemID.SoulofNight};
        int[] BugWings = {ItemID.FairyWings, ItemID.BeeWings, ItemID.ButterflyWings, ItemID.PixieDust, ItemID.TatteredBeeWing, ItemID.ButterflyDust, 50, 1, 1};
        int[] NormalWings = {ItemID.HarpyWings, ItemID.BatWings, ItemID.BoneWings, ItemID.GiantHarpyFeather, ItemID.BrokenBatWing, ItemID.BoneFeather};
        int[] ElementalWings = {ItemID.FrozenWings, ItemID.FlameWings, ItemID.IceFeather, ItemID.FireFeather};
        int[] OppositeSideWings = {ItemID.GhostWings, ItemID.BeetleWings, ItemID.SpectreBar, ItemID.BeetleHusk};
        int[] CreepyWings = {ItemID.SpookyWings, ItemID.TatteredFairyWings, ItemID.SpookyTwig, ItemID.BlackFairyDust};
        int[] BossWings = {ItemID.BetsyWings, ItemID.RainbowWings, ItemID.FishronWings, ItemID.FestiveWings, ItemID.MothronWings};
        int[] LunarWings = {ItemID.WingsSolar, ItemID.WingsNebula, ItemID.WingsStardust, ItemID.WingsVortex, ItemID.FragmentSolar, ItemID.FragmentNebula, ItemID.FragmentStardust, ItemID.FragmentVortex};
        int[] DevWings = {ItemID.RedsWings, ItemID.DTownsWings, ItemID.WillsWings, ItemID.CrownosWings, ItemID.CenxsWings, ItemID.BejeweledValkyrieWing, ItemID.Yoraiz0rWings, ItemID.JimsWings, ItemID.SkiphsWings, ItemID.LokisWings, ItemID.ArkhalisWings, ItemID.LeinforsWings, ItemID.GhostarsWings, ItemID.SafemanWings, ItemID.FoodBarbarianWings, ItemID.GroxTheGreatWings};
        int[] NPCWings = {ItemID.LeafWings, ItemID.Jetpack, ItemID.FinWings, ItemID.SteampunkWings};
        public override void AddRecipeGroups()
        {
            RecipeGroup SpiritWings = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.AngelWings)}", ItemID.AngelWings, ItemID.DemonWings);
            RecipeGroup.RegisterGroup(nameof(ItemID.AngelWings), SpiritWings);
            RecipeGroup BugWings = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.FairyWings)}", ItemID.FairyWings, ItemID.BeeWings, ItemID.ButterflyWings);
            RecipeGroup.RegisterGroup(nameof(ItemID.FairyWings), BugWings);
            RecipeGroup NormalWings = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.HarpyWings)}", ItemID.HarpyWings, ItemID.BatWings, ItemID.BoneWings);
            RecipeGroup.RegisterGroup(nameof(ItemID.HarpyWings), NormalWings);
            RecipeGroup ElementalWings = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.FrozenWings)}", ItemID.FrozenWings, ItemID.FlameWings);
            RecipeGroup.RegisterGroup(nameof(ItemID.FrozenWings), ElementalWings);
            RecipeGroup OppositeSideWings = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.GhostWings)}", ItemID.GhostWings, ItemID.BeetleWings);
            RecipeGroup.RegisterGroup(nameof(ItemID.GhostWings), OppositeSideWings);
            RecipeGroup CreepyWings = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.SpookyWings)}", ItemID.SpookyWings, ItemID.TatteredFairyWings);
            RecipeGroup.RegisterGroup(nameof(ItemID.SpookyWings), CreepyWings);
            RecipeGroup BossWings = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.BetsyWings)}", ItemID.BetsyWings, ItemID.RainbowWings, ItemID.FishronWings, ItemID.FestiveWings, ItemID.MothronWings);
            RecipeGroup.RegisterGroup(nameof(ItemID.BetsyWings), BossWings);
            RecipeGroup LunarWings = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.WingsSolar)}", ItemID.WingsSolar, ItemID.WingsNebula, ItemID.WingsStardust, ItemID.WingsVortex);
            RecipeGroup.RegisterGroup(nameof(ItemID.WingsSolar), LunarWings);
            RecipeGroup DevWings = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.RedsWings)}", ItemID.RedsWings, ItemID.DTownsWings, ItemID.WillsWings, ItemID.CrownosWings, ItemID.CenxsWings, ItemID.BejeweledValkyrieWing, ItemID.Yoraiz0rWings, ItemID.JimsWings, ItemID.SkiphsWings, ItemID.LokisWings, ItemID.ArkhalisWings, ItemID.LeinforsWings, ItemID.GhostarsWings, ItemID.SafemanWings, ItemID.FoodBarbarianWings, ItemID.GroxTheGreatWings);
            RecipeGroup.RegisterGroup(nameof(ItemID.RedsWings), DevWings);
        }
        public override void AddRecipes()
        {
            Recipe.Create(ItemID.CreativeWings)
                .AddIngredient(ItemID.Bird, 10)
                .AddIngredient(ItemID.CopperBar, 10)
                .AddTile(TileID.Anvils)
                .Register();
            for (int i = 0; i < 2; i++) {
                Recipe.Create(SpiritWings[i])
                    .AddIngredient(ItemID.CreativeWings)
                    .AddIngredient(SpiritWings[i+2], 10)
                    .AddTile(TileID.Anvils)
                    .Register();
            }
            for (int i = 0; i < 2; i++) {
                Recipe.Create(SpiritWings[i])
                    .AddRecipeGroup(nameof(ItemID.AngelWings))
                    .AddTile(TileID.Anvils)
                    .Register();
            }
            for (int i = 0; i < 3; i++) {
                Recipe.Create(BugWings[i])
                    .AddRecipeGroup(nameof(ItemID.AngelWings))
                    .AddIngredient(BugWings[i+3], BugWings[i+6])
                    .AddTile(TileID.Anvils)
                    .Register();
            }
            for (int i = 0; i < 3; i++) {
                Recipe.Create(BugWings[i])
                    .AddRecipeGroup(nameof(ItemID.FairyWings))
                    .AddTile(TileID.Anvils)
                    .Register();
            }
            for (int i = 0; i < 3; i++) {
                Recipe.Create(NormalWings[i])
                    .AddRecipeGroup(nameof(ItemID.FairyWings))
                    .AddIngredient(NormalWings[i+3], 1)
                    .AddTile(TileID.Anvils)
                    .Register();
            }
            for (int i = 0; i < 3; i++) {
                Recipe.Create(NormalWings[i])
                    .AddRecipeGroup(nameof(ItemID.HarpyWings))
                    .AddTile(TileID.Anvils)
                    .Register();
            }
            for (int i = 0; i < 2; i++) {
                Recipe.Create(ElementalWings[i])
                    .AddRecipeGroup(nameof(ItemID.HarpyWings))
                    .AddIngredient(ElementalWings[i+2], 1)
                    .AddTile(TileID.Anvils)
                    .Register();
            }
            for (int i = 0; i < 2; i++) {
                Recipe.Create(ElementalWings[i])
                    .AddRecipeGroup(nameof(ItemID.FrozenWings))
                    .AddTile(TileID.Anvils)
                    .Register();
            }
            for (int i = 0; i < 2; i++) {
                Recipe.Create(OppositeSideWings[i])
                    .AddRecipeGroup(nameof(ItemID.FrozenWings))
                    .AddIngredient(OppositeSideWings[i+2], 5)
                    .AddTile(TileID.Anvils)
                    .Register();
            }
            for (int i = 0; i < 2; i++) {
                Recipe.Create(OppositeSideWings[i])
                    .AddRecipeGroup(nameof(ItemID.GhostWings))
                    .AddTile(TileID.Anvils)
                    .Register();
            }
            for (int i = 0; i < 2; i++) {
                Recipe.Create(CreepyWings[i])
                    .AddRecipeGroup(nameof(ItemID.GhostWings))
                    .AddIngredient(CreepyWings[i+2], 1)
                    .AddTile(TileID.Anvils)
                    .Register();
            }
            for (int i = 0; i < 2; i++) {
                Recipe.Create(CreepyWings[i])
                    .AddRecipeGroup(nameof(ItemID.SpookyWings))
                    .AddTile(TileID.Anvils)
                    .Register();
            }
            for (int i = 0; i < 4; i++) {
                Recipe.Create(LunarWings[i])
                    .AddRecipeGroup(nameof(ItemID.BetsyWings))
                    .AddIngredient(LunarWings[i+4], 5)
                    .AddTile(TileID.LunarCraftingStation)
                    .Register();
            }
            for (int i = 0; i < 4; i++) {
                Recipe.Create(LunarWings[i])
                    .AddRecipeGroup(nameof(ItemID.WingsSolar))
                    .AddTile(TileID.LunarCraftingStation)
                    .Register();
            }
            for (int i = 0; i < 16; i++) {
                Recipe.Create(DevWings[i])
                    .AddRecipeGroup(nameof(ItemID.RedsWings))
                    .Register();
            }
        }
    }
}