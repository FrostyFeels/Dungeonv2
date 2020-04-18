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
    
    class Level : GameObject
    {
        static Wall[,] map;
        int rows;
        int collums;

        Vector2 cellSize;
        String assetname;
        

        public Level(int rows, int collums)
        {

          
            this.rows = rows;
            this.collums = collums;
         
            cellSize = new Vector2(64, 64);
            Reset();
            
        }

   

        public override void Reset()
        {
            map = new Wall[collums, rows];

            for (int x = 0; x < collums; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    AddMap(x, y, 0);
                }
            }

   
        }


        public void AddMap(int x, int y, int i)
        {
            map[x, y] = new Wall(i);
            map[x, y].Visible = false;
            map[x, y].Parent = this;
            map[x, y].Position = GetCellPosition(x, y);
        }

        public  void DrawMap(int startrow, int startcolum, int rows, int collums, int i)
        {

            for (int x = startcolum; x < collums; x++)
            {
                for (int y = startrow; y < rows; y++)
                {
                    if((x == 2 && y > 1 && y < 15) || (y == 2 && x > 1 && x < 27) || (x == 26 && y < 15 && y > 2) || (y == 14 && x > 1 && x < 27) )
                    {
                        map[x, y] = new Wall(GameEnvironment.Random.Next(7,9));
                    } else { map[x, y] = new Wall(i);  }
                    
                    map[x, y].Visible = true;
                    map[x, y].Parent = this;
                    map[x, y].Position = GetCellPosition(x, y);

                }
            }
   

        }




        public override void Update(GameTime gameTime)
        {
            foreach (Wall wall in map)
                wall.Update(gameTime);
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            foreach (Wall wall in map)
                wall.Draw(gameTime, spriteBatch);
        }



        public Vector2 GetCellPosition(int x, int y)
        {
            return new Vector2(x * cellSize.X, y * cellSize.Y);

        }
    }
}
