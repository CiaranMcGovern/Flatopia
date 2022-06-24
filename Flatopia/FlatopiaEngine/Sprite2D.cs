using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Flatopia.FlatopiaEngine
{
    public class Sprite2D
    {
        public Vector2 Position;
        public Vector2 Scale;
        public string Directory = "";
        public string Tag = "";
        public Bitmap Sprite = null;

        public Sprite2D(Vector2 Position, Vector2 Scale, string Directory, string Tag)
        {
            this.Position = Position;
            this.Scale = Scale;
            this.Directory = Directory;
            this.Tag = Tag;

            Image tempSprite = Image.FromFile($"Assets/Sprites/PNG/{Directory}.png");
            Sprite = new Bitmap(tempSprite, (int)this.Scale.X, (int)this.Scale.Y);

            Log.Info($"[Sprite2D]{Tag} - Has Been Registered");

            FlatopiaEngine.RegisterSprite(this);
        }

        public void DestroySelf()
        {
            Log.Info($"Sprite2D{Tag} - Has Been Deregistered");
            FlatopiaEngine.DeregisterSprite(this);
        }
    }
}
