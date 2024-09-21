using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame;

namespace Noc.Examples.CS;

// TODO: consider to consolidate in a single Factor/Builder class

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

    public void Draw2(Vector2 position, float radius)
    {
        _spriteBatch.DrawCircle(position, radius, 30, _fillCollor, radius);
        _spriteBatch.DrawCircle(position, radius, 30, _strokeCollor, 2f);
    }
}

public sealed class SpriteRect
{
    private readonly Color _fillCollor = new(200, 200, 200);
    private readonly SpriteBatch _spriteBatch;

    public SpriteRect(SpriteBatch spriteBatch)
    {
        _spriteBatch = spriteBatch;
    }

    public void Draw(float x, float y, float w, float h)
    {
        var location = new Vector2(x, y);
        var size = new Vector2(w, h);

        _spriteBatch.FillRectangle(location, size, _fillCollor);
    }
}