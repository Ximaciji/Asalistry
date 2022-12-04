using IL.Terraria;
using On.Terraria;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace Asalistry.Content.Common.Players
{
	
	public class SagePrisonerAccessory : ModPlayer {
		public bool HasSagePrisoner;
		
		public override void ResetEffects() {
			HasSagePrisoner = false;
		}

        public override bool PreKill(double damage, int hitDirection, bool pvp, ref bool playSound, ref bool genGore, ref PlayerDeathReason damageSource) {
			if (HasSagePrisoner) {
				damage = 0;
				playSound = false;
				hitDirection = 0;
				pvp = false;
				Player.immune = true;
				Player.immuneTime = 60;
				Player.immuneNoBlink = false;
				Player.statLife = Player.statLifeMax2;
				return false;
			}
			else {
				return true;
			}
		}
	}
}