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
    
    class Wall : SpriteGameObject
    {
        SpriteSheet[] sprites;
 
        public Wall(int i) : base("Background/spr_fill_01")
        {
            sprites = new SpriteSheet[10];
            sprites[0] = new SpriteSheet("Background/spr_fill_01");
            sprites[1] = new SpriteSheet("Background/spr_fill_01");
            sprites[2] = new SpriteSheet("Background/spr_fill_01");
            sprites[3] = new SpriteSheet("Background/spr_fill_01");
            sprites[4] = new SpriteSheet("Background/spr_fill_01");
            sprites[5] = new SpriteSheet("Background/spr_fill_02");
            sprites[6] = new SpriteSheet("Background/spr_fill_03");
            sprites[7] = new SpriteSheet("Background/spr_wall_01");
            sprites[8] = new SpriteSheet("Background/spr_wall_02");
            sprites[9] = new SpriteSheet("Background/spr_fill_roof_02");

            sprite = sprites[i];

        }


    }
}
