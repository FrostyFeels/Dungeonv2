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
        

        public Level(int rows, int collums, String AssetName)
        {

            this.assetname = AssetName;
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
                    AddMap(x, y, assetname);
                }
            }

   
        }


        public void AddMap(int x, int y, String assetName)
        {
            map[x, y] = new Wall(assetName);
            map[x, y].Visible = false;
            map[x, y].Parent = this;
            map[x, y].Position = GetCellPosition(x, y);
        }

        public  void DrawMap(int startrow, int startcolum, int rows, int collums, String assetName)
        {

            for (int x = startcolum; x < collums; x++)
            {
                for (int y = startrow; y < rows; y++)
                {
                    map[x,y] = new Wall(assetName);
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
