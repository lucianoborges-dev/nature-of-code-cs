using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Noc.Examples.CS;

internal abstract class Sketch : Game
{
    protected const int Width = 640;
    protected const int Height = 360;

    private readonly GraphicsDeviceManager _graphics;
    protected SpriteBatch _spriteBatch;

    protected Vector2 MousePosition;
    protected SpriteBall SpriteBall;
    protected SpriteRect SpriteRect;

    protected Sketch()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        _graphics.PreferredBackBufferWidth = Width;
        _graphics.PreferredBackBufferHeight = Height;
        _graphics.ApplyChanges();
        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);
        SpriteBall = new SpriteBall(_spriteBatch);
        SpriteRect = new SpriteRect(_spriteBatch);
    }

    protected override void Update(GameTime gameTime)
    {
        if (Keyboard.GetState().IsKeyDown(Keys.Escape))
        {
            Exit();
        }
        MousePosition = Mouse.GetState().Position.ToVector2();
        ExecuteUpdate(gameTime);
        base.Update(gameTime);
    }

    protected Color ClearColor { get; set; } = Color.WhiteSmoke;

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(ClearColor);

        _spriteBatch.Begin();
        ExecuteDraw(gameTime);
        _spriteBatch.End();

        base.Draw(gameTime);
    }

    protected abstract void ExecuteUpdate(GameTime gameTime);
    protected abstract void ExecuteDraw(GameTime gameTime);
}
