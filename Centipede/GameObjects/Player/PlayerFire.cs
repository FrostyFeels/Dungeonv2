using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Audio;

namespace Centipede
{
    class PlayerFire
    {
        
        

        public static void Fire(Vector2 pos, Vector2 ad, Vector2 vel)
        {
            SoundEffect.MasterVolume = 0.05f;

            if (PlayerWeapons.shotgun)
            {
                Centipede.AssetManager.PlaySound("Sound/BulletsSound");
                for (int i = 0; i < 5; i++)
                {
                    ObjectPool.Spawner(pos, ad, -12 + i * 6, vel, false);
                    Console.WriteLine("Shotgun baby");
                    
                }
                
            }
            else
            {
                Centipede.AssetManager.PlaySound("Sound/BulletsSound");
                ObjectPool.Spawner(pos, ad, PlayerWeapons.offsetAngle, vel, false);
               

            }
        }
    }
}
