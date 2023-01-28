using Microsoft.Xna.Framework;
using MonoGame;

namespace Noc.Examples.CS.Ch01.Vectors.Noc106;

/// <summary>
/// The Nature of Code
/// Original code by Daniel Shiffman
/// C# code by Luciano Borges
/// http://natureofcode.com
///
/// Example 1-6: Motion101 Acceleration
/// 
/// Demonstration of normalizing a vector.
/// Normalizing a vector sets its length to 1.
/// 
/// </summary>
internal class VectorNormalize : Sketch
{
    // A vector that points to the center of the window
    private readonly Vector2 _center = new(Width / 2, Height / 2);

    // A vector that points to the mouse position
    private Vector2 _mouse;

    public VectorNormalize()
    {
        ClearColor = new Color(51, 51, 51);
    }

    protected override void ExecuteUpdate(GameTime gameTime)
    {
        // Subtract center from mouse which results in a vector that points from center to mouse
        _mouse = MousePosition - _center;

        // Normalize the vector
        _mouse.Normalize();

        // Multiply its length by 50
        _mouse *= 150f;

        // Unlike html5 canvas, we can not translate and start drawing from (0, 0)
        // Hence, we need to push it back to right position and star drawing from center
        _mouse += _center;
    }

    protected override void ExecuteDraw(GameTime gameTime)
    {
        _spriteBatch.DrawLine(_center, _mouse, Color.White, 2f);
    }
}
