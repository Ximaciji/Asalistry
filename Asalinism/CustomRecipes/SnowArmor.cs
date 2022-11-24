using Terraria.ModLoader;
using Terraria;
using Terraria.ID;

namespace Asalinism.CustomRecipes
{
    public class SnowArmor : ModSystem
    {
        public override void AddRecipes()
        {
            Recipe.Create(ItemID.EskimoHood)
                .AddIngredient(ItemID.PinkEskimoHood, 1)
                .Register();
            Recipe.Create(ItemID.EskimoCoat)
                .AddIngredient(ItemID.PinkEskimoCoat, 1)
                .Register();
            Recipe.Create(ItemID.EskimoPants)
                .AddIngredient(ItemID.PinkEskimoPants, 1)
                .Register();
            Recipe.Create(ItemID.PinkEskimoHood)
                .AddIngredient(ItemID.EskimoHood, 1)
                .Register();
            Recipe.Create(ItemID.PinkEskimoCoat)
                .AddIngredient(ItemID.EskimoCoat, 1)
                .Register();
            Recipe.Create(ItemID.PinkEskimoPants)
                .AddIngredient(ItemID.EskimoPants, 1)
                .Register();
        }
    }
}