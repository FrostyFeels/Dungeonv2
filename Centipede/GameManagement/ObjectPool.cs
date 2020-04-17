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
        static GameObjectList bullets = new GameObjectList();
        

        public ObjectPool(Vector2 pos, Vector2 ad)
        {
            this.Add(bullets);

            for (int i = 0; i < 100; i++)
            {
                bullets.Add(new Bullet("Projectiles/Bullet", pos, ad, false));
                
            }
        }
        public static void Spawner(Vector2 pos, Vector2 ad)
        {

            foreach (Bullet aBullet in bullets.Children)
            {
                if (!aBullet.Visible && aBullet != null)
                {
                    Spawn(aBullet, pos, ad);
                    return;
                }
            }







        }
        public static void Spawn(RotatingSpriteGameObject input, Vector2 pos, Vector2 ad)
        {
            
            input.Visible = true;
            input.Position = pos;
            input.AngularDirection = ad;
            input.Velocity = new Vector2(5, 0);
           




        }




    }
}
