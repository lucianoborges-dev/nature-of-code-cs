using Microsoft.Xna.Framework;
using MonoGame;

namespace Noc.Examples.CS.Ch01.Vectors.Noc103;

/// <summary>
/// The Nature of Code
/// Original code by Daniel Shiffman
/// C# code by Luciano Borges
/// http://natureofcode.com
///
/// Example 1-3: Vector subtraction
/// </summary>
internal class VectorSubtraction : Sketch
{
    private readonly Vector2 _center = new(Width / 2, Height / 2);
    private Vector2 _mouse;

    public VectorSubtraction()
    {
        ClearColor = new Color(51, 51, 51);
    }

    protected override void ExecuteUpdate(GameTime gameTime)
    {
        _mouse = MousePosition;
    }

    protected override void ExecuteDraw(GameTime gameTime)
    {
        _spriteBatch.DrawLine(_center, _mouse, Color.White, 2f);
    }
}
