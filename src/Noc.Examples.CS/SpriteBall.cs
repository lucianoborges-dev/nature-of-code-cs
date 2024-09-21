using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame;

namespace Noc.Examples.CS;

public sealed class SpriteBall
{
    private readonly Color _fillCollor = new(175, 175, 175);
    private readonly Color _strokeCollor = Color.Black;
    private readonly SpriteBatch _spriteBatch;

    public SpriteBall(SpriteBatch spriteBatch)
    {
        _spriteBatch = spriteBatch;
    }

    public void Draw(float x, float y)
    {
        Draw(new Vector2(x, y));
    }

    public void Draw(Vector2 position)
    {
        _spriteBatch.DrawCircle(position, 24f, 30, _fillCollor, 24f);
        _spriteBatch.DrawCircle(position, 24f, 30, _strokeCollor, 1f);
    }

    public void Draw(Vector2 position, float radius)
    {
        _spriteBatch.DrawCircle(position, 12f * radius, 30, _fillCollor, 12f * radius);
        _spriteBatch.DrawCircle(position, 12f * radius, 30, _strokeCollor, 1f);
    }
}