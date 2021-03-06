﻿using System;
using System.IO;
using Microsoft.VisualBasic.CompilerServices;

namespace Joe_Quest
{
    class Program
    {
        private bool exit;

        public Program()
        {
            exit = false;
        }



        static void Main(string[] args)
        {
            string input;
            string roomNum = "0";

            File.WriteAllText("RoomDetail.txt",roomNum);

            Program MainObj = new Program();
            CommandHandler CommandObj = new CommandHandler();

            
            Console.WriteLine("Hello World! This is Joe Quest, an experiment of my programming skills to create a basic text adventure. ");
            Console.WriteLine("\nYou are Joe, an average guy. You have found a great castle with many potential treasures. Before you stands this mighty castle and it's" +
                " wooden door with a lever and a jewel atop the door. Behind you is the" +
                " dense forest from whence you came. There is no other way to go than north.");

            do
            {
                input = Console.ReadLine();

                if (input == "exit")
                {
                    MainObj.exit = true;
                }

                else if (LikeOperator.LikeString(input, "move*", Microsoft.VisualBasic.CompareMethod.Binary))
                {
                    CommandObj.Move(Convert.ToInt32(File.ReadAllText("RoomDetail.txt")), input.Substring(input.IndexOf(" ") + 1));
                    //copy text after move 
                    //input.Substring(input.IndexOf(" ") + 1)

                }

                else if (LikeOperator.LikeString(input, "look*", Microsoft.VisualBasic.CompareMethod.Binary))
                {
                    CommandObj.Look(Convert.ToInt32(File.ReadAllText("RoomDetail.txt")), input.Substring(input.IndexOf(" ") + 1));
                }

                else if (LikeOperator.LikeString(input, "take*", Microsoft.VisualBasic.CompareMethod.Binary))
                {
                    CommandObj.Take(Convert.ToInt32(File.ReadAllText("RoomDetail.txt")), input.Substring(input.IndexOf(" ") + 1));
                }

                else if (input == "inventory")
                {
                    Console.WriteLine(File.ReadAllText("Inventory.txt"));
                }

                else if (LikeOperator.LikeString(input, "use*", Microsoft.VisualBasic.CompareMethod.Binary))
                {
                    CommandObj.Use(Convert.ToInt32(File.ReadAllText("RoomDetail.txt")), input.Substring(input.IndexOf(" ") + 1));
                }

                else if (input == "reset")
                {
                    File.WriteAllText("RoomDetail.txt","0");
                    File.WriteAllText("Inventory.txt", "");
                    Console.WriteLine("\nGame reset!");
                }

                else
                {
                    Console.WriteLine("\nI don't understand that.");
                }
            } while (!MainObj.exit);
        }
    } 

}
