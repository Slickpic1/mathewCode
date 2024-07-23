global using Microsoft.Xna.Framework;
global using Microsoft.Xna.Framework.Graphics;
global using Microsoft.Xna.Framework.Input;
global using Microsoft.Xna.Framework.Content;
global using System.Collections.Generic;


namespace StarWarsConquest;

class Game1 : Game
{
    private SpriteBatch spriteBatch;
    private GraphicsDeviceManager graphics;
    private GameManager gameManager;

    public Game1()
    {
        graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
        gameManager = new GameManager(graphics);
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();
    }

    protected override void LoadContent()
    {
        spriteBatch = new SpriteBatch(GraphicsDevice);
        
        // TODO: use this.Content to load your game content here
        gameManager.Load(Content);
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        // TODO: Add your update logic here
        gameManager.Update(gameTime);
        base.Update(gameTime);
    }

    // protected override void Draw(GameTime gameTime)
    // {
    //     GraphicsDevice.Clear(Color.CornflowerBlue); // Background color can be changed here

    //     // TODO: Add your drawing code here
    //     _spriteBatch.Begin(samplerState:SamplerState.PointClamp);
    //     _spriteBatch.Draw(ship, position, Color.White);
    //     _spriteBatch.End();

    //     base.Draw(gameTime);
    // }

    protected override void Draw(GameTime gameTime) // from Nick's Code
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        // TODO: Add your drawing code here
        spriteBatch.Begin(samplerState: SamplerState.PointClamp);
        gameManager.Draw(spriteBatch);
        spriteBatch.End();

        base.Draw(gameTime);
    }

    // public void DrawGalaxyMap()
    // {
    //     GalacticMapScene galaxyMap = new GalacticMapScene();
    //     // List<List<StarSystem>> hyperlanes = galaxyMap.GetHyperLanes();
    //     List<StarSystem> starSystems = galaxyMap.GetStarSystems();
    //     foreach (StarSystem system in starSystems)
    //     {
    //         int xPosition = system.GetXPosition();
    //         int yPosition = system.GetYPosition();
    //         string textureName = system.GetTextureName();
    //         float scale = 1;
    //         AddContent(xPosition, yPosition, textureName, scale, Color.White);
    //         // AddSprite(textureName, xPosition, yPosition, scale);
    //     }
    // }
}
