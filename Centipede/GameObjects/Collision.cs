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
    class Collision : GameObjectList
    {
        Player player;
        
       public Collision(Player player)
        {
            this.player = player;
           

        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            foreach (Bullet aBullet in ObjectPool.bullets.Children)
            {
                if (aBullet.enemy)
                {
                    if (aBullet.CollidesWith(player))
                    {
                        player.hp--;
                        aBullet.Reset();

                    }
                }
            }
            
        }

    }
}
