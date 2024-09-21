using Microsoft.Xna.Framework;

namespace Noc.Examples.CS.Ch02.Forces.Noc201;

/// <summary>
/// The Nature of Code
/// Original code by Daniel Shiffman
/// C# code by Luciano Borges
/// http://natureofcode.com
/// </summary>
internal class Mover
{
    private const float Mass = 1f;
    private Vector2 _position;
    private Vector2 _velocity;
    private Vector2 _acceleration;
    private readonly float _width;
    private readonly float _height;

    public Mover(float width, float height)
    {
        _width = width;
        _height = height;

        _position = new Vector2(width / 2f, 30f);
        _velocity = new Vector2(0f, 0f);
        _acceleration = new Vector2(0f, 0f);
    }

    public void ApplyForce(Vector2 force)
    {
        var f = force / Mass;
        _acceleration += f;
    }

    public void Update()
    {
        _velocity += _acceleration;
        _position += _velocity;
        _acceleration *= 0;
    }

    public void CheckEdges()
    {
        if (_position.X > _width)
        {
            _position.X = _width;
            _velocity.X *= -1;
        }
        else if (_position.X < 0)
        {
            _velocity.X *= -1;
            _position.X = 0;
        }

        if (_position.Y > _height)
        {
            _velocity.Y *= -1;
            _position.Y = _height;
        }
    }

    public void Display(SpriteBall spriteBall)
    {
        spriteBall.Draw(_position);
    }
}