using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flatopia.FlatopiaEngine
{
    public class Vector2
    {
        public float X { get; set; }
        public float Y { get; set; }

        public Vector2()
        {
            X = DefaultValues().X;
            Y = DefaultValues().Y; 
        }

        public Vector2(float x, float y)
        {
            X = x;
            Y = y;
        }

        public static Vector2 DefaultValues()
        {
            return new Vector2(0, 0);
        }
    }
}
