using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Web.Helpers;

namespace MagicalDiamondGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Game Start ");
            Console.WriteLine();

            GameWorld gameWorld = GameWorld.Instance;
            Player player = Player.Instance;
            player.StartGame();
            gameWorld.BuildGameMap();
            gameWorld.MangePlayer();


            // To print the Map 
            //Cell[,] GameMap = gameWorld.BuildGameMap();

            //for (int k = 0; k < GameMap.GetLength(0); k++)
            //    for (int l = 0; l < GameMap.GetLength(1); l++)
            //    {
            //        Console.WriteLine(GameMap[k, l].CellDescription);
            //    }
        }
    }
}
