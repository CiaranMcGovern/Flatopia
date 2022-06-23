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
    }

    public abstract class FlatopiaEngine
    {
        private Vector2 ScreenDimensions = new Vector2(512, 512);
        private string Title = "New Game";
        private Canvas Window = null;
        private Thread GameLoopThread = null;
        public Color BackGroundColour = Color.Green;


        private static List<Shape2D> AllShapes = new List<Shape2D>();

        public FlatopiaEngine(Vector2 screenDimensions, string title)
        {
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
                    Console.WriteLine("Game is Loading...");
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
        }

        public abstract void OnLoad();

        public abstract void OnUpdate();

        public abstract void OnDraw();

    }
}
