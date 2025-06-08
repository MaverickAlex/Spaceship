using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Linq;

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

  Ship player = new Ship();
  Controller gameController = new Controller();
  public Game1()
  {
    _graphics = new GraphicsDeviceManager(this);
    Content.RootDirectory = "Content";
    IsMouseVisible = true;
  }

  protected override void Initialize()
  {
    _graphics.PreferredBackBufferWidth = 1280;
    _graphics.PreferredBackBufferHeight = 720;
    _graphics.ApplyChanges();
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

    if (gameController.InGame)
    {
      player.ShipUpdate(gameTime);
    }

    gameController.Update(gameTime);
    foreach (Asteroid asteroid in gameController.asteroids.ToList())
    {
      asteroid.Update(gameTime);
      int sum = asteroid.Radius + player.Radius;
      if (Vector2.Distance(asteroid.GetPosition(), player.GetPosition()) < sum)
      {
        gameController.InGame = false;
        player.SetPosition(Ship.DefaultPostion);
        gameController.asteroids.Clear();
      }
    }
    base.Update(gameTime);
  }

  protected override void Draw(GameTime gameTime)
  {
    GraphicsDevice.Clear(Color.CornflowerBlue);

    _spriteBatch.Begin();
    _spriteBatch.Draw(_spaceSprite, new Vector2(0, 0), Color.White);
    _spriteBatch.Draw(_shipSprite,  player.GetPosition(), Color.White);
    foreach (Asteroid asteroid in gameController.asteroids)
    {
      _spriteBatch.Draw(_asteroidSprite, asteroid.GetPosition(), Color.White);
    }

    if (!gameController.InGame)
    {
      string message = "Press Enter to Begin!";
      Vector2 sizeOfText = _gameFont.MeasureString(message);
      int halfWidth = _graphics.PreferredBackBufferWidth / 2;
      Vector2 messagePosition = new Vector2(halfWidth - sizeOfText.X/2, 200);
      _spriteBatch.DrawString(_gameFont, message, messagePosition, Color.White);
    }

    _spriteBatch.End();

    base.Draw(gameTime);
  }
}
