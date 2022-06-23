using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flatopia.FlatopiaEngine;

namespace Flatopia
{
    public class Flatopia : FlatopiaEngine.FlatopiaEngine
    {
        public Flatopia() : base(new FlatopiaEngine.Vector2(615, 515), "Flatopia")
        {

        }

        public override void OnLoad()
        {
            Console.WriteLine("Onload works");
        }
    }
}
