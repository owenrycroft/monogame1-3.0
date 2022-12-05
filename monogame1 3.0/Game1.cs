using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace monogame1_3._0
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D oneTexture;
        Texture2D twoTexture;
        Texture2D threeTexture;
        Texture2D fourTexture;
        Texture2D backGroundTexture,giraffeTexture,cheataTexture,treeTexture;
        Rectangle rectangle1,rectangle2,rectangle3,rectangle4,rectangleBackground,rectanglecheata,rectangletallthing,rectangletree;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
           
        }

        protected override void Initialize()
        { _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight = 500;
            // TODO: Add your initialization logic here
            rectangleBackground = new Rectangle(0, 0, _graphics.PreferredBackBufferWidth, _graphics.PreferredBackBufferHeight );
            rectangle1=new Rectangle(20,20,20,20);
            rectangle2=new Rectangle(40,40,20,20);
            rectangle3=new Rectangle(60,60,20,20);
            rectangle4 = new Rectangle(80, 80, 20, 20);
            rectanglecheata=new Rectangle(300,100,100,100);
            rectangletallthing=new Rectangle(500,50,100,150);
            rectangletree=new Rectangle(400,60,100,140);
                
                
                
                base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            // ballTexture = Content.Load<Texture2D>("ball");
            oneTexture = Content.Load<Texture2D>("one");
           twoTexture=Content.Load<Texture2D>("two");
            threeTexture = Content.Load<Texture2D>("three");
            fourTexture = Content.Load<Texture2D>("four");
            backGroundTexture = Content.Load < Texture2D>("background") ;
            cheataTexture = Content.Load<Texture2D>("cheata");
            giraffeTexture = Content.Load<Texture2D>("giraffe");
            treeTexture = Content.Load<Texture2D>("tree");

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();
            _spriteBatch.Draw(backGroundTexture, rectangleBackground, Color.White);
            _spriteBatch.Draw(oneTexture, rectangle1, Color.White);
            _spriteBatch.Draw(twoTexture, rectangle2, Color.White);
            _spriteBatch.Draw(threeTexture, rectangle3, Color.White);
            _spriteBatch.Draw(fourTexture, rectangle4, Color.White);
            _spriteBatch.Draw(treeTexture,rectangletree,Color.White);
            _spriteBatch.Draw(giraffeTexture,rectangletallthing,Color.White);
            _spriteBatch.Draw(cheataTexture,rectanglecheata,Color.White);
            _spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}