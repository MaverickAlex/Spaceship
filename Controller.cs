using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace Spaceship;

public class Controller
{
  public List<Asteroid> asteroids = new List<Asteroid>();
  private double _timer = 2;

  public void Update(GameTime gameTime)
  {
    _timer -= gameTime.ElapsedGameTime.TotalSeconds;
    if (_timer <= 0)
    {
      asteroids.Add(new Asteroid(250));
      _timer = 2;
    }

    foreach (Asteroid asteroid in asteroids)
    {
      asteroid.Update(gameTime);
    }
  }

}
