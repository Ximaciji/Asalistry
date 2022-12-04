using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Asalistry.Content.Items.Accessories
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
			player.accFlipper = true;
			player.accRunSpeed = 10f;
			player.frogLegJumpBoost = true;
			player.autoJump = true;
			player.noFallDmg = true;
			player.waterWalk = true;
			player.lavaImmune = true;
			player.fireWalk = true;
			player.waterWalk2 = true;
			player.iceSkate = true;
			player.moveSpeed += 0.5f;
			player.maxRunSpeed += 0.5f;
			player.rocketBoots = 1;
			player.rocketTimeMax += 1;
		}

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.TerrasparkBoots)
				.AddIngredient(ItemID.FrogLeg)
				.AddIngredient(ItemID.Flipper)
				.Register();
			CreateRecipe()
				.AddIngredient(ItemID.TerrasparkBoots)
				.AddIngredient(ItemID.AmphibianBoots)
				.Register();
		}
	}
}