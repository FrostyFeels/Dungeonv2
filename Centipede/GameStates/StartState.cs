﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace Centipede.GameStates
{
    class StartState : GameObjectList
    {
        public StartState()
        {
            this.Add(new SpriteGameObject("IntroScreen"));
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);
            if (inputHelper.IsKeyDown(Keys.Space))
            {
                GameEnvironment.GameStateManager.SwitchTo("Play");
            }
        }
    }
}
