using Microsoft.Xna.Framework;
using System;
using System.Runtime.CompilerServices;

namespace Noc.Examples.CS.Extensions;

public static class Vector2Extensions
{
    /// <summary>
    /// Compute the limit of the Vector
    /// </summary>
    /// <param name="vector"></param>
    /// <param name="limit"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Limit(ref this Vector2 vector, float limit)
    {
        if (vector.Length() > limit)
        {
            var factor = 1f / (vector.Length() / limit);
            vector.X *= factor;
            vector.Y *= factor;
        }
    }

    /// <summary>
    /// Ref: https://github.com/processing/p5.js/blob/v1.5.0/src/math/p5.Vector.js#L1980
    /// </summary>
    /// <param name="vector"></param>
    public static void Randomize(ref this Vector2 vector)
    {
        var angle = new Random().NextDouble() * Math.PI * 2d;
        vector.X = (float)Math.Cos(angle);
        vector.Y = (float)Math.Sin(angle);
    }

    /// <summary>
    /// Set the Magnitude/Length of the Vector
    /// </summary>
    /// <param name="vector"></param>
    /// <param name="length"></param>
    public static void SetMagnitude(ref this Vector2 vector, float length)
    {
        var angle = Math.Atan2(vector.Y, vector.X);
        vector.X = (float)Math.Cos(angle) * length;
        vector.Y = (float)Math.Sin(angle) * length;
    }

    /// <summary>
    /// Create a copy of the Vector
    /// </summary>
    /// <param name="vector"></param>
    /// <returns>A copy instace of the Vector</returns>
    public static Vector2 Copy(this Vector2 vector)
    {
        return new Vector2(vector.X, vector.Y);
    }
}