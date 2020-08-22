using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
namespace MagicalDiamondGame
{

    public sealed class GameWorld
    {
        // To Applay Singleton 
        GameWorld()
        {
        }
            
        private static readonly object padlock = new object();
        private static GameWorld instance = null;
        
  
        public Cell[,] BuildGameMap()
        {
          Cell[,] Map;
            using (StreamReader file = File.OpenText(@"C:\Users\Reem.Soliman\source\repos\MagicalDiamondGame\game.json"))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                JObject o2 = (JObject)JToken.ReadFrom(reader);


                JArray a = (JArray)o2["cells"];

                Map = new Cell[4, 6];

                for (int k = 0; k < Map.GetLength(0); k++)
                    for (int l = 0; l < Map.GetLength(1); l++)
                    {
                        Map[k, l] = JsonConvert.DeserializeObject<Cell>(a[l].ToString());
                    }
            }
            return Map;
        }


        public static GameWorld Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new GameWorld();
                        }
                    }
                }
                return instance;
            }
        }

        Player player = Player.Instance;
        Enemy enemy = new Enemy();
        IBoxStrategy box;
        IKey key = new GoldenKey();
        Context context;
        MagicalDiamond diamond = new MagicalDiamond();
        public void MangePlayer()
        {
            string CurrentcellDes = player.Currentcell.CellDescription = "Golden Box";
            box = new GoldenBox();
           if (CurrentcellDes == box.GetBoxType() && box.GetBoxType() == "Golden Box")
            {
                context = new Context(new GoldenBox());
                player.PlayerBoxs.Add(box.GetBoxType());
                foreach (string K in player.PlayerKeys)
                {
                    string k = K;
                    if (k == "Golden key")
                    {
                        context.executeStrategy();

                    }
                }
            }

            else if (CurrentcellDes == "Silver Box")
            {
                context = new Context(new SilverBox());
                player.PlayerBoxs.Add(box.GetBoxType());
                foreach (string K in player.PlayerKeys)
                {
                    string k = K;
                    if (k == "Silver key")
                    {
                        context.executeStrategy();

                    }
                }
            }
            else if (CurrentcellDes ==  "Bronze Box")
            {
                context = new Context(new BronzeBox());
                player.PlayerBoxs.Add(box.GetBoxType());
                foreach (string K in player.PlayerKeys)
                {
                    string k = K;
                    if (k == "Bronze Key")
                    {
                        context.executeStrategy();

                    }
                }
            }
            else if (CurrentcellDes == key.GetkeyType() && key.GetkeyType() == "Golden key")
            {
                key = new GoldenKey();
                player.PlayerKeys.Add(key.GetkeyType());
            }
            else if (CurrentcellDes == "Silver key")
            {
                key = new Silverkey();
                player.PlayerKeys.Add(key.GetkeyType());
            }
            else if (CurrentcellDes ==  "Bronze Key")
            {
                key = new BronzeKey();
                player.PlayerKeys.Add(key.GetkeyType());
            }
            else if (CurrentcellDes == enemy.Type())
            {
                enemy.ExecuteEnemyStrategy();
            }
            else if (CurrentcellDes == diamond.getType())
            {
                Console.WriteLine("Congratulation You are The winner");
            }
            else
            {
                Console.WriteLine(" Exit ");

            }





        }


























    }
}
