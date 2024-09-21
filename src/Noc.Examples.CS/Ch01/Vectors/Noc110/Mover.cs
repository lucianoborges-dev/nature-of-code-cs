using Microsoft.Xna.Framework;
using Noc.Examples.CS.Extensions;
using System;

namespace Noc.Examples.CS.Ch01.Vectors.Noc110;

/// <summary>
/// The Nature of Code
/// Original code by Daniel Shiffman
/// C# code by Luciano Borges
/// http://natureofcode.com
///
/// Example 1-10: Motion101 Acceleration
/// </summary>
internal class Mover
{
    private const float TopSpeed = 5f;
    private Vector2 _position;
    private Vector2 _velocity;
    private Vector2 _acceleration;

    public Mover(float width, float height)
    {
        _position = new Vector2(width / 2f, height / 2f);
        _velocity = new Vector2();
        _acceleration = new Vector2();
    }

    public void Update(Vector2 mousePosition)
    {
        // Compute a vector that points from position to mouse
        _acceleration = Vector2.Subtract(mousePosition, _position);

        // Set magnitude of acceleration
        //Vector2Helper.SetMagnitude(ref _acceleration, 0.2f);
        _acceleration.SetMagnitude(0.2f);

        _velocity += _acceleration;
        //Vector2Helper.Limit(ref _velocity, TopSpeed);
        _velocity.Limit(TopSpeed);

        _position += _velocity;
    }

    public void Display(SpriteBall spriteBall)
    {
        spriteBall.Draw(_position);
    }
}