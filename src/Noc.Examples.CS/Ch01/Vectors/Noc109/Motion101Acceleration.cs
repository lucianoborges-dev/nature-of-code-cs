using Microsoft.Xna.Framework;

namespace Noc.Examples.CS.Ch01.Vectors.Noc109;

/// <summary>
/// The Nature of Code
/// Original code by Daniel Shiffman
/// C# code by Luciano Borges
/// http://natureofcode.com
///
/// Example 1-9: Motion101 Acceleration
/// </summary>
internal class Motion101Acceleration : Sketch
{
    private readonly Mover _mover = new(Width, Height);

    protected override void ExecuteUpdate(GameTime gameTime)
    {
        _mover.Update();
        _mover.CheckEdges();
    }

    protected override void ExecuteDraw(GameTime gameTime)
    {
        _mover.Display(SpriteBall);
    }
}
