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
        
        public Bullet(String assetName, Vector2 position, Vector2 angulardirection, float offset,  bool visible) : base(assetName)
        {
            this.position = position;
            this.AngularDirection = angulardirection;
            origin = Center;
            this.visible = visible;
            offsetDegrees = 90;
            Degrees += offset;
            
        }


        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            if (visible)
            {
                position += AngularDirection * velocity.X;
            }

            
        }
    }
}
