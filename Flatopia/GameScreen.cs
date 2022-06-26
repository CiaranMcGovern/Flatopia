using Flatopia.FlatopiaClasses;
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
        private List<Tile2D> AllTiles = new List<Tile2D>();
        public GameScreen()
        {
            InitializeComponent();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            ParseMapFile();
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
            RenderTiles();
            GameClock.Stop();
        }

        private void ParseMapFile()
        {
            float BoardWidth = GameBoard.Width;
            float BoardHeight = GameBoard.Height;
            for(int i = 0; i < 50; i++)
            {
                for(int j=0; j < 50; j++)
                {
                    AllTiles.Add(new Tile2D(new Vector2(j * BoardWidth / 50, i* BoardHeight / 50), new Vector2(BoardWidth / 50, BoardHeight/50), "Tiles/tile_01", "Grass"));
                }                
            }

        }
        private void RenderTiles()
        {
            foreach(Tile2D tile in AllTiles)
            {
                g.DrawImage(tile.Tile, tile.Position.X, tile.Position.Y, tile.Scale.X, tile.Scale.Y);
            }
        }
    }
}
