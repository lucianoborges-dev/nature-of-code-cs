using Microsoft.Xna.Framework;
using Noc.Examples.CS.Extensions;

namespace Noc.Examples.CS.Ch01.Vectors.Noc108;

/// <summary>
/// The Nature of Code
/// Original code by Daniel Shiffman
/// C# code by Luciano Borges
/// http://natureofcode.com
///
/// Example 1-8: Motion101 Acceleration
/// </summary>
internal class Mover
{
    private const float TopSpeed = 10f;
    private Vector2 _position;
    private Vector2 _velocity;
    private Vector2 _acceleration;
    private readonly float _width;
    private readonly float _height;

    public Mover(float width, float height)
    {
        _width = width;
        _height = height;

        _position = new Vector2(width / 2f, height / 2f);
        _velocity = new Vector2();
        _acceleration = new Vector2(-0.001f, 0.01f);
    }

    public void Update()
    {
        _velocity += _acceleration;
        Vector2Helper.Limit(ref _velocity, TopSpeed);
        _position += _velocity;
    }

    public void CheckEdges()
    {
        if (_position.X > _width)
        {
            _position.X = 0;
        }
        else if (_position.X < 0)
        {
            _position.X = _width;
        }

        if (_position.Y > _height)
        {
            _position.Y = 0;
        }
        else if (_position.Y < 0)
        {
            _position.Y = _height;
        }
    }

    public void Display(SpriteBall spriteBall)
    {
        spriteBall.Draw(_position);
    }
}