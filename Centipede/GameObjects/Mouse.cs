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
    class Mouse : SpriteGameObject
    {
        public Mouse() : base("Player/spr_mouse")
        {
            origin = Center;
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            position = inputHelper.MousePosition;
            base.HandleInput(inputHelper);
            
        }
    }
}
