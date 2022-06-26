using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flatopia
{
    public partial class GameScreen : Form
    {
        Graphics g;
        public GameScreen()
        {
            InitializeComponent();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            GameClock.Start();
            g = GameBoard.CreateGraphics();
        }

        private void GameScreen_Resize(object sender, EventArgs e)
        {

        }

        private void GameScreen_Paint(object sender, PaintEventArgs pe)
        {

        }

        private void GameClock_Tick(object sender, EventArgs e)
        {
            RenderGrid();
            GameClock.Stop();
        }


        private void RenderGrid()
        {
            float TileWidth = GameBoard.Width/100;
            float TileHeight = GameBoard.Height/100;

            for (int i = 0; i < 100; i++)
            {
                int currentTileHeight = (int)(i * TileHeight);
                for (int j = 0; j < 100; j++)
                {
                    g.DrawRectangle(new Pen(Color.Red), new Rectangle((int)(j*TileWidth), currentTileHeight, (int)TileWidth, (int)TileHeight));
                }
            }
        }
    }
}
