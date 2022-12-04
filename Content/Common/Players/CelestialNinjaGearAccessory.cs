using IL.Terraria;
using On.Terraria;
using System;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace Asalistry.Content.Common.Players
{
	
	public class CelestialNinjaGearAccecssory : ModPlayer {
		public bool HasCelestialNinjaGear;

		public override void ResetEffects() {
			HasCelestialNinjaGear = false;
		}

        public override bool PreHurt(bool pvp, bool quiet, ref int damage, ref int hitDirection, ref bool crit, ref bool customDamage, ref bool playSound, ref bool genGore, ref PlayerDeathReason damageSource, ref int cooldownCounter) {
			if (HasCelestialNinjaGear) {
				damage = 0;
				Player.NinjaDodge();
				return false;
			}
			return true;
		}
	}
}