using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_game_project 
{
    internal class ValuableFood : Food
    {
        public ValuableFood(int x, int y) : base(x, y)
        {
            base.FColor = Color.Purple;
        }

        public override void SpecialEffect(Player player)
        {
            player.Score += 5;
            player.AddToTail(2);
        }
    }
}
