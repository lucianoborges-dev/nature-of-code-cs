using Microsoft.Xna.Framework;
using MonoGame;

namespace Noc.Examples.CS.Ch01.Vectors.Noc104;

/// <summary>
/// The Nature of Code
/// Original code by Daniel Shiffman
/// C# code by Luciano Borges
/// http://natureofcode.com
///
/// Example 1-4: Vector multiplication
/// </summary>
internal class VectorMultiplication : Sketch
{
    private readonly Vector2 _center = new(Width / 2, Height / 2);
    private Vector2 _mouse;

    public VectorMultiplication()
    {
        ClearColor = new Color(51, 51, 51);
    }

    protected override void ExecuteUpdate(GameTime gameTime)
    {
        // Multiplying a vector!  The vector is now half its original size (multiplied by 0.5).
        _mouse = (MousePosition - _center) * 0.5f;

        // Unlike html5 canvas, we can not translate and start drawing from (0, 0)
        // Hence, we need to push it back to right position and star drawing from center
        _mouse += _center;
    }

    protected override void ExecuteDraw(GameTime gameTime)
    {
        _spriteBatch.DrawLine(_center, _mouse, Color.White, 2f);
    }
}
