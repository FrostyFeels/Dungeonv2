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
        Score score;
        GameObjectList killList = new GameObjectList();
        
       public Collision(Player player, Score score)
        {
            this.player = player;
            this.score = score;
           
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            //Player/Bullet hitbox detection
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
            //Turret Bullet Hitbox
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
                            score.getScore++;
                        }
                    }

                }
                if(aTurret.hp <= 0)
                {
                    killList.Add(aTurret);
                }

            }

            foreach (Bullet abullet in ObjectPool.bullets.Children)
            {
                foreach (Wall awall in Level.map)
                {
                    
                    
                        if(awall.hitbox)
                        {

                            if (awall.CollidesWith(abullet))
                            {
                                abullet.Reset();
                            }
                        }
                    
           
                }

            }
       


         



            foreach (var aObject in killList.Children)
            {
                PlayingState.turrets.Remove(aObject);

            }
            
        }

    }
}
