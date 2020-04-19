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
    class Single : Enemy
    {
        Player player;

        public Single(String assetName, Vector2 pos, Player player) : base(assetName, pos)
        {
            this.player = player;
            this.position = pos;


        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            if (velocity == Vector2.Zero)
            {
                reloadtimer++;
            }

            LookAt(player, 90);


            float xdistance = player.Position.X - Position.X;
            float ydistance = player.Position.Y - Position.Y;
            double distanceCenter = pythogoras(xdistance, ydistance);
            double SidetoSide = distanceCenter - player.radius;
            if (SidetoSide > 0)
            {
                MoveToPlayer(player.Position);

            }
            else velocity = new Vector2(0, 0);

            if (LoadShot())
            {
                TurretPattern.Single(position, AngularDirection);
            }


        }

    }
}

