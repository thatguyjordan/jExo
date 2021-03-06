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
            bool fullBasic = player.armor[0].name.Contains("Exo Headgear") && player.armor[1].name.Contains("Exo Chestplate") && player.armor[2].name.Contains("Exo Greaves") && player.armor[0].tooltip.Contains("Basic Plating") && player.armor[1].tooltip.Contains("Basic Plating") && player.armor[2].tooltip.Contains("Basic Plating");
            bool fullAdv = player.armor[0].name.Contains("Exo Headgear") && player.armor[1].name.Contains("Exo Chestplate") && player.armor[2].name.Contains("Exo Greaves") && player.armor[0].tooltip.Contains("Advanced Plating") && player.armor[1].tooltip.Contains("Advanced Plating") && player.armor[2].tooltip.Contains("Advanced Plating");
            bool fullNava = player.armor[0].name.Contains("Exo Headgear") && player.armor[1].name.Contains("Exo Chestplate") && player.armor[2].name.Contains("Exo Greaves") && player.armor[0].tooltip.Contains("Nava Shield Plating") && player.armor[1].tooltip.Contains("Nava Shield Plating") && player.armor[2].tooltip.Contains("Nava Shield Plating");

            if (fullExo == true)
            {
                player.moveSpeed += 0.05f;
                player.statDefense += 8;
            }
            if (fullBasic == true)
            {
                player.statDefense += 5;
            } 
            if (fullAdv == true)
            {
                player.moveSpeed -= 0.1f;
                player.statDefense += 12;
            }
            if (fullNava == true)
            {
                player.statDefense += 20;
            }
            if (fullExo == true && player.inventory[player.selectedItem].name.Contains("Exo Claw"))
            {
                player.meleeSpeed += 0.05f;
            }
            if (fullExo == true && player.inventory[player.selectedItem].name.Contains("Exo Minigun"))
            {
                player.inventory[player.selectedItem].shootSpeed += 0.07f;
            }
            if (player.armor[1].tooltip.Contains("Knockback Resistance") && player.armor[1].name.Contains("Exo Chestplate"))
            {
                player.knockbackResist = 0f;
            }
            if (player.armor[2].tooltip.Contains("Water Walking") && player.armor[2].name.Contains("Exo Greaves"))
            {
                player.waterWalk = true;
            }
            if (player.armor[2].tooltip.Contains("Movement Speed") && player.armor[2].name.Contains("Exo Greaves"))
            {
                if (player.armor[2].tooltip.Contains("Nava Shield Plating"))
                {
                    player.moveSpeed += 0.25f;
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
            if (player.armor[2].tooltip.Contains("Jump Boost") && player.armor[2].name.Contains("Exo Greaves"))
            {
                player.jumpBoost = true;
            }
            if (player.armor[0].tooltip.Contains("Ranged Upgrade") && player.armor[0].name.Contains("Exo Helmet"))
            {
                if (player.armor[0].tooltip.Contains("Nava Shield Plating"))
                {
                    player.rangedCrit += 15;
                    player.rangedDamage += 0.15f;
                    player.ammoCost75 = true;
                }  
                else if (player.armor[0].tooltip.Contains("Advanced Plating"))
                {
                    player.rangedCrit += 11;
                    player.rangedDamage += 0.10f;
                    player.ammoCost75 = true;
                }
                else
                {
                    player.rangedCrit += 8;
                    player.rangedDamage += 0.08f;
                    player.ammoCost80 = true;
                }
            }
            if (player.armor[0].tooltip.Contains("Magic Upgrade") && player.armor[0].name.Contains("Exo Helmet"))
            {
                if (player.armor[0].tooltip.Contains("Nava Shield Plating"))
                {
                    player.statManaMax2 += 60;
                    player.manaCost -= 0.10f;
                    player.magicCrit += 12;
                    player.magicDamage += 0.18f;
                }
                else if (player.armor[0].tooltip.Contains("Advanced Plating"))
                {
                    player.statManaMax2 += 40;
                    player.manaCost -= 0.06f;
                    player.magicCrit += 5;
                    player.magicDamage += 0.08f;
                }
                else
                {
                    player.statManaMax2 += 20;
                    player.manaCost -= 0.08f;
                    player.magicCrit += 8;
                    player.magicDamage += 0.12f;
                }
            }
            if (player.armor[0].tooltip.Contains("Melee Upgrade") && player.armor[0].name.Contains("Exo Helmet"))
            {
                if (player.armor[0].tooltip.Contains("Nava Shield Plating"))
                {
                    player.meleeSpeed += 0.1f;
                    player.meleeCrit += 15;
                    player.meleeDamage += 0.18f;
                }
                else if (player.armor[0].tooltip.Contains("Advanced Plating"))
                {
                    player.meleeSpeed += 0.06f;
                    player.meleeCrit += 8;
                    player.meleeDamage += 0.10f;
                }
                else
                {
                    player.meleeSpeed += 0.03f;
                    player.meleeCrit += 12;
                    player.meleeDamage += 0.14f;
                }
            }
            if (player.armor[0].tooltip.Contains("Mana Reduction") && player.armor[0].name.Contains("Exo Helmet"))
            {
                if (player.armor[0].tooltip.Contains("Magic Upgrade"))
                {
                    player.manaCost -= 0.10f;
                }
                else
                {
                    player.manaCost -= 0.15f;
                }
            }
            if (player.armor[1].tooltip.Contains("Aggravating") && player.armor[1].name.Contains("Exo Chestplate"))
            {
                player.aggro += 500;
                player.enemySpawns = true;
            }
            if (player.armor[1].tooltip.Contains("Heat Exchanger") && player.armor[1].name.Contains("Exo Chestplate"))
            {
                player.fireWalk = true;
                player.lavaMax += 600;
            }
            if (player.armor[2].tooltip.Contains("Rocket Boots") && player.armor[2].name.Contains("Exo Greaves"))
            {
                player.canRocket = true;
                player.rocketBoots = 1;
            }
        }
    }
}