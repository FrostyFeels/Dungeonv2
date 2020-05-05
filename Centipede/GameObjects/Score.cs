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
    class Score : TextGameObject
    {
        protected int score;
        public Score() : base("GameFont")
        {
            position.X = 250;
            position.Y = 100;
        }


        public override void Reset()
        {
            base.Reset();
            score = 0;
        }

        public override void Update(GameTime gameTime)
        {

            this.Text = score.ToString();


        }

        public int getScore
        {
            get { return score; }
            set { score = value; }
        }

    }
}
