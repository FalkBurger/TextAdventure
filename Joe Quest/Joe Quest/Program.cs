using System;
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
            Console.WriteLine("You are Joe, an average guy. You have found a great castle with many potential treasures. Before you stands this mighty castle and it's wooden door. Behind you is the" +
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

                else if (input == "look")
                {
                    CommandObj.Look(Convert.ToInt32(File.ReadAllText("RoomDetail.txt")));
                }

                else
                {
                    Console.WriteLine("I don't understand that.");
                }
            } while (!MainObj.exit);
        }
    }
}
