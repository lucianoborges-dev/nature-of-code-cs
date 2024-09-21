using Microsoft.Xna.Framework;

namespace Noc.Examples.CS.Ch01.Vectors.Noc102;

/// <summary>
/// The Nature of Code
/// Original code by Daniel Shiffman
/// C# code by Luciano Borges
/// http://natureofcode.com
///
/// Example 1-1: Bouncing SpriteBall, with vectors
/// </summary>
internal class BouncingBallVectorsObject : Sketch
{
    private readonly Ball _ball = new(Width, Height);
    protected override void ExecuteUpdate(GameTime gameTime) => _ball.Update();
    protected override void ExecuteDraw(GameTime gameTime) => _ball.Draw(SpriteBall);
}

internal class Ball
{
    private Vector2 position = new(100f);
    private Vector2 velocity = new(2.5f, 5f);
    private readonly float _width;
    private readonly float _height;

    public Ball(float width, float height)
    {
        _width = width;
        _height = height;
    }

    public void Update()
    {
        // Add the current speed to the position.
        position += velocity;

        if (position.X > _width || position.X < 0)
        {
            velocity.X *= -1;
        }
        if (position.Y > _height || position.Y < 0)
        {
            velocity.Y *= -1;
        }
    }

    public void Draw(SpriteBall spriteBall)
    {
        // Display circle at x position
        spriteBall.Draw(position);
    }
}