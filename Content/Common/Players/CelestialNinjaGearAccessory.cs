using IL.Terraria;
using On.Terraria;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace Asalinism.Content.Common.Players
{
	
	public class CelestialNinjaGearAccecssory : ModPlayer {
		public bool HasCelestialNinjaGear;

		public override void ResetEffects() {
			HasCelestialNinjaGear = false;
		}

        [System.Obsolete]
        public override bool PreHurt(bool pvp, bool quiet, ref int damage, ref int hitDirection, ref bool crit, ref bool customDamage, ref bool playSound, ref bool genGore, ref PlayerDeathReason damageSource) {
			if (HasCelestialNinjaGear) {
				damage = 0;
				playSound = false;
				hitDirection = 0;
				quiet = false;
				Player.immune = true;
				Player.immuneTime = 60;
				Player.immuneNoBlink = false;
				return false;
			}
			return true;
		}

        // [System.Obsolete]
        public override void PostHurt(bool pvp, bool quiet, double damage, int hitDirection, bool crit, int cooldownCounter) {
			Player.AddImmuneTime(cooldownCounter, 60);
			if (HasCelestialNinjaGear) {
				Player.statLife += (int)damage;
				if (Player.statLife > Player.statLifeMax2) {
					Player.statLife = Player.statLifeMax2;
				}
			Player.HealEffect((int)damage);
			return;
			}
		}
	}
}