using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Spaceship;

public class Ship
{
  private const int Speed = 3;
  public Vector2 Position  = new Vector2(100, 100);
  public void ShipUpdate(GameTime gameTime)
  {
    KeyboardState kbState = Keyboard.GetState();
    if (kbState.IsKeyDown(Keys.Left))
    {
      Position.X -= Speed;
    }
    if (kbState.IsKeyDown(Keys.Right))
    {
      Position.X += Speed;
    }
    if (kbState.IsKeyDown(Keys.Up))
    {
      Position.Y -= Speed;
    }
    if (kbState.IsKeyDown(Keys.Down))
    {
      Position.Y += Speed;
    }
  }
}
