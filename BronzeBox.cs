using System;
using System.Collections.Generic;
using System.Text;

namespace MagicalDiamondGame
{
  public  class BronzeBox : IBoxStrategy
    {
        Player player = Player.Instance;


        public void doOperation()
        {
            //Increase health by 20 points 
            player.SetPlayerHealth(player.GetPlayerHealth() + 20);

            Console.WriteLine("Your Health Increased by 20 points  ");
        }

        public string GetBoxType()
        {
            return "Bronze Box";
 
        }
    }
}
