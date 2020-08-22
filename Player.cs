using System;
using System.Collections.Generic;
using System.Text;

namespace MagicalDiamondGame
{
    public sealed class Player
    {
        Player()
        {
        }
        private int PlayerHealth = 0;
        private int PlayerWeapon = 0;
 

       public  List<string> PlayerBoxs = new List<string>();
        public List<string> PlayerKeys = new List<string>();


        public Cell[,] GetMap()
        {
            GameWorld gameWorld = GameWorld.Instance;
            Cell[,] GameMap = gameWorld.BuildGameMap();
            return GameMap;
        }
        public   Cell Currentcell = new Cell() ;
        public Cell Prevcell;

        public void MoveLeft()
        {
            Cell[,] Map = GetMap();
            for (int k = 0; k < Map.GetLength(0); k++)
                for (int l = 0; l < Map.GetLength(1); l++)
                {
                    if (Prevcell == Currentcell)
                    {
                        Currentcell = Map[k, l + 1];
                        k = Map.GetLength(0);
                        break;
                    }
                    Prevcell = Currentcell;
                }



        }
        public void MoveRight()
        {
            Cell[,] Map = GetMap();
            for (int k = 0; k < Map.GetLength(0); k++)
                for (int l = 0; l < Map.GetLength(1); l++)
                {

                    if (Prevcell == Currentcell)
                    {
                        if (l>0)
                        Currentcell = Map[k , l - 1];
                        k = Map.GetLength(0);
                        break;
                    }
                    Prevcell = Currentcell;
                }



        }
        public void MoveDwon()
        {
            Cell[,] Map = GetMap();
            for (int k = 0; k < Map.GetLength(0); k++)
                for (int l = 0; l < Map.GetLength(1); l++)
                {
                    if (Prevcell == Currentcell)
                    {
                        Currentcell = Map[k+1, l ];
                        k = Map.GetLength(0);
                        break;
                    }
                    Prevcell = Currentcell;
                }



        }
        public void MoveUp()
        {
            Cell[,] Map = GetMap();
            for (int k = 0; k < Map.GetLength(0); k++)
                for (int l = 0; l < Map.GetLength(1); l++)
                {

                    if (Prevcell == Currentcell)
                    {
                        if (k> 0)
                            Currentcell = Map[k -1, l ];
                        k = Map.GetLength(0);
                        break;
                    }
                    Prevcell = Currentcell;
                }



        }

        public int GetPlayerHealth()
        {
            return PlayerHealth;
        }
        public void SetPlayerHealth(int playerhealth)
        {
            PlayerHealth = playerhealth;
        }

        public int GetPlayerWeapon()
        {
            return PlayerWeapon;
        }
        public void SetPlayerWeapon(int playerWeapon)
        {
            PlayerWeapon = playerWeapon;
        }
        private static readonly object padlock = new object();
        private static Player instance = null;
        public static Player Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new Player();
                        }
                    }
                }
                return instance;
            }
        }

        public void StartGame()
        {
            Console.WriteLine("You are in dessert for search for the magical diamond ");
            Console.WriteLine("You can walk one step at a time in any direction inside our map ");

            Console.WriteLine("Enter your direction Up , Down , Right , Left");

            string input = Console.ReadLine();

            switch (input)
            {
                case "Up":
                    MoveUp();
                    break;
                case "Down":
                    MoveDwon(); break;
                case "Right":
                    MoveRight();
                    break;
                case "Left":
                    MoveLeft();
                    break;
                default:
                    Console.WriteLine("Not valid");
                    break;
            }


        }

    }

}
