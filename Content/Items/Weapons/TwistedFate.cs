using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;


namespace Asalinism.Content.Items.Weapons
{
	public class TwistedFate : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("This is a modded sword.");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}
		public override void SetDefaults() {
			Item.width = 32;
			Item.height = 32;

			Item.useStyle = ItemUseStyleID.Swing;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.autoReuse = true;

			Item.DamageType = DamageClass.Melee;
			Item.damage = 50;
			Item.knockBack = 6;
			Item.crit = 6;

			Item.UseSound = SoundID.Item1;
			Item.rare = ItemRarityID.Red;
		}
		public override void MeleeEffects(Player player, Rectangle hitbox) {
			Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, DustID.Sandstorm);
			Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, DustID.Sand);
			Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, DustID.Sandnado);
		}
		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit) {
			target.AddBuff(BuffID.Bleeding, 60);
			target.AddBuff(BuffID.OnFire, 60);
		}
		public override void AddRecipes() {
			CreateRecipe()
				.Register();
		}
	}
}