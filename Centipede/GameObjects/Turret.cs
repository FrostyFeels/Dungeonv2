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
    class Turret : RotatingSpriteGameObject
    {
        Player player;
        int framecount = 0;
        


        public Turret(Vector2 startposition, Player player) : base("Turret/spr_turret")
        {
            this.player = player;
            position = startposition;
            origin = Center;
            

        }

        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);
       
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            
            LookAt(player, 90);
            framecount++;

            if(framecount > GameEnvironment.Random.Next(120,240))
            {
                framecount = 0;
                fire();
            }
          
            
        }

        public void fire()
        {
            
            
            ObjectPool.Spawner(position, AngularDirection);
        }
    }
}
