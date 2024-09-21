using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Noc.Examples.CS.Ch02.Forces.Noc202;

/// <summary>
/// The Nature of Code
/// Original code by Daniel Shiffman
/// C# code by Luciano Borges
/// http://natureofcode.com
/// </summary>
internal class Forces : Sketch
{
    private readonly Mover _moverA = new(Width, Height, 200, 30, 10);
    private readonly Mover _moverB = new(Width, Height, 440, 30, 2);
    private readonly Vector2 _gravity = new(0, 0.1f);
    private readonly Vector2 _wind = new(0.1f, 0);

    protected override void ExecuteUpdate(GameTime gameTime)
    {
        _moverA.ApplyForce(_gravity);
        _moverB.ApplyForce(_gravity);

        var mouseState = Mouse.GetState();
        if (mouseState.RightButton == ButtonState.Pressed ||
           mouseState.LeftButton == ButtonState.Pressed)
        {
            _moverA.ApplyForce(_wind);
            _moverB.ApplyForce(_wind);
        }

        _moverA.Update();
        _moverA.CheckEdges();

        _moverB.Update();
        _moverB.CheckEdges();
    }

    protected override void ExecuteDraw(GameTime gameTime)
    {
        _moverA.Display(SpriteBall);
        _moverB.Display(SpriteBall);
    }
}
