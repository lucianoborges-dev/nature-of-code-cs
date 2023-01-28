using Microsoft.Xna.Framework;

namespace Noc.Examples.CS.Ch01.Vectors.Noc111;

/// <summary>
/// The Nature of Code
/// Original code by Daniel Shiffman
/// C# code by Luciano Borges
/// http://natureofcode.com
///
/// Example 1-11: Motion101 Acceleration
/// </summary>
internal class Motion101AccelerationArray : Sketch
{
    private readonly Mover[] _movers;

    public Motion101AccelerationArray()
    {
        _movers = new Mover[20];
        for (var i = 0; i < _movers.Length; i++)
        {
            _movers[i] = new(Width, Height);
        }
    }

    protected override void ExecuteUpdate(GameTime gameTime)
    {
        for (var i = 0; i < _movers.Length; i++)
        {
            _movers[i].Update(MousePosition);
        }
    }

    protected override void ExecuteDraw(GameTime gameTime)
    {
        for (var i = 0; i < _movers.Length; i++)
        {
            _movers[i].Display(SpriteBall);
        }
    }
}
