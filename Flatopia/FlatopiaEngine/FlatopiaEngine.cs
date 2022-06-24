using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;

namespace Flatopia.FlatopiaEngine
{
    class Canvas : Form
    {
        public Canvas()
        {
            this.DoubleBuffered = true;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Canvas
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Canvas";
            this.Load += new System.EventHandler(this.Canvas_Load);
            this.ResumeLayout(false);

        }

        private void Canvas_Load(object sender, EventArgs e)
        {

        }
    }

    public abstract class FlatopiaEngine
    {
        private Vector2 ScreenDimensions = new Vector2(512, 512);
        private string Title = "New Game";
        private Canvas Window = null;
        private Thread GameLoopThread = null;
        public Color BackGroundColour = Color.Green;


        private static List<Shape2D> AllShapes = new List<Shape2D>();
        private static List<Sprite2D> AllSprites = new List<Sprite2D>();
        private static List<Tile2D> AllTiles = new List<Tile2D>();

        public FlatopiaEngine(Vector2 screenDimensions, string title)
        {
            Log.Info("Game Startup Beginning");
            this.ScreenDimensions = screenDimensions;
            this.Title = title;

            Window = new Canvas();
            Window.Size = new Size((int)ScreenDimensions.X, (int)ScreenDimensions.Y);
            Window.Text = title;
            Window.Paint += Renderer;

            GameLoopThread = new Thread(GameLoop);
            GameLoopThread.Start();

            Application.Run(Window);
        }

        public static void RegisterShape(Shape2D shape)
        {
            AllShapes.Add(shape);
        }

        public static void DeregisterShape(Shape2D shape)
        {
            AllShapes.Remove(shape);
        }

        public static void RegisterSprite(Sprite2D sprite)
        {
            AllSprites.Add(sprite);
        }

        public static void DeregisterSprite(Sprite2D sprites)
        {
            AllSprites.Remove(sprites);
        }

        public static void RegisterTile(Tile2D tile)
        {
            AllTiles.Add(tile);
        }

        public static void DeregisterTile(Tile2D tile)
        {
            AllTiles.Remove(tile);
        }

        void GameLoop()
        {

            OnLoad();
            while (GameLoopThread.IsAlive)
            {
                try
                {
                    OnDraw();
                    Window.BeginInvoke((MethodInvoker)delegate { Window.Refresh(); });
                    OnUpdate();
                    Thread.Sleep(1);
                }
                catch
                {
                    Log.Error("Game window not found... Looking Again..");
                }

            }
        }

        private void Renderer(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(BackGroundColour);

            foreach(Shape2D shape in AllShapes)
            {
                g.FillRectangle(new SolidBrush(Color.Red), shape.Position.X, shape.Position.Y, shape.Scale.X, shape.Scale.Y);
            }
            
            foreach(Sprite2D sprite in AllSprites)
            {
                g.DrawImage(sprite.Sprite, sprite.Position.X, sprite.Position.Y, sprite.Scale.X, sprite.Scale.Y);
            }
            foreach (Tile2D tile in AllTiles)
            {
                g.DrawImage(tile.Tile, tile.Position.X, tile.Position.Y, tile.Scale.X, tile.Scale.Y);
            }
        }

        public abstract void OnLoad();

        public abstract void OnUpdate();

        public abstract void OnDraw();

    }
}
