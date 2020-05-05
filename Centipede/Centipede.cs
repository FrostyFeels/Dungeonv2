using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Audio;
using Centipede.GameStates;

namespace Centipede
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Centipede : GameEnvironment
    {
        Song song;
        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            screen = new Point(1920, 1080);
            ApplyResolutionSettings();
           
            gameStateManager.AddGameState("Start", new StartState());
            gameStateManager.AddGameState("Play", new PlayingState());         
            gameStateManager.AddGameState("End", new EndState());

            gameStateManager.SwitchTo("Start");

            this.song = Content.Load<Song>("Sound/BackGroundMusic");
            MediaPlayer.Volume = 0.05f;
            MediaPlayer.Play(song);
            MediaPlayer.IsRepeating = true;

            // TODO: use this.Content to load your game content here
        }
        
    }
}
