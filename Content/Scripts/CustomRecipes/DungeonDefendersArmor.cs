using Terraria.ModLoader;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using System;

namespace Asalinism.Content.Scripts.CustomRecipes
{
    public class DungeonDefendersArmor : ModSystem
    {
        
        /* I want to loop the RecipeGroups and AddRecipes, but I get an error because "nameof()" takes the name of the variable in the loop, and not the data assigned to it. For ex; 
        int[] recipeGroups = new int[6]
        public override void AddRecipeGroups()
        {
            RecipeGroup recipeGroups[i] = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ddArmor[i][3])}", ddArmor[i][0], ddArmor[i][1], ddArmor[i][2], ddArmor[i][3]);
            RecipeGroup.RegisterGroup(nameof(ddArmor[i][0]), recipeGroups[i]);
            
            // recipeGroups[i] does not work as a name
            // nameof(ddArmor[i][0]) tries to get the internal file of ddArmor[i][0] instead of what that value would equal (ItemID.ApprenticeHat, ItemID.ApprenticeRobe, etc)
        } Same thing happens with trying to create a method for  looping the for-loops in AddRecipe(). nameof() trips me up.
        */
        
        int[][] ddArmor = new int[][]
        {
        new int[] { ItemID.MonkBrows, ItemID.SquireGreatHelm, ItemID.HuntressWig, ItemID.ApprenticeHat },
        new int[] { ItemID.MonkShirt, ItemID.SquirePlating, ItemID.HuntressJerkin, ItemID.ApprenticeRobe },
        new int[] { ItemID.MonkPants, ItemID.SquireGreaves, ItemID.HuntressPants, ItemID.ApprenticeTrousers },
        new int[] { ItemID.MonkAltHead, ItemID.SquireAltHead, ItemID.HuntressAltHead, ItemID.ApprenticeAltHead },
        new int[] { ItemID.MonkAltShirt, ItemID.SquireAltShirt, ItemID.HuntressAltShirt, ItemID.ApprenticeAltShirt },
        new int[] { ItemID.MonkAltPants, ItemID.SquireAltPants, ItemID.HuntressAltPants, ItemID.ApprenticeAltPants }
        };
        public override void AddRecipeGroups()
        {
            RecipeGroup DD1Head = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ddArmor[0][0])}", ddArmor[0][0], ddArmor[0][1], ddArmor[0][2], ddArmor[0][3]);
            RecipeGroup.RegisterGroup(nameof(ItemID.MonkBrows), DD1Head);
            RecipeGroup DD1Shirt = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ddArmor[1][0])}", ddArmor[1][0], ddArmor[1][1], ddArmor[1][2], ddArmor[1][3]);
            RecipeGroup.RegisterGroup(nameof(ItemID.MonkShirt), DD1Shirt);
            RecipeGroup DD1Pants = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ddArmor[2][0])}", ddArmor[2][0], ddArmor[2][1], ddArmor[2][2], ddArmor[2][3]);
            RecipeGroup.RegisterGroup(nameof(ItemID.MonkPants), DD1Pants);
            RecipeGroup DD2Head = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ddArmor[3][0])}", ddArmor[3][0], ddArmor[3][1], ddArmor[3][2], ddArmor[3][3]);
            RecipeGroup.RegisterGroup(nameof(ItemID.MonkAltHead), DD2Head);
            RecipeGroup DD2Shirt = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ddArmor[4][0])}", ddArmor[4][0], ddArmor[4][1], ddArmor[4][2], ddArmor[4][3]);
            RecipeGroup.RegisterGroup(nameof(ItemID.MonkAltShirt), DD2Shirt);
            RecipeGroup DD2Pants = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ddArmor[2][0])}", ddArmor[5][0], ddArmor[5][1], ddArmor[5][2], ddArmor[5][3]);
            RecipeGroup.RegisterGroup(nameof(ItemID.MonkAltPants), DD2Pants);
        }
        public override void AddRecipes()
        {
            for (int i = 0; i < 4; i++) {
                Recipe.Create(ddArmor[0][i])
                .AddRecipeGroup(nameof(ItemID.MonkBrows))
                .Register();
            }
            for (int i = 0; i < 4; i++) {
                Recipe.Create(ddArmor[1][i])
                .AddRecipeGroup(nameof(ItemID.MonkShirt))
                .Register();
            }
            for (int i = 0; i < 4; i++) {
                Recipe.Create(ddArmor[2][i])
                .AddRecipeGroup(nameof(ItemID.MonkPants))
                .Register();
            }
            for (int i = 0; i < 4; i++) {
                Recipe.Create(ddArmor[3][i])
                .AddRecipeGroup(nameof(ItemID.MonkAltHead))
                .Register();
            }
            for (int i = 0; i < 4; i++) {
                Recipe.Create(ddArmor[4][i])
                .AddRecipeGroup(nameof(ItemID.MonkAltShirt))
                .Register();
            }
            for (int i = 0; i < 4; i++) {
                Recipe.Create(ddArmor[5][i])
                .AddRecipeGroup(nameof(ItemID.MonkAltPants))
                .Register();
            }
        }
    }
}