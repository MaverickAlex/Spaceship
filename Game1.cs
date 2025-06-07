using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Spaceship;

public class Game1 : Game
{
  private GraphicsDeviceManager _graphics;
  private SpriteBatch _spriteBatch;

  private Texture2D _shipSprite;
  private Texture2D _asteroidSprite;
  private Texture2D _spaceSprite;
  private SpriteFont _gameFont;
  private SpriteFont _timerFont;
  public Game1()
  {
    _graphics = new GraphicsDeviceManager(this);
    Content.RootDirectory = "Content";
    IsMouseVisible = true;
  }

  protected override void Initialize()
  {
    // TODO: Add your initialization logic here

    base.Initialize();
  }

  protected override void LoadContent()
  {
    _spriteBatch = new SpriteBatch(GraphicsDevice);

    _shipSprite = Content.Load<Texture2D>("ship");
    _asteroidSprite = Content.Load<Texture2D>("asteroid");
    _spaceSprite = Content.Load<Texture2D>("space");
    _gameFont = Content.Load<SpriteFont>("spaceFont");
    _timerFont = Content.Load<SpriteFont>("timerFont");
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

    // TODO: Add your drawing code here

    base.Draw(gameTime);
  }
}
