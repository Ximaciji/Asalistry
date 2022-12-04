using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Asalistry.Content.Common.Players;
using System;
using IL.Terraria.GameContent.Ambience;

namespace Asalistry.Content.Items.Accessories
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
			// Celestial Stone
            player.statDefense += 10;
            player.lifeRegen += 2;
            player.GetDamage(DamageClass.Generic) += 0.05f;
            player.GetCritChance(DamageClass.Generic) += 5;
            player.pickSpeed -= 0.5f;
            player.GetKnockback(DamageClass.Summon) += 0.5f;
			// Master Ninja Gear
			Random rand = new Random();
			if (rand.Next(0, 2) == 0) {
				player.GetModPlayer<CelestialNinjaGearAccecssory>().HasCelestialNinjaGear = true;
			}
			else if (rand.Next(0, 2) == 1) {
				player.GetModPlayer<CelestialNinjaGearAccecssory>().HasCelestialNinjaGear = true;
			}
		}	
	}
}