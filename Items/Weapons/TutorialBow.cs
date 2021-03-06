﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TutorialMod.Items.Weapons
{
    public class TutorialBow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tutorial Bow");
        }

        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 24;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 5; // Bow Use Style
            item.noMelee = true; // Doesn't deal damage if an enemy touches at melee range.
            item.value = Item.buyPrice(0, 0, 10, 0); // Another way to handle value of item.
            item.rare = 2;
            item.UseSound = SoundID.Item5; // Sound for Bows
            item.useAmmo = AmmoID.Arrow; // The ammo used with this weapon
            item.shoot = 1;
            item.shootSpeed = 1.8f;
            item.ranged = true; // For Ranged Weapon
        }
    }
}
