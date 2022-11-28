using Terraria.ModLoader;
using Terraria;
using Terraria.ID;

namespace Asalinism.Content.Scripts.CustomRecipes
{
    public class SnowArmor : ModSystem
    {
        int[] snowArmor = new int[] { ItemID.EskimoHood, ItemID.EskimoCoat, ItemID.EskimoPants, ItemID.PinkEskimoHood, ItemID.PinkEskimoCoat, ItemID.PinkEskimoPants };
        static int DetermineColor(int arrayElement) {
            if (arrayElement < 3) {
                return (arrayElement + 3);
            } else {
                return (arrayElement - 3);
            }
        }
        public override void AddRecipes()
        {
            for (int i = 0; i < 6; i++)
            {
                Recipe.Create(snowArmor[i])
                    .AddIngredient(snowArmor[DetermineColor(i)])
                    .Register();
            } 
        }
    }
}