using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Noc.Examples.CS.Ch02.Forces.Noc205;

/// <summary>
/// The Nature of Code
/// Original code by Daniel Shiffman
/// C# code by Luciano Borges
/// http://natureofcode.com
/// 
/// Forces (Gravity and Fluid Resistence) with Vectors
/// Demonstration of multiple force acting on bodies (Mover class)
/// Bodies experience gravity continuously
/// Bodies experience fluid resistance when in "water"
/// Five moving bodies
/// </summary>
internal class ForcesDrag : Sketch
{
    private readonly Liquid _liquid = new(0, Height / 2, Width, Height / 2, 0.1f);
    private readonly List<Mover> _movers = new();

    public ForcesDrag()
    {
        Reset();

        //createP("click mouse to reset");
    }

    private void Reset()
    {
        var random = new Random();
        _movers.Clear();
        for (var i = 0; i < 9; i++)
        {
            var x = 40 + i * 70;
            var y = 0;
            var mass = random.NextSingle() * (3f - 0.5f) + 0.5f;

            _movers.Add(new Mover(Width, Height, x, y, mass));
        }
    }

    protected override void ExecuteUpdate(GameTime gameTime)
    {
        var mouseState = Mouse.GetState();
        if (mouseState.RightButton == ButtonState.Pressed ||
            mouseState.LeftButton == ButtonState.Pressed)
        {
            Reset();
        }

        foreach (var mover in _movers)
        {
            // Is the Mover in the liquid?
            if (_liquid.Contains(mover))
            {
                // Calculate drag force
                var dragForce = _liquid.CalculateDrag(mover);
                // Apply drag force to Mover
                mover.ApplyForce(dragForce);
            }

            // Gravity is scaled by mass here!
            var gravity = new Vector2(0, 0.1f * mover.Mass);
            // Apply gravity
            mover.ApplyForce(gravity);

            // Update and display
            mover.Update();
            mover.CheckEdges();
        }
    }

    protected override void ExecuteDraw(GameTime gameTime)
    {
        _liquid.Display(SpriteRect);

        foreach (var mover in _movers)
        {
            mover.Display(SpriteBall);
        }
    }
}
