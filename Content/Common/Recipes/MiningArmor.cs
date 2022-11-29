using Terraria.ModLoader;
using Terraria;
using Terraria.ID;

namespace Asalinism.Content.Common.Recipes
{
    public class MiningArmor : ModSystem
    {
        static void RecipeCreate(int itemID, int firstIngredient, int secondIngredient, int firstIngredientValue, int secondIngredientValue, int tile) {
            Recipe.Create(itemID)
                .AddIngredient(firstIngredient, firstIngredientValue)
                .AddIngredient(secondIngredient, secondIngredientValue)
                .AddTile(tile)
                .Register();
        }
        static void RecipeCreate(int itemID, int firstIngredient, int firstIngredientValue, int tile) {
            Recipe.Create(itemID)
                .AddIngredient(firstIngredient, firstIngredientValue)
                .AddTile(tile)
                .Register();
        }
        public override void AddRecipes()
        {
            RecipeCreate(ItemID.MiningHelmet, ItemID.GoldBar, ItemID.Torch, 10, 2, TileID.Anvils);
            RecipeCreate(ItemID.MiningShirt, ItemID.Silk, 10, TileID.Loom);
            RecipeCreate(ItemID.MiningPants, ItemID.Silk, 7, TileID.Loom);
        }
    }
}