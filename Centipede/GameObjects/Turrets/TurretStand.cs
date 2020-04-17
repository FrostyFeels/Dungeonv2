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
    class TurretStand : RotatingSpriteGameObject 
    {
        public TurretStand(Vector2 pos, int ad) : base("Turret/spr_turret_stand")
        {
            position = pos;
            offsetDegrees = ad;
            origin = Center;

        }

    }
}
