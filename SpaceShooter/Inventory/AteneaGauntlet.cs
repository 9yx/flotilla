﻿#region Using
using System;
using System.Collections.Generic;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
#if XBOX
using Microsoft.Xna.Framework.Net;
#endif
using Microsoft.Xna.Framework.Storage;
#endregion

namespace SpaceShooter
{
    public class itAteneaGauntlet : InventoryItem
    {

        public itAteneaGauntlet()
        {
            GameEffect newEffect = new GameEffect();
            newEffect.armorModifierRear = 2;
            this.gameEffect = newEffect;

            
            image = sprite.inventory.Gauntlet;
            name = iResource.AteneaGauntlet;
            description = iResource.AteneaGauntletDescription;
        }
    }
}