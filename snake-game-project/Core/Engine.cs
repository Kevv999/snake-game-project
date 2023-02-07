using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_game_project
{
    internal class Engine
    {
        public enum Direction {Up, Down, Left, Right}
        public int Size { get; set; }
        

        public LinkedList<Player> PlayerList;
        public LinkedList<Food> FoodList;

        public LinkedList<SnakeNode> SnakeNodeList;

        public Engine(int size, int playerAmount)
        {
            Size = size;

            PlayerList = new LinkedList<Player>();

            PlayerList.AddLast(new Player(0, 5, 2, Color.Orange, this));
            if(playerAmount == 2)
            {
                PlayerList.AddLast(new Player(0, 9, 2, Color.Blue, this));
            }
            
            else if(playerAmount == 3) //Utökning
            {
                PlayerList.AddLast(new Player(0, 9, 2, Color.Blue, this));
                PlayerList.AddLast(new Player(0, 13, 2, Color.Pink, this));
            }

            FoodList = new LinkedList<Food>();
            for (int i = 0; i < 4; i++)
            {
                FoodList.AddLast(SpawnRandomFood());
            }

            SnakeNodeList = new LinkedList<SnakeNode>();
        }

        public void Tick()
        {
            var tempNodeList = new LinkedList<SnakeNode>();
            foreach(Player player in PlayerList)
            {
                player.Tick();
                if (player.Alive)
                {
                    Collide(player);
                    tempNodeList.AddLast(player.Head);
                    foreach (var node in player.Tail)
                    {
                        tempNodeList.AddLast(node);
                    }
                }

            }
            SnakeNodeList = tempNodeList;

        }
        public bool EndGameCheck()
        {
            int count = 0;

            foreach(Player player in PlayerList)
            {
                if (player.Alive)
                {
                    count++;
                }
            }

            return count == 0;
        }
        public void Collide(Player p)
        {
            var tempFoodList = new LinkedList<Food>(FoodList);

            foreach (Food food in FoodList)
            {
                if (food.Position.Equals(p.Head.Position))
                {
                    p.Eat(food);
                }
                foreach (var node in SnakeNodeList)
                {
                    if (food.Position.Equals(node.Position))
                    {
                        tempFoodList.Remove(food);
                        tempFoodList.AddLast(SpawnRandomFood());
                    }
                    if (!p.Head.Equals(node))
                    {
                        if (p.Head.Position.Equals(node.Position))
                        {
                            p.Dying = true;
                        }
                    }

                }
            }

            FoodList=tempFoodList;
   
        }

        public Food SpawnRandomFood()
        {
            Random random = new Random();

            int randX = new Random().Next(0, Size);
            int randY = new Random().Next(0, Size);

            int randFood = new Random().Next(0, 100);

            if(randFood <= 80)
            {
                return new StandardFood(randX, randY);
                
            }
            else if(randFood <= 90)
            {
                return new ValuableFood(randX, randY);
            }
            else if (randFood <= 95)
            {
                return new SpeedFood(randX, randY,PlayerList);//Utökning rad
            }
            else
            {
                return new DietFood(randX, randY);
            }
        }

        public void Draw(Renderer renderer)
        {
            renderer.Clear();
            foreach (Food food in FoodList)
            {
                food.Draw(renderer);
            }
            foreach(Player player in PlayerList)
            {
                if (player.Alive)
                {
                    player.Draw(renderer);
                }
            }

        }
        

    }
}
