using Microsoft.Xna.Framework;

namespace Noc.Examples.CS.Ch01.Vectors.Noc102;

/// <summary>
/// The Nature of Code
/// Original code by Daniel Shiffman
/// C# code by Luciano Borges
/// http://natureofcode.com
///
/// Example 1-2: Bouncing SpriteBall, with vectors
/// </summary>
internal class BouncingBallVectors : Sketch
{
    private Vector2 position = new(100f);
    private Vector2 velocity = new(2.5f, 5f);

    protected override void ExecuteUpdate(GameTime gameTime)
    {
        // Add the current speed to the position.
        position += velocity;

        if (position.X is > Width or < 0)
        {
            velocity.X *= -1;
        }
        if (position.Y is > Height or < 0)
        {
            velocity.Y *= -1;
        }
    }

    protected override void ExecuteDraw(GameTime gameTime)
    {
        // Display circle at x position
        SpriteBall.Draw(position);
    }
}