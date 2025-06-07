using Microsoft.Xna.Framework;
using Vector2 = System.Numerics.Vector2;

namespace Spaceship;

public class Asteroid
{
  private Vector2 Position = new Vector2(600, 300);
  private int Speed;
  readonly private int Radius = 59;

  public Asteroid(int speed)
  {
    Speed = speed;
  }

  public Vector2 GetPosition()
  {
    return new Vector2(Position.X - Radius, Position.Y - Radius);
  }
  public void Update(GameTime gameTime)
  {
    float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;
    Position.X -= Speed * dt;
  }
}
