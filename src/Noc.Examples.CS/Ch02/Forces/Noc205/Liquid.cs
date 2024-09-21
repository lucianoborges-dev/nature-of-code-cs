using Microsoft.Xna.Framework;
using Noc.Examples.CS.Extensions;

namespace Noc.Examples.CS.Ch02.Forces.Noc205;

/// <summary>
/// The Nature of Code
/// Original code by Daniel Shiffman
/// C# code by Luciano Borges
/// http://natureofcode.com
/// </summary>
internal class Liquid
{
    private readonly float _x;
    private readonly float _y;
    private readonly float _w;
    private readonly float _h;
    private readonly float _c;

    public Liquid(float x, float y, float w, float h, float c)
    {
        _x = x;
        _y = y;
        _w = w;
        _h = h;
        _c = c;
    }

    public bool Contains(Mover mover)
    {
        var l = mover.Position;
        return l.X > _x
            && l.X < _x + _w
            && l.Y > _y
            && l.Y < _y + _h;
    }

    public Vector2 CalculateDrag(Mover mover)
    {
        // Magnitude is coefficient * speed squared
        var speed = mover.Velocity.Length(); // Magnitute
        var dragMagnitude = _c * speed * speed;

        // Direction is inverse of velocity
        var dragForce = mover.Velocity.Copy();
        dragForce *= -1;

        // Scale according to magnitude
        // dragForce.setMag(dragMagnitude);
        dragForce.Normalize();
        dragForce *= dragMagnitude;

        return dragForce;
    }

    public void Display(SpriteRect spriteRect)
    {
        spriteRect.Draw(_x, _y, _w, _h);
    }
}