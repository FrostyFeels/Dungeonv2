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
        Player player;
        public PlayingState()
        {
            this.Add(new SpriteGameObject("Background/spr_background"));
            this.Add(player = new Player());
        }
    }
}
