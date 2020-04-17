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
     class ObjectPool : GameObjectList
     {
        public static GameObjectList bullets = new GameObjectList();
        

        public ObjectPool(Vector2 pos, Vector2 ad, Vector2 vel)
        {
            this.Add(bullets);

            for (int i = 0; i < 100; i++)
            {
                bullets.Add(new Bullet("Projectiles/Bullet", pos, ad, 0, false, vel, true));
                
            }
        }
        public static void Spawner(Vector2 pos, Vector2 ad, float offset, Vector2 vel, bool enemy)
        {

            foreach (Bullet aBullet in bullets.Children)
            {
                if (!aBullet.Visible && aBullet != null)
                {
                    aBullet.enemy = enemy;
                    Spawn(aBullet, pos, ad, offset, vel);
                    
                    return;
                }
            }







        }
        public static void Spawn(RotatingSpriteGameObject input, Vector2 pos, Vector2 ad, float offset, Vector2 vel)
        {
            
            input.Visible = true;
            input.Position = pos;
            input.AngularDirection = ad;
            input.Velocity = vel;
            input.Degrees += offset;
            
           




        }




    }
}
