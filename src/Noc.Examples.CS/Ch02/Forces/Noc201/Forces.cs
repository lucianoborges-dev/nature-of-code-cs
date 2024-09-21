using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Noc.Examples.CS.Ch02.Forces.Noc201;

/// <summary>
/// The Nature of Code
/// Original code by Daniel Shiffman
/// C# code by Luciano Borges
/// http://natureofcode.com
/// </summary>
internal class Forces : Sketch
{
    private readonly Mover _mover = new(Width, Height);
    private readonly Vector2 _gravity = new(0, 0.1f);
    private readonly Vector2 _wind = new(0.1f, 0);

    protected override void ExecuteUpdate(GameTime gameTime)
    {
        _mover.ApplyForce(_gravity);

        var mouseState = Mouse.GetState();
        if(mouseState.RightButton == ButtonState.Pressed ||
           mouseState.LeftButton == ButtonState.Pressed)
        {
            _mover.ApplyForce(_wind);
        }

        _mover.Update();
        _mover.CheckEdges();
    }

    protected override void ExecuteDraw(GameTime gameTime)
    {
        _mover.Display(SpriteBall);
    }
}
