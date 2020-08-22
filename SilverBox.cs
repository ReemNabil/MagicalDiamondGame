using System;
using System.Collections.Generic;
using System.Text;

namespace MagicalDiamondGame
{
  public  class SilverBox : IBoxStrategy
    {
        Player player = Player.Instance;

        public void doOperation()
        {
            //Increase weapon by 10 
            //  Increase health by 40
            player.SetPlayerHealth(player.GetPlayerHealth() + 40);
            player.SetPlayerWeapon(player.GetPlayerWeapon() + 10);
            Console.WriteLine("Your Health Increased by 40 points  ");
            Console.WriteLine("Your weapon Increased  by 10 ");
        }

        public string GetBoxType()
        {
            return "Silver Box";
        }
    }
}
