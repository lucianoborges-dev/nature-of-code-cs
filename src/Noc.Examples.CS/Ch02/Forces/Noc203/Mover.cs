using Microsoft.Xna.Framework;

namespace Noc.Examples.CS.Ch02.Forces.Noc203;

/// <summary>
/// The Nature of Code
/// Original code by Daniel Shiffman
/// C# code by Luciano Borges
/// http://natureofcode.com
/// </summary>
internal class Mover
{
    private Vector2 _position;
    private Vector2 _velocity;
    private Vector2 _acceleration;
    private readonly float _width;
    private readonly float _height;
    private readonly float _mass;
    private readonly float _radius;

    public float Mass => _mass;  

    public Mover(float width, float height, float x, float y, float mass)
    {
        _width = width;
        _height = height;
        _mass = mass;
        _radius = mass * 8f;

        _position = new Vector2(x, y);
        _velocity = new Vector2(0f, 0f);
        _acceleration = new Vector2(0f, 0f);
    }

    public void ApplyForce(Vector2 force)
    {
        var f = force / _mass;
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
        if (_position.X > _width - _radius)
        {
            _position.X = _width - _radius;
            _velocity.X *= -1;
        }
        else if (_position.X < _radius)
        {
            _position.X = _radius;
            _velocity.X *= -1;
        }

        if (_position.Y > _height - _radius)
        {
            _position.Y = _height - _radius;
            _velocity.Y *= -1;
        }
    }

    public void Display(SpriteBall spriteBall)
    {
        spriteBall.Draw(_position, _mass);
    }
}