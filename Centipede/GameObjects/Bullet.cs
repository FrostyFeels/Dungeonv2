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
    class Bullet : RotatingSpriteGameObject
    {
        public bool enemy;

        public SpriteSheet[] sprites;

        public Bullet(String assetName, Vector2 position, Vector2 angulardirection, float offset, bool visible, Vector2 vel, bool enemy, int i) : base(assetName)
        {
            sprites = new SpriteSheet[2];
            sprites[0] = new SpriteSheet("Projectiles/Bullet");
            sprites[1] = new SpriteSheet("Player/spr_player_bullets");

            this.position = position;
            this.AngularDirection = angulardirection;
            origin = Center;
            this.visible = visible;
            offsetDegrees = 90;
            Degrees += offset;
            velocity = vel;
            this.enemy = enemy;

            sprite = sprites[i];
            
        }

        public override void Reset()
        {
            base.Reset();
            visible = false;
            position.X = -1000;
            velocity = Vector2.Zero;
        }


        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            if (visible)
            {
                position += AngularDirection * velocity.X;
            }


            if(visible)
            {
                if(position.X + Width < 0 || position.X > GameEnvironment.Screen.X || position.Y + Height < 0 || position.Y > GameEnvironment.Screen.Y)
                {
                    Reset();
                }
            }

            
        }
    }
}
