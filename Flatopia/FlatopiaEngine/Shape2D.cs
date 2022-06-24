using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flatopia.FlatopiaEngine
{
    public class Shape2D
    {
        public Vector2 Position;
        public Vector2 Scale;
        public string Tag = "";

        public Shape2D(Vector2 Position, Vector2 Scale, string Tag)
        {
            this.Position = Position;
            this.Scale = Scale;
            this.Tag = Tag;

            Log.Info($"[Shape2D]{Tag} - Has Been Registered");

            FlatopiaEngine.RegisterShape(this);
        }

        public void DestroySelf()
        {
            Log.Info($"Shape2D{Tag} - Has Been Deregistered");
            FlatopiaEngine.DeregisterShape(this);
        }
    }
}
