using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_game_project
{
    internal class Renderer
    {
        int Width;
        int Height;
        struct Entity
        {
            public Entity(float x, float y, Color c)
            {
                X = x;
                Y = y;
                EColor = c;
            }

            public float X { get; }
            public float Y { get; }
            public Color EColor { get; }
        }

        LinkedList<Entity> EntityList = new LinkedList<Entity>();
        public Renderer(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public void Draw(float x, float y, Color c)
        {
            EntityList.AddLast(new Entity(x, y, c));
        }
            
        public void Clear()
        {
            EntityList.Clear();
        }

        public void PaintGameArea(object? sender, PaintEventArgs e)
        {
            var target = (GameArea)sender;

            int tileWidth = target.Width/Width;
            int tileHeight = target.Height/Height;

            foreach(var p in EntityList)
            {
                e.Graphics.FillRectangle(new SolidBrush(p.EColor), tileWidth * p.X, tileHeight * p.Y, tileWidth, tileHeight);
            }
        }

        public void UpdateScore(Label label, int score)
        {
            label.Text = $"Score:{score}";
        }
        

    }
}
