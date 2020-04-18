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
        public Vector2 truePlayer;
        public Vector2 trueWall;
        Mouse Mouse;
        public float speed = 300f;
        public int hp = 11113;
        public bool right, left, up, down = false;

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

        public void WallHit(Vector2 wallPos)
        {


            Vector2 walloffset = Vector2.One * (32);
            Vector2 playerOffset = Vector2.One * (25);

            Vector2 playerPos = new Vector2(position.X, position.Y);

            Console.WriteLine(playerPos);

            trueWall = (wallPos);
            truePlayer = (playerPos - origin);

            Vector2 simple = (truePlayer - trueWall);

            Vector2 truePos = (simple / (Vector2.One * 57f));

            if (Math.Abs(simple.X) < Math.Abs(simple.Y))
            {
                // above or below
                if (truePos.Y > 0)
                {
                    Console.WriteLine("above");
                    up = true;

                }
                else if (truePos.Y < 0)
                {
                    Console.WriteLine("bellow");
                    down = true;


                }




            }
            else
            {
                //it's left or right
                if (truePos.X < 0)
                {
                    Console.WriteLine("right");
                    right = true;

                }
                else if (truePos.X > 0)
                {
                    Console.WriteLine("left");
                    left = true;

                }

            }





        }
    }
}
