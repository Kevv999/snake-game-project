using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace snake_game_project
{
    internal class SnakeNode
    {
        public Vector2 Position { get; set; }
        public Color NColor { get; }
        public SnakeNode(float x, float y, Color c)
        {
            Position = new Vector2(x, y);
            NColor = c;
        }
    }
}
