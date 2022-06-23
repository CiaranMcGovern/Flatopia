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

        public FlatopiaEngine(Vector2 screenDimensions, string title)
        {
            this.ScreenDimensions = screenDimensions;
            this.Title = title;

            Window = new Canvas();
            Window.Size = new Size((int)ScreenDimensions.X, (int)ScreenDimensions.Y);
            Window.Text = title;
            Window.Paint += Renderer;

            OnLoad();
            GameLoopThread = new Thread(GameLoop);
            GameLoopThread.Start();

            Application.Run(Window);
        }
        void GameLoop()
        {
            while (GameLoopThread.IsAlive)
            {

            }
        }

        private void Renderer(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
        }

        public abstract void OnLoad();

    }
}
