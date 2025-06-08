using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace Spaceship;

public class Controller
{
  public List<Asteroid> asteroids = new List<Asteroid>();
  private double _timer = 2;
  double _maxTime = 2;
  private int nextSpeed = 240;

  public bool InGame { get; set; } = false;

  public void Update(GameTime gameTime)
  {
    if (InGame)
    {
      _timer -= gameTime.ElapsedGameTime.TotalSeconds;
    }
    else
    {
      KeyboardState kbState = Keyboard.GetState();
      if (kbState.IsKeyDown(Keys.Enter))
      {
        InGame = true;
      }
    }

    if (_timer <= 0)
    {
      asteroids.Add(new Asteroid(nextSpeed));
      _timer = _maxTime;
      if (_maxTime > 0.5)
      {
        _maxTime -= 0.1;
      }

      if (nextSpeed < 720)
      {
        nextSpeed += 4;
      }
    }

    foreach (Asteroid asteroid in asteroids)
    {
      asteroid.Update(gameTime);
    }
  }

}
