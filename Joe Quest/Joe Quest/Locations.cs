using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Joe_Quest
{
    class Locations
    {
        public string[] arrLocal = {"outside", "inside"};

        public void Outside(string kind, string direction)
        {

            if (kind == "look")
            {
                Console.WriteLine("You stand before the castle. To the North is a wooden door. Around you is a dense impassible forest.");
            }
            else if (kind == "move")
            {
                switch (direction)
                {
                    case "North":
                        Console.WriteLine("You move North!");
                        File.WriteAllText("RoomDetail.txt", "1");
                        break;

                    case "East":
                        Console.WriteLine("You can't move East!");
                        break;

                    case "South":
                        Console.WriteLine("You can't move South!");
                        break;

                    case "West":
                        Console.WriteLine("You can't move North!");
                        break;

                   default:
                        Console.WriteLine("I do not understand that direction. Try using the appropriate capitalisation.");
                        break;
                }
            }
        }

        public void Inside(string kind, string direction)
        {
            if (kind == "look")
            {
                Console.WriteLine("You stand inside the castle. There is an exit to the North and South");
            }
            else if (kind == "move")
            {
                switch (direction)
                {
                    case "North":
                        Console.WriteLine("You go North!");
                        File.WriteAllText("RoomDetail.txt", "2");
                        break;

                    case "East":
                        Console.WriteLine("You cannot East!");
                        break;

                    case "South":
                        Console.WriteLine("You move South!");
                        File.WriteAllText("RoomDetail.txt", "0");
                        break;

                    case "West":
                        Console.WriteLine("You cannot North!");
                        break;

                    default:
                        Console.WriteLine("I do not understand that direction. Try using the appropriate capitalisation.");
                        break;
                }
            }
        }
        public void Garden(string kind, string direction)
        {
            if (kind == "look")
            {
                Console.WriteLine("You stand inside a garden. There is an exit to the South");
            }
            else if (kind == "move")
            {
                switch (direction)
                {
                    case "North":
                        Console.WriteLine("You cannot North!");
                        break;

                    case "East":
                        Console.WriteLine("You cannot East!");
                        break;

                    case "South":
                        Console.WriteLine("You move South!");
                        File.WriteAllText("RoomDetail.txt", "1");
                        break;

                    case "West":
                        Console.WriteLine("You cannot North!");
                        break;

                    default:
                        Console.WriteLine("I do not understand that direction. Try using the appropriate capitalisation.");
                        break;
                }
            }
        }
    }
}
