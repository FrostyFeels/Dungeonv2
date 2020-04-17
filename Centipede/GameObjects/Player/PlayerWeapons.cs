using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centipede
{
    class PlayerWeapons
    {
        public static int firerate = 15;
        public static int offsetAngle = 0;
        public static float dmg = 1;
        public static bool shotgun = false;

        public static void Pistol()
        {
            shotgun = false;
            firerate = 15;
            dmg = 1;
            offsetAngle = 0;
            
        }
        public static void Shotgun()
        {
            shotgun = true;
            firerate = 30;
            dmg = 0.3f; ;
            offsetAngle = GameEnvironment.Random.Next(-12, 12);

        }
        public static void Sniper()
        {
            shotgun = false;
            firerate = 45;
            dmg = 8;
            offsetAngle = 0;

        }
        public static void SemiAuto()
        {
            shotgun = false;
            firerate = 5;
            dmg = 0.4f;
            offsetAngle = 0;

        }

    }
}
