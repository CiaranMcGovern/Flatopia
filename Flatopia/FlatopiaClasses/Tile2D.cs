using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flatopia.FlatopiaClasses
{
    public class Tile2D
    {
        public Vector2 Position;
        public Vector2 Scale;
        public string Directory = "";
        public string Tag = "";
        public Bitmap Tile = null;

        public Tile2D(Vector2 Position, Vector2 Scale, string Directory, string Tag)
        {
            this.Position = Position;
            this.Scale = Scale;
            this.Directory = Directory;
            this.Tag = Tag;

            Image tempTile = Image.FromFile($"Assets/Sprites/PNG/{Directory}.png");
            Tile = new Bitmap(tempTile, (int)this.Scale.X, (int)this.Scale.Y);


        }
        
    }
}
