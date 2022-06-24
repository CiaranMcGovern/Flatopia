using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flatopia.FlatopiaEngine;

namespace Flatopia
{
    public class Flatopia : FlatopiaEngine.FlatopiaEngine
    {
        Sprite2D Player;
        public Flatopia() : base(new FlatopiaEngine.Vector2(615, 515), "Flatopia")
        {

        }

        public override void OnDraw()
        {
        }

        public override void OnLoad()
        {
            BackGroundColour = Color.Blue;

            Player = new Sprite2D(new Vector2(10, 10), new Vector2(43,49), "Hitman 1/hitman1_stand", "Player");
        }

        public override void OnUpdate()
        {
        }
    }
}
