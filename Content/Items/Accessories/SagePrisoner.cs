using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Asalistry.Content.Common.Players;

namespace Asalistry.Content.Items.Accessories
{
	public class SagePrisoner : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Sage Prisoner");
			Tooltip.SetDefault("The sage died so his comrades could use their bones as a shield.");
		}

		public override void SetDefaults() {
			Item.width = 40; 
			Item.height = 40;
			Item.accessory = true; // Makes this item an accessory.
			Item.rare = ItemRarityID.Blue; 
			Item.value = Item.sellPrice(gold: 1); // Sets the item sell price to one gold coin.
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
			player.GetModPlayer<SagePrisonerAccessory>().HasSagePrisoner = true;
		}
	}
}