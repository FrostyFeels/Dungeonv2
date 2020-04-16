using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlappyBird;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Centipede
{
    class Player : RotatingSpriteGameObject
    {
        float speed = 300f;
        public Player() : base("Player/spr_player")
        {
            origin = Center;
            Reset();
        }

        public override void Reset()
        {
            base.Reset();
            position.X = GameEnvironment.Screen.X / 2;
            position.Y = GameEnvironment.Screen.Y / 2;
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);
            if (inputHelper.IsKeyDown(Keys.W)) { velocity.Y = -speed; }
            else if (inputHelper.IsKeyDown(Keys.S)) { velocity.Y = speed; }
            else velocity.Y = 0;
            if (inputHelper.IsKeyDown(Keys.A)) { velocity.X = -speed; }
            else if (inputHelper.IsKeyDown(Keys.D)) { velocity.X = speed; }
            else velocity.X = 0;

        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime); 
        }
    }
}
