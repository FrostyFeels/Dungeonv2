using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Centipede
{
    class Player : RotatingSpriteGameObject
    {
        Mouse Mouse;
        public float speed = 300f;
        public int hp = 11113;
       
        public Player(Mouse mouse) : base("Player/spr_player")
        {
            this.Mouse = mouse;
            origin = Center;
            Reset();
            
        }

        public override void Reset()
        {
            base.Reset();
            position.X = GameEnvironment.Screen.X / 2;
            position.Y = GameEnvironment.Screen.Y / 2;
        }

        // Handles input for player
        public override void HandleInput(InputHelper inputHelper)
        {
            
            base.HandleInput(inputHelper);
            velocity = PlayerHandeling.newVelocity;

            




        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            LookAt(Mouse, -90);

            if(hp <= 0)
            {
                position.X = -1000;
            }
            

        }
    }
}
