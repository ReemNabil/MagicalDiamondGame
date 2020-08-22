using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace MagicalDiamondGame
{
   public class Enemy
    {
        Player player;

        public int EnemyWeapon = 10;
        public string Type()
        {
            return "Enemy";
        }

        public void ExecuteEnemyStrategy()
        {
            // health will be affected by this equation ( Player health – enemy weapon)  

           player.SetPlayerHealth(player.GetPlayerHealth() - EnemyWeapon);


        }
    }
}
