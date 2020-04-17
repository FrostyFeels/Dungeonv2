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
    class PlayingState : GameObjectList
    {   
        
        public Vector2[] spawnLocation = new Vector2[8];
        public int[] offset = new int[8];
   
        GameObjectList turrets = new GameObjectList();
        GameObjectList turretstands = new GameObjectList();

        ObjectPool objectpool;
        Player player;
        Mouse mouse;

        public PlayingState()
        {
            spawnLocation[0] = new Vector2(100, 50);
            spawnLocation[1] = new Vector2(960, 50);
            spawnLocation[2] = new Vector2(960, 1025);
            spawnLocation[3] = new Vector2(100, 1025);
            spawnLocation[4] = new Vector2(1850, 50);
            spawnLocation[5] = new Vector2(1850, 1025);
            spawnLocation[6] = new Vector2(20, 540);
            spawnLocation[7] = new Vector2(1900, 540);

            offset[0] = 25;
            offset[1] = 0;
            offset[2] = 180;
            offset[3] = 140;
            offset[4] = -35;
            offset[5] = -135;
            offset[6] = 90;
            offset[7] = -90;



            this.Add(new SpriteGameObject("Background/spr_background"));

            this.Add(turretstands);
            this.Add(turrets);
            
            this.Add(mouse = new Mouse());
            this.Add(player = new Player(mouse));

         
            for (int i = 0; i < 8; i++)
            {
                turretstands.Add(new TurretStand(spawnLocation[i], offset[i]));
                turrets.Add(new Turret(spawnLocation[i], player));
                
            }
         
           
            

            this.Add(objectpool = new ObjectPool(new Vector2(0,0), new Vector2(0,0)));

        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            
        }
    }
}
