using Terraria;
using System;
using System.Diagnostics;
using Microsoft.Xna.Framework;

using TAPI;

namespace jExo // Internal name of your mod.
{
    public class ExoMinigunAccurate : ModItem // Change the itemname into name of your shotgun.
    {

        public override bool PreShoot(Player player, Vector2 ShootPos, Vector2 ShootVelocity, int projType, int Damage, float knockback)
        {
            int ShotAmt = 1; // Amount of shots fired
            int spread = 1; // Shot spread
            float spreadMult = 0.03f; // Spread multiplier
            for (int i = 0; i < ShotAmt; i++)
            {
                float vX = ShootVelocity.X + (float)Main.rand.Next(-spread, spread + 1) * spreadMult;
                float vY = ShootVelocity.Y + (float)Main.rand.Next(-spread, spread + 1) * spreadMult;

                Projectile.NewProjectile(ShootPos.X, ShootPos.Y, vX, vY, projType, Damage, knockback, Main.myPlayer);
            }
            return false;
        }
    }
}