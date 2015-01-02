using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;

using TAPI;
using Terraria;


namespace jExo
{
    public sealed class MPlayer : ModPlayer
    {
        public override void Initialize()
        {
            base.Initialize();
        }
        public override void MidUpdate()
        {
            bool fullExo = player.armor[0].name.Contains("Exo Headgear") && player.armor[1].name.Contains("Exo Chestplate") && player.armor[2].name.Contains("Exo Greaves");

            if (fullExo = true) //&& player.inventory[player.selectedItem].type == ItemDef.byName["jExo:Exo Claw"].type)
            {
                player.moveSpeed += 0.05f;
                player.statDefense += 9191;
            }
            if (player.armor[0].name.Contains("Exo Headgear") && player.armor[1].name.Contains("Exo Chestplate") && player.armor[2].name.Contains("Exo Greaves") && player.inventory[player.selectedItem].name.Contains("Exo Claw"))
            {
                player.meleeSpeed += 0.05f;
            }
            if (player.armor[0].name.Contains("Exo Headgear") && player.armor[1].name.Contains("Exo Chestplate") && player.armor[2].name.Contains("Exo Greaves") && player.inventory[player.selectedItem].name.Contains("Exo Minigun"))
            {
                player.inventory[player.selectedItem].shootSpeed += 10.05f;
            }
            if (player.armor[0].tooltip.Contains("Plating") && player.armor[1].tooltip.Contains("Plating") && player.armor[2].tooltip.Contains("Plating"))
            {
                player.statDefense += 3;
            }
            if (player.armor[1].tooltip.Contains("Knockback Resistance") && player.armor[1].name.Contains("Exo Chestplate"))
            {
                player.knockbackResist = 1f;
            }
            if (player.armor[2].tooltip.Contains("Water Walking") && player.armor[2].name.Contains("Exo Greaves"))
            {
                player.waterWalk = true;
            }
            if (player.armor[2].tooltip.Contains("Movement Speed") && player.armor[2].name.Contains("Exo Greaves"))
            {
                if (player.armor[2].tooltip.Contains("Chlorophyte Plating") || player.armor[2].tooltip.Contains("Spectre Plating") || player.armor[2].tooltip.Contains("Shroomite Plating") || player.armor[2].tooltip.Contains("Turtle Plating") || player.armor[2].tooltip.Contains("Beetle Plating"))
                {
                    player.moveSpeed += 0.4f;
                }
                else
                {
                    player.moveSpeed += 0.1f;
                }
            }
            if (player.armor[0].tooltip.Contains("Night Vision") && player.armor[0].name.Contains("Exo Headgear"))
            {
                player.nightVision = true;
            }
            if (player.armor[0].tooltip.Contains("Spelunker") && player.armor[0].name.Contains("Exo Headgear"))
            {
                player.findTreasure = true;
            }
            if (player.armor[2].tooltip.Contains("No Falling Damage") && player.armor[2].name.Contains("Exo Greaves"))
            {
                player.noFallDmg = true;
            }
            if (player.armor[2].tooltip.Contains("Double Jump") && player.armor[2].name.Contains("Exo Greaves"))
            {
                player.doubleJump = true;
            }
        }
    }
}