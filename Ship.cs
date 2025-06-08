using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Spaceship;

public class Ship
{
  public static Vector2 DefaultPostion = new Vector2(640, 360);
  private const int Speed = 180; // pixels per second
  private Vector2 Position = DefaultPostion;
  public void ShipUpdate(GameTime gameTime)
  {
    float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;

    KeyboardState kbState = Keyboard.GetState();
    if (kbState.IsKeyDown(Keys.Left))
    {
      Position.X -= Speed * dt;
    }
    if (kbState.IsKeyDown(Keys.Right))
    {
      Position.X += Speed * dt;
    }
    if (kbState.IsKeyDown(Keys.Up))
    {
      Position.Y -= Speed * dt;
    }
    if (kbState.IsKeyDown(Keys.Down))
    {
      Position.Y += Speed * dt;
    }
  }
  public Vector2 GetPosition()
  {
    return new Vector2(Position.X - 34, Position.Y - 50);
  }
}
