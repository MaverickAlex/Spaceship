using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Spaceship;

public class Ship
{
  public static Vector2 DefaultPostion = new Vector2(640, 360);
  private Vector2 Position = DefaultPostion;
  private const int Speed = 180; // pixels per second
  public int Radius = 30;
  public void ShipUpdate(GameTime gameTime)
  {
    float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;

    KeyboardState kbState = Keyboard.GetState();
    if (kbState.IsKeyDown(Keys.Left) && Position.X > 0)
    {
      Position.X -= Speed * dt;
    }
    if (kbState.IsKeyDown(Keys.Right) && Position.X < 1280)
    {
      Position.X += Speed * dt;
    }
    if (kbState.IsKeyDown(Keys.Up) && Position.Y > 0)
    {
      Position.Y -= Speed * dt;
    }
    if (kbState.IsKeyDown(Keys.Down) && Position.Y < 720)
    {
      Position.Y += Speed * dt;
    }
  }
  public Vector2 GetPosition()
  {
    return new Vector2(Position.X - 34, Position.Y - 50);
  }
  public void SetPosition(Vector2 position)
  {
    Position = position;
  }
}
