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
    class TurretPattern
    {

        public static void Burst(Vector2 pos, Vector2 ad)
        {
            SoundEffect.MasterVolume = 0.05f;
            Centipede.AssetManager.PlaySound("Sound/BulletsSound");
            for (int i = 0; i < 5; i++)
            {
                ObjectPool.Spawner(pos, ad, -12 + (i*6), new Vector2(5,0), true);
            }
            
        }

        public static void Single(Vector2 pos, Vector2 ad)
        {
            SoundEffect.MasterVolume = 0.05f;
            Centipede.AssetManager.PlaySound("Sound/BulletsSound");
            ObjectPool.Spawner(pos, ad, 0, new Vector2(5, 0), true);
        }

        public static void Spray(Vector2 pos, Vector2 ad)
        {
            SoundEffect.MasterVolume = 0.05f;
            Centipede.AssetManager.PlaySound("Sound/BulletsSound");
            ObjectPool.Spawner(pos, ad, 0, new Vector2(5, 0), true);
        }



    }
}
