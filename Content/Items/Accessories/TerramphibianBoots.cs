using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Asalinism.Content.Items.Accessories
{
	[AutoloadEquip(EquipType.Shoes)]
	public class TerramphibianBoots : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Terramphibian Boots");
			Tooltip.SetDefault("Terraspark + Frog Leg + Flippers");
		}

		public override void SetDefaults() {
			Item.width = 28; 
			Item.height = 24;
			Item.accessory = true; // Makes this item an accessory.
			Item.rare = ItemRarityID.Blue; 
			Item.value = Item.sellPrice(gold: 1); // Sets the item sell price to one gold coin.
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
			player.accRunSpeed = 6f; // The player's maximum run speed with accessories
			player.moveSpeed += 0.05f; // The acceleration multiplier of the player's movement speed
		}
	}
}