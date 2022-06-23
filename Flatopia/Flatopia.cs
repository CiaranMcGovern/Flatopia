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
        Shape2D Player;
        public Flatopia() : base(new FlatopiaEngine.Vector2(615, 515), "Flatopia")
        {

        }

        public override void OnDraw()
        {
            Console.WriteLine("OnDraw Works");
        }

        public override void OnLoad()
        {
            BackGroundColour = Color.Blue;

            Player = new Shape2D(new Vector2(10, 10), new Vector2(10,10), "Player");
        }

        int frameCount;
        float x = 0.1f;
        public override void OnUpdate()
        {
            Console.WriteLine($"Frame Count: {frameCount}");
            Player.Position.X += x;
            frameCount++;
        }
    }
}
