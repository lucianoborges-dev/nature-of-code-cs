using Microsoft.Xna.Framework;

namespace Noc.Examples.CS.Ch01.Vectors.Noc107;

/// <summary>
/// The Nature of Code
/// Original code by Daniel Shiffman
/// C# code by Luciano Borges
/// http://natureofcode.com
///
/// Example 1-7: Motion101
/// </summary>
internal class Motion101 : Sketch
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
