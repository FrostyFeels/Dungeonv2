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
        int timer = GameEnvironment.Random.Next(60,120);
        int whatpattern;
        bool spray = false;
        int spraytime = 0;
        


        public Turret(Vector2 startposition, Player player) : base("Turret/spr_turret")
        {
            this.player = player;
            position = startposition;
            origin = Center;
            ReadyToFire();


        }

        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);
       
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            framecount++;
            ReadyToFire();
            LookAt(player, 90);
           
            if(spraytime >= 5)
            {
                spray = false;
            }
            
            

       
          
            
        }

        public void ReadyToFire()
        {
            if(framecount > timer)
            {
                fire();
                framecount = 0;
                

            }

        }

        public void fire()
        {
            if (spray)
            {
                whatpattern = 2;
                timer = 10;
                spraytime++;
                Console.WriteLine("spraytime2");
            }
            else 
            { 
                whatpattern = GameEnvironment.Random.Next(0, 3);
                timer = GameEnvironment.Random.Next(60, 240);
            }

            
            if(whatpattern == 0)
            {
                TurretPattern.Burst(position, AngularDirection);
            }
            if (whatpattern == 1)
            {
                TurretPattern.Single(position, AngularDirection);
            }
            if (whatpattern == 2)
            {
                TurretPattern.Spray(position, AngularDirection);
                spray = true;
                Console.WriteLine("spraytime");
            }




        }
    }
}
