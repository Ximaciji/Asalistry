using Terraria.ModLoader;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using System;

namespace Asalinism.Content.Common.Recipes
{
    public class DungeonDefendersArmor : ModSystem
    {
        int[][] ddArmor = new int[][]
            {
            new int[] { ItemID.MonkBrows, ItemID.SquireGreatHelm, ItemID.HuntressWig, ItemID.ApprenticeHat },
            new int[] { ItemID.MonkShirt, ItemID.SquirePlating, ItemID.HuntressJerkin, ItemID.ApprenticeRobe },
            new int[] { ItemID.MonkPants, ItemID.SquireGreaves, ItemID.HuntressPants, ItemID.ApprenticeTrousers },
            new int[] { ItemID.MonkAltHead, ItemID.SquireAltHead, ItemID.HuntressAltHead, ItemID.ApprenticeAltHead },
            new int[] { ItemID.MonkAltShirt, ItemID.SquireAltShirt, ItemID.HuntressAltShirt, ItemID.ApprenticeAltShirt },
            new int[] { ItemID.MonkAltPants, ItemID.SquireAltPants, ItemID.HuntressAltPants, ItemID.ApprenticeAltPants },
            };

        string[] ddArmorNames = new string[] { "ItemID.MonkBrows", "ItemID.MonkShirt", "ItemID.MonkPants", "ItemID.MonkAltHead", "ItemID.MonkAltShirt", "ItemID.MonkAltPants"};
        
        public override void AddRecipeGroups()
        {
            for (int i = 0; i < ddArmor.GetLength(0); i++)
            {
                RecipeGroup ArmorRecipes = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ddArmor[i][0])}", ddArmor[i]);
                RecipeGroup.RegisterGroup(ddArmorNames[i], ArmorRecipes);
            }
        }
        public override void AddRecipes()
        {
            for (int j = 0; j < 4; j++) {
                for (int i = 0; i < 6; i++) {
                Recipe.Create(ddArmor[i][j])
                    .AddRecipeGroup(ddArmorNames[i])
                    .Register();
                }
            }
        }
    }
}