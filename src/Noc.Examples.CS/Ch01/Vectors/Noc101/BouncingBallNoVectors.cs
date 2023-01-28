using Microsoft.Xna.Framework;

namespace Noc.Examples.CS.Ch01.Vectors.Noc101;

/// <summary>
/// The Nature of Code
/// Original code by Daniel Shiffman
/// C# code by Luciano Borges
/// http://natureofcode.com
///
/// Example 1-1: Bouncing SpriteBall, no vectors
/// </summary>
internal class BouncingBallNoVectors : Sketch
{
    private float x = 100;
    private float y = 100;
    private float xspeed = 2.5f;
    private float yspeed = 2f;

    protected override void ExecuteUpdate(GameTime gameTime)
    {
        // Add the current speed to the position.
        x += xspeed;
        y += yspeed;

        if (x is > Width or < 0)
        {
            xspeed *= -1;
        }
        if (y is > Height or < 0)
        {
            yspeed *= -1;
        }
    }

    protected override void ExecuteDraw(GameTime gameTime)
    {
        // Display circle at x position
        SpriteBall.Draw(x, y);
    }
}
