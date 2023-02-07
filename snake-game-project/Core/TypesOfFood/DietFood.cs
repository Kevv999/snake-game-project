using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_game_project
{
    internal class DietFood : Food
    {
        public DietFood(int x, int y) : base(x, y)
        {
            base.FColor = Color.Red;
        }

        public override void SpecialEffect(Player player)
        {
            player.RemoveFromTail(1);
            player.Score += 1;
        }
    }
}
