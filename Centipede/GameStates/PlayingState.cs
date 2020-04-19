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
   
        public static GameObjectList turrets = new GameObjectList();
        GameObjectList turretstands = new GameObjectList();

        public int randomstartrow;
        public int randomstartcolum;
        public int randomwidth;
        public int randomheight;

        Collision collision;
        ObjectPool objectpool;
        Player player;
        PlayerHandeling playercontrol;
        Mouse mouse;
        Level playingfield;


        public PlayingState()
        {
            randomstartrow = GameEnvironment.Random.Next(3, 11);
            randomstartcolum = GameEnvironment.Random.Next(3, 24);
            randomwidth = randomstartcolum + GameEnvironment.Random.Next(1, 4);
            randomheight = randomstartrow + GameEnvironment.Random.Next(1, 4);


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



            

           
            this.Add(playingfield = new Level(17, 30));
 
            playingfield.DrawMap(3, 3, 14, 27, GameEnvironment.Random.Next(0,7), false, true);
            playingfield.DrawMap(0, 0, 17, 3,9, false, false);
            playingfield.DrawMap(0, 26, 17, 30, 9, false, false);
            playingfield.DrawMap(0, 0, 3, 30, 9,false, false);
            playingfield.DrawMap(14, 0, 17, 30, 9, false, false);
            playingfield.DrawMap(randomstartrow, randomstartcolum, randomheight, randomwidth, GameEnvironment.Random.Next(7, 9),true, false);

            this.Add(turretstands);
            this.Add(turrets);
            this.Add(mouse = new Mouse());
            this.Add(player = new Player(mouse));
            this.Add(collision = new Collision(player));
            this.Add(playercontrol = new PlayerHandeling(player));


            for (int i = 0; i < 8; i++)
            {
                turretstands.Add(new TurretStand(spawnLocation[i], offset[i]));
                turrets.Add(new Turret(spawnLocation[i], player));
                
            }
         
           
            

            this.Add(objectpool = new ObjectPool(new Vector2(0,0), new Vector2(0,0), new Vector2(0,0)));

        }

         

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            foreach (Wall awall in Level.map)
            {

                if (awall.Sprite == awall.sprites[7] || awall.Sprite == awall.sprites[8])
                {
                    
                    if (awall.CollidesWith(player))
                    {
                        Console.WriteLine("owo1");
                        player.WallHit(awall.Position);
                        break;
                    }
                    else
                    {
                        player.up = false;
                        player.down = false;
                        player.left = false;
                        player.right = false;
                    }

                }
            }
         
            
        }
    }
}
