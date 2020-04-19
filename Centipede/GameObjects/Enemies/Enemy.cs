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
    class Enemy : RotatingSpriteGameObject
    {
        public int reloadtimer;
        public int reloadtime = 90;
        public Enemy(String assetName, Vector2 pos) : base(assetName)
        {
            position = pos;


        }


        public void MoveToPlayer(Vector2 pos)
        {
            if (position.X > pos.X + 25)
            {
                velocity.X = -100;
            }
            else velocity.X = 100;

            if (position.Y > pos.Y + 25)
            {
                velocity.Y = -100;
            }
            else velocity.Y = 100;
        }

        public bool LoadShot()
        {

            if (reloadtime < reloadtimer)
            {
                reloadtimer = 0;
                return true;
            }

            return false;
        }

        public double pythogoras(float xDiff, float yDiff)
        {

            float Xsqrd = xDiff * xDiff;
            float Ysqrd = yDiff * yDiff;
            float diff = Xsqrd + Ysqrd;

            double answer = Math.Sqrt(diff);
            return answer;

        }
    }
}
