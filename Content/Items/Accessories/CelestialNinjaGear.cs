using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Asalinism.Content.Items.Accessories
{
	public class CelestialNinjaGear : ModItem
	{
		public override void SetStaticDefaults() {
            DisplayName.SetDefault("Celestial Ninja Gear");
			Tooltip.SetDefault("Celestial Shell + Master Ninja Gear");
		}

		public override void SetDefaults() {
			Item.width = 26;
			Item.height = 32;
			Item.maxStack = 1;
			Item.value = Item.sellPrice(gold: 5);
			Item.accessory = true;
			Item.rare = ItemRarityID.Red;
		}
	}
}