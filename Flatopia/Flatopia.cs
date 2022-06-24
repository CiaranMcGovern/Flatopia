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

        string[,] Map =
        {
            {"g", "g", "g", "w", "w", "w", "g", "g", "g", "g", "g", "g", "g", "g", "g", "g", "g" },
            {"g", "g", "g", "w", "w", "w", "g", "g", "g", "g", "g", "g", "g", "g", "g", "g", "g" },
            {"g", "g", "g", "w", "w", "w", "g", "g", "g", "g", "g", "g", "g", "g", "g", "g", "g" },
            {"g", "g", "g", "w", "w", "w", "w", "g", "g", "g", "g", "g", "g", "g", "g", "g", "g" },
            {"g", "g", "g", "g", "w", "w", "w", "w", "g", "g", "g", "g", "g", "g", "g", "g", "g" },
            {"g", "g", "g", "g", "g", "w", "w", "w", "g", "g", "g", "g", "g", "g", "g", "g", "g" },
            {"g", "g", "g", "g", "g", "w", "w", "w", "g", "g", "g", "g", "g", "g", "g", "g", "g" },
            {"g", "g", "g", "g", "g", "w", "w", "w", "g", "g", "g", "g", "g", "g", "g", "g", "g" },
            {"g", "g", "g", "g", "g", "w", "w", "w", "g", "g", "g", "g", "g", "g", "g", "g", "g" },
            {"g", "g", "g", "g", "g", "w", "w", "w", "g", "g", "g", "g", "g", "g", "g", "g", "g" },
            {"g", "g", "g", "g", "g", "g", "w", "w", "g", "g", "g", "g", "g", "g", "g", "g", "g" },
            {"g", "g", "g", "g", "g", "g", "w", "w", "w", "g", "g", "g", "g", "g", "g", "g", "g" },
            {"g", "g", "g", "g", "g", "g", "w", "w", "w", "g", "g", "g", "g", "g", "g", "g", "g" },
            {"g", "g", "g", "g", "g", "g", "w", "w", "w", "g", "g", "g", "g", "g", "g", "g", "g" },
            {"g", "g", "g", "g", "g", "g", "w", "w", "w", "g", "g", "g", "g", "g", "g", "g", "g" },
            {"g", "g", "g", "g", "g", "g", "g", "w", "w", "g", "g", "g", "g", "g", "g", "g", "g" }
        };

        public Flatopia() : base(new FlatopiaEngine.Vector2(615, 515), "Flatopia")
        {

        }

        public override void OnDraw()
        {
        }

        public override void OnLoad()
        {
            BackGroundColour = Color.Blue;
            for(int i=0; i< Map.GetLength(0); i++)
            {
                for (int j=0; j<Map.GetLength(1); j++)
                {
                    if (Map[i,j] == "g")
                    {
                        new Tile2D(new Vector2(i*20, j*20), new Vector2(20, 20), "Tiles/tile_01", "grass tile");
                    }

                    if  (Map[i,j] == "w")
                    {
                        new Tile2D(new Vector2(i*20, j*20), new Vector2(20, 20), "Tiles/tile_19", "water tile");
                    }
                    
                }
            }

            Player = new Sprite2D(new Vector2(10, 10), new Vector2(43,49), "Hitman 1/hitman1_stand", "Player");


        }

        public override void OnUpdate()
        {
        }
    }
}
