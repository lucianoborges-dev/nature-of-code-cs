using Microsoft.Xna.Framework;

namespace Noc.Examples.CS.Ch02.Forces.Noc205;

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

    public float Mass => _mass;
    public Vector2 Position => _position;
    public Vector2 Velocity => _velocity;

    // Newton's 2nd law: F = M * A
    // or A = F / M
    public void ApplyForce(Vector2 force)
    {
        var f = force / _mass;
        _acceleration += f;
    }

    public void Update()
    {
        // Velocity changes according to acceleration
        _velocity += _acceleration;
        // position changes by velocity
        _position += _velocity;
        // We must clear acceleration each frame
        _acceleration *= 0;
    }

    // Bounce off bottom of window
    public void CheckEdges()
    {
        if (_position.Y > _height - _radius)
        {
            _velocity.Y *= -0.9f; // A little dampening when hitting the bottom
            _position.Y = _height - _radius;
        }
    }

    public void Display(SpriteBall spriteBall)
    {
        spriteBall.Draw2(_position, _radius);
    }
}