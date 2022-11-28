using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

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

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.CelestialShell)
				.AddIngredient(ItemID.MasterNinjaGear)
				.AddTile(TileID.TinkerersWorkbench)
				.Register();
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
			// Celestial Shell
			player.GetAttackSpeed(DamageClass.Melee) += 0.1f;
			player.GetDamage(DamageClass.Generic) += 0.1f;
			player.GetCritChance(DamageClass.Generic) += 2f;
			player.lifeRegen += 1;
			player.statDefense += 4;
			player.GetKnockback(DamageClass.Summon) += 0.05f;
			player.breathMax = 100;
			player.breath = 100;
			

			// Master Ninja Gear
		}
	}
}