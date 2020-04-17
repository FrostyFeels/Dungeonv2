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
    class PlayerHandeling : GameObject
    {
        Player player;
        public static Vector2 newVelocity;
        public static bool ReadyToFire = false;
        int reloadtimer;

        public PlayerHandeling(Player player)
        {
            this.player = player;
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);
            if (inputHelper.IsKeyDown(Keys.W)) { newVelocity.Y = -player.speed; }
            else if (inputHelper.IsKeyDown(Keys.S)) { newVelocity.Y = player.speed; }
            else { newVelocity.Y = 0; }
          

            if (inputHelper.IsKeyDown(Keys.A)) { newVelocity.X = -player.speed; }
            else if (inputHelper.IsKeyDown(Keys.D)) { newVelocity.X = player.speed; }
            else { newVelocity.X = 0; }

            if(inputHelper.KeyPressed(Keys.D1)) { PlayerWeapons.Pistol(); }
            if (inputHelper.KeyPressed(Keys.D2)) { PlayerWeapons.SemiAuto(); }
            if (inputHelper.KeyPressed(Keys.D3)) { PlayerWeapons.Shotgun(); }
            if (inputHelper.KeyPressed(Keys.D4)) { PlayerWeapons.Sniper(); }

            if(inputHelper.MouseLeftButtonPressed()) 
            {
                if (reloadtimer >= PlayerWeapons.firerate)
                {
                    PlayerFire.Fire(player.Position, player.AngularDirection, new Vector2(25, 0));
                    reloadtimer = 0;
                }
          
            }

        


        }


        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            reloadtimer++;


          
        }

    }
}
