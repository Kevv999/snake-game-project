using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_game_project
{
    internal class SpeedFood : Food//Utökning Klass
    {
       
        LinkedList<Player> Players;
        public SpeedFood(int x, int y, LinkedList<Player> player) : base(x, y)
        {
            Players = player;
            base.FColor = Color.Gold;
        }

        public override void SpecialEffect(Player player)
        {
            Random random = new Random();

            LinkedList<Player> temp = new LinkedList<Player>();

            foreach(var p in Players)
            {
                if(p.Alive)
                {
                    temp.AddLast(p);
                }
            }
            var RandomPlayer = temp.ElementAt(random.Next(0, temp.Count()));
            RandomPlayer.SpeedTime();

        }

        
    }
}
