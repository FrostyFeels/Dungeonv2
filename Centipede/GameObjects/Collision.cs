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
        GameObjectList killList = new GameObjectList();
        
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

            foreach (Turret aTurret in PlayingState.turrets.Children)
            {
                foreach (Bullet aBullet in ObjectPool.bullets.Children)
                {
                    if(!aBullet.enemy)
                    {
                        if (aTurret.CollidesWith(aBullet))
                        {
                            aBullet.Reset();
                            aTurret.hp--;
                        }
                    }

                }
                if(aTurret.hp <= 0)
                {
                    killList.Add(aTurret);
                }

            }

            foreach (var aObject in killList.Children)
            {
                PlayingState.turrets.Remove(aObject);

            }
            
        }

    }
}
