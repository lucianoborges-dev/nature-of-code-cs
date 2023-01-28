using Microsoft.Xna.Framework;
using System;
using System.Runtime.CompilerServices;

namespace Noc.Examples.CS.Extensions;

internal static class Vector2Helper
{
    /// <summary>
    /// Compute the limit of the Vector
    /// </summary>
    /// <param name="vector"></param>
    /// <param name="limit"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Limit(ref Vector2 vector, float limit)
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
    public static void Randomize(ref Vector2 vector)
    {
        var angle = new Random().NextDouble() * Math.PI * 2d;
        vector.X = (float)Math.Cos(angle);
        vector.Y = (float)Math.Sin(angle);
    }

    /// <summary>
    /// Set the Magnitude of the Vector
    /// </summary>
    /// <param name="vector"></param>
    /// <param name="length"></param>
    public static void SetMagnitude(ref Vector2 vector, float length)
    {
        var angle = Math.Atan2(vector.Y, vector.X);
        vector.X = (float)Math.Cos(angle) * length;
        vector.Y = (float)Math.Sin(angle) * length;
    }
}
