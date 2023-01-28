using Microsoft.Xna.Framework;
using System;

namespace Noc.Examples.CS.Ch01.Vectors.Noc107;

/// <summary>
/// The Nature of Code
/// Original code by Daniel Shiffman
/// C# code by Luciano Borges
/// http://natureofcode.com
///
/// Example 1-7: Motion101
/// </summary>
internal class Mover
{
    private Vector2 _position;
    private Vector2 _velocity;
    private readonly float _width;
    private readonly float _height;

    public Mover(float width, float height)
    {
        _width = width;
        _height = height;

        var rand = new Random();
        _position = new Vector2(rand.Next((int)width), rand.Next((int)height));
        _velocity = new Vector2(rand.Next(-2, 2), rand.Next(-2, 2));
    }

    public void Update()
    {
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