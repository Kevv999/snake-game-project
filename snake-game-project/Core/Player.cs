using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Diagnostics;
using System.Timers;

namespace snake_game_project
{
    internal class Player
    {
        public System.Timers.Timer speedTimer; //Utökning rad
      
        public enum Direction { Up, Down, Left, Right, None }
        public Direction SnakeDirection { get; set; }
        public SnakeNode Head;
        public Color PColor;

        public bool Dying { get; set; }
        public bool Alive { get; set; }
        public int Score { get; set; }

        public int Speed { get; set; }
        int StartBuffer = 10;
        int Buffer;
        public LinkedList<SnakeNode> Tail { set; get; }

        Direction Input;

        Engine GameEngine;
        
        public Player(int x, int y, uint size, Color c, Engine engine)
        {
            SnakeDirection = Direction.Down;
            GameEngine = engine;
            Tail = new LinkedList<SnakeNode>();
            PColor = c;

            Dying = false;
            Alive = true;

            Speed = 8;

            Buffer = StartBuffer;

            Head = new SnakeNode(x, y, PColor);
            for (int i = 1; i < size; i++)
            {
                Tail.AddLast(new SnakeNode(x + i, y, PColor));
            }
        }

        public void SpeedTime()//Utökning metod
        {
           
            Speed = 10;
            speedTimer = new System.Timers.Timer();
            speedTimer.Interval = 10000;
           
            speedTimer.Elapsed += TimerTick;
            speedTimer.AutoReset = false;
            speedTimer.Start();

            
            
         
        }
        private void TimerTick(object? sender, EventArgs e)//Utökning metod
        {

                Speed = 8;
              
        }
    
      
        public void Draw(Renderer renderer)
        {
            renderer.Draw(Head.Position.X, Head.Position.Y, Head.NColor);
            foreach(var node in Tail)
            {
                renderer.Draw(node.Position.X, node.Position.Y, node.NColor);
            }
        }

        public void Tick()
        {
            if (RealTick())
            {
                if (!Dying)
                {
                    Move();
                    ChangeDirection();
                  
                }
                else
                {
                    Die();
                }
            }

        }

        private bool RealTick()
        {
            Buffer--;
            if((Buffer - Speed) <= 0)
            {
                Buffer = StartBuffer;
                return true;
            }
            else
            {
                return false;
            }
        }
        private void Die()
        {
            if(Tail.Last != null)
            {
                Tail.RemoveLast();
            }
            else
            {
                Alive = false;
            }

        }

        public void Eat(Food food)
        {
            food.SpecialEffect(this);
        }

        public void AddToTail(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Tail.AddLast(new SnakeNode(-1, -1, PColor));
            }
        }

        public void RemoveFromTail(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Tail.RemoveLast();
            }
        }

        public void AddInput(Direction d)
        {
            Input = d;
        }

        private void ChangeDirection()
        {
            switch (Input)
            {
                case Direction.Up:
                    if (SnakeDirection != Direction.Down)
                    {
                        SnakeDirection = Input;
                    }
                    break;
                case Direction.Down:
                    if (SnakeDirection != Direction.Up)
                    {
                        SnakeDirection = Input;
                    }
                    break;
                case Direction.Left:
                    if (SnakeDirection != Direction.Right)
                    {
                        SnakeDirection = Input;
                    }
                    break;
                case Direction.Right:
                    if (SnakeDirection != Direction.Left)
                    {
                        SnakeDirection = Input;
                    }
                    break;
            }
            Input = Direction.None;


        }
        public void Move()
        {
            if (Tail.First != null) {
                var tail = Tail.Last;
                Tail.RemoveLast();
                Tail.AddFirst(tail);
                var tempPosition = Head.Position;
                tail.Value.Position = tempPosition;
            }
            switch (SnakeDirection)
            {
                case Direction.Up:
                    Head.Position = new Vector2(Head.Position.X, Head.Position.Y - 1);
                    if (Head.Position.Y == -1)
                    {
                        Head.Position = new Vector2(Head.Position.X, Head.Position.Y + GameEngine.Size);
                    }
                    break;
                case Direction.Down:
                    Head.Position = new Vector2(Head.Position.X, (Head.Position.Y + 1) % GameEngine.Size);
                    break;
                case Direction.Left:
                    Head.Position = new Vector2(Head.Position.X - 1, Head.Position.Y);
                    if (Head.Position.X == -1)
                    {
                        Head.Position = new Vector2(Head.Position.X + GameEngine.Size, Head.Position.Y);
                    }
                    break;
                case Direction.Right:
                    Head.Position = new Vector2((Head.Position.X + 1) % GameEngine.Size, Head.Position.Y);
                    break;
            }
            
        }

    }
}
