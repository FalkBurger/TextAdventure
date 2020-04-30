using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Joe_Quest
{
    class Locations
    {
        public string[] arrLocal = {"outside", "inside"};
        public string[] arrInventory;

        public void Outside(string kind, string specdec)
        {
            bool taken = false;
            string line;

            if (kind == "look")
            {
                switch (specdec)
                {
                    case "Door":
                        Console.WriteLine("\nThe door seems to be locked");
                        break;

                    case "Jewel":
                        Console.WriteLine("\nThe Jewel is somewhat loose");
                        break;

                    case "Lever":
                        Console.WriteLine("\nThe level is anchient");
                        break;

                    case "look":
                        Console.WriteLine("\nYou stand before the castle. To the North is a wooden door and a jewel. Around you is a dense impassible forest.");
                        break;

                    case "":
                        Console.WriteLine("\nYou stand before the castle. To the North is a wooden door and a jewel. Around you is a dense impassible forest.");
                        break;

                    default:
                        Console.WriteLine("\nI don't know what you\'re looking at.");
                        break;
                }
            }
            else if (kind == "move")
            {
                switch (specdec)
                {
                    case "North":
                        Console.WriteLine("\nYou move North!");
                        File.WriteAllText("RoomDetail.txt", "1");
                        break;

                    case "East":
                        Console.WriteLine("\nYou can't move East!");
                        break;

                    case "South":
                        Console.WriteLine("\nYou can't move South!");
                        break;

                    case "West":
                        Console.WriteLine("\nYou can't move North!");
                        break;

                   default:
                        Console.WriteLine("\nI do not understand that direction.");
                        break;
                }
            }
            else if (kind == "take")
            {
                switch (specdec)
                {
                    case "Jewel":
                        arrInventory = File.ReadAllLines("Inventory.txt");
                        
                        for (int i = 0; i < arrInventory.Length; i++)
                        {
                            line = arrInventory[i];

                            if (line == "Jewel")
                            {
                                taken = true;
                            }
                        }

                        if (taken)
                        {
                            Console.WriteLine("\nYou already have the Jewel!");
                            break;
                        }

                        Console.WriteLine("\nYou take the Jewel.");
                        File.AppendAllText("Inventory.txt", "Jewel");
                        break;

                    default:
                        Console.WriteLine("\nThat object does not exist.");
                        break;
                }
            }
        }

        public void Inside(string kind, string specdec)
        {
            if (kind == "look")
            {
                switch (specdec)
                {
                    case "look":
                        Console.WriteLine("\nYou stand inside the castle. There is an exit to the North and South");
                        break;

                    case "":
                        Console.WriteLine("\nYou stand inside the castle. There is an exit to the North and South");
                        break;

                    default:
                        Console.WriteLine("\nI don't know what you\'re looking at.");
                        break;
                }
                
            }
            else if (kind == "move")
            {
                switch (specdec)
                {
                    case "North":
                        Console.WriteLine("\nYou go North!");
                        File.WriteAllText("RoomDetail.txt", "2");
                        break;

                    case "East":
                        Console.WriteLine("\nYou cannot East!");
                        break;

                    case "South":
                        Console.WriteLine("\nYou move South!");
                        File.WriteAllText("RoomDetail.txt", "0");
                        break;

                    case "West":
                        Console.WriteLine("\nYou cannot North!");
                        break;

                    default:
                        Console.WriteLine("\nI do not understand that direction. Try using the appropriate capitalisation.");
                        break;
                }
            }
        }
        public void Garden(string kind, string specdec)
        {
            if (kind == "look")
            {
                switch (specdec)
                {
                    case "look":
                        Console.WriteLine("\nYou stand inside a garden. There is an exit to the South");
                        break;

                    case "":
                        Console.WriteLine("\nYou stand inside a garden. There is an exit to the South");
                        break;

                    default:
                        Console.WriteLine("\nI don't know what you\'re looking at.");
                        break;
                }
            }
            else if (kind == "move")
            {
                switch (specdec)
                {
                    case "North":
                        Console.WriteLine("\nYou cannot North!");
                        break;

                    case "East":
                        Console.WriteLine("\nYou cannot East!");
                        break;

                    case "South":
                        Console.WriteLine("\nYou move South!");
                        File.WriteAllText("RoomDetail.txt", "1");
                        break;

                    case "West":
                        Console.WriteLine("\nYou cannot North!");
                        break;

                    default:
                        Console.WriteLine("\nI do not understand that direction. Try using the appropriate capitalisation.");
                        break;
                }
            }
        }
    }
}
