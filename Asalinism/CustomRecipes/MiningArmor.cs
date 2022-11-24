using Terraria.ModLoader;
using Terraria;
using Terraria.ID;

namespace Asalinism.CustomRecipes
{
    public class MiningArmor : ModSystem
    {
        public override void AddRecipes()
        {
            Recipe.Create(ItemID.MiningHelmet)
                .AddIngredient(ItemID.GoldBar, 10)
                .AddIngredient(ItemID.Torch, 2)
                .AddTile(TileID.Anvils)
                .Register();
            Recipe.Create(ItemID.MiningShirt)
                .AddIngredient(ItemID.Silk, 10)
                .AddTile(TileID.Loom)
                .Register();
            Recipe.Create(ItemID.MiningPants)
                .AddIngredient(ItemID.Silk, 7)
                .AddTile(TileID.Loom)
                .Register();
        }
    }
}