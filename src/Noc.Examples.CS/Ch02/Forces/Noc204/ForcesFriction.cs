using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Noc.Examples.CS.Ch02.Forces.Noc204;

/// <summary>
/// The Nature of Code
/// Original code by Daniel Shiffman
/// C# code by Luciano Borges
/// http://natureofcode.com
/// </summary>
internal class ForcesFriction : Sketch
{
    private readonly Mover _mover = new(Width, Height, 200, 30, 10);
    private readonly Vector2 _gravity = new(0, 0.1f);
    private readonly Vector2 _wind = new(0.1f, 0);

    protected override void ExecuteUpdate(GameTime gameTime)
    {
        // I should scale by mass to be more accurate, but this example only has one circle
        _mover.ApplyForce(_gravity);

        var mouseState = Mouse.GetState();
        if (mouseState.RightButton == ButtonState.Pressed ||
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
