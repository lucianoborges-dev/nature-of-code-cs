using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame;

namespace Noc.Examples.CS;

public sealed class SpriteBall
{
    private readonly Color _fillCollor = new(175, 175, 175);
    private readonly Color _strokeCollor = Color.Black;
    private readonly SpriteBatch _spriteBatch;
    private readonly Texture2D _ball;
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
        _spriteBatch.DrawCircle(position, 24, 30, _fillCollor, 24f);
        _spriteBatch.DrawCircle(position, 24, 30, _strokeCollor, 1f);
    }
}