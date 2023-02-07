using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace snake_game_project
{
    internal abstract class Food
    {

        public Vector2 Position;

        protected Color FColor;
        public Food(int x, int y)
        {
            Position = new Vector2(x, y);
        }
        public void Draw(Renderer renderer)
        {
            renderer.Draw(Position.X, Position.Y, FColor);
        }
        public abstract void SpecialEffect(Player player);

    }
}
