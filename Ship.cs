using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Spaceship;

public class Ship
{

  public Vector2 Position  = new Vector2(100, 100);
  public void ShipUpdate(GameTime gameTime)
  {
    KeyboardState kbState = Keyboard.GetState();
    if (kbState.IsKeyDown(Keys.Left))
    {
      Position.X -= 1;
    }
    if (kbState.IsKeyDown(Keys.Right))
    {
      Position.X += 1;
    }
    if (kbState.IsKeyDown(Keys.Up))
    {
      Position.Y -= 1;
    }
    if (kbState.IsKeyDown(Keys.Down))
    {
      Position.Y += 1;
    }
  }
}
