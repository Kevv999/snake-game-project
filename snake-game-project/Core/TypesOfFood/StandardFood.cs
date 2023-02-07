using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_game_project
{
    internal class StandardFood : Food
    {
        public StandardFood(int x, int y) : base(x, y)
        {
            base.FColor = Color.LightBlue;
        }

        public override void SpecialEffect(Player player)
        {
            player.Score += 1;
            player.AddToTail(1);
        }
    }
}
