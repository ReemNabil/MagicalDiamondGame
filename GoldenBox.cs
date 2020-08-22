using System;
using System.Collections.Generic;
using System.Text;

namespace MagicalDiamondGame
{
  public  class GoldenBox : IBoxStrategy
    {


        Player player = Player.Instance;
        public void doOperation()
        {
            //Increase health by 50 points  
            // Increase weapon by 10 

            player.SetPlayerHealth(player.GetPlayerHealth() + 50);
            player.SetPlayerWeapon(player.GetPlayerWeapon() + 10);

              Console.WriteLine("Your Health Increased by 50 points  ");
              Console.WriteLine("Your weapon Increased  by 10 ");


        }

        public string GetBoxType()
        {
            return "Golden Box";
        }
    }
}
