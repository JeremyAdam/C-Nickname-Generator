using System;
using System.Collections.Generic;

namespace Test
{
    class nicknameVariables
    {
        public bool menuOpen = true;
        public string userFirstName;
        public string userLastName;
        public int select;
        public bool programOpenedBefore = false;
        public string [] nicknamesArray = {"The Quick", "The Hacker", "The Big", "The Small", "The Weird"};
        public bool run = true; // Keeps The Whole Thing Under A Loop

    }
    class nicknameGenerator {
        static void Main(string[] agrs)
        {
            nicknameVariables program = new nicknameVariables(); // Creates An Object
            Random random = new Random(); // Helps Create The Random Int
            List<string> nicknamesList = new List<string>(program.nicknamesArray); // Creates List
            while (program.run == true)
            {
                if (program.programOpenedBefore == false)
                { // Checks For First Time Opening Program
                    Console.WriteLine("Please enter your first name: ");
                    program.userFirstName = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Please enter your last name: ");
                    program.userLastName = Convert.ToString(Console.ReadLine());
                    program.programOpenedBefore = true;
                }
                while (program.menuOpen == true)
                { // Creates The Main Menu
                    Console.WriteLine(" ");                
                    Console.WriteLine("---NICKNAME GENERATOR");
                    Console.WriteLine("1: Change full name.");
                    Console.WriteLine("2: Generate one nickname.");
                    Console.WriteLine("3: Generate all nicknames.");
                    Console.WriteLine("4: Add a nickname.");
                    Console.WriteLine("5: Remove a nickname.");
                    Console.WriteLine("6: Exit.");
                    Console.WriteLine("---SELECT (1-6): ");
                    program.select = Convert.ToInt32(Console.ReadLine());
                    program.menuOpen = false;
                }
                if (program.select == 1)
                { // Change Name Variables
                    Console.WriteLine("Please enter your new first name: ");
                    program.userFirstName = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Please enter your new last name: ");
                    program.userLastName = Convert.ToString(Console.ReadLine());
                    program.select = 0;
                    program.menuOpen = true;
                } else if (program.select == 2)
                { // Generate One Nickname
                    int randNum = random.Next(0, nicknamesList.Count);
                    Console.WriteLine(program.userFirstName + " " + nicknamesList[randNum] + " " + program.userLastName);
                    program.select = 0;
                    program.menuOpen = true;
                } else if (program.select == 3)
                { // Generate All Nicknames In List
                    for (int i = 0; i < nicknamesList.Count; i++)
                    {
                        Console.WriteLine(program.userFirstName + " " + nicknamesList[i] + " " + program.userLastName);
                    }
                    program.select = 0;
                    program.menuOpen = true;
                } else if (program.select == 4)
                { // Add A Nickname To The List
                    Console.WriteLine("Please add your new nickname: ");
                    string addToList = Convert.ToString(Console.ReadLine());
                    nicknamesList.Add(addToList);
                    program.select = 0;
                    program.menuOpen = true;
                } else if (program.select == 5)
                { // Remove A Nickname From The List
                    foreach (string i in nicknamesList)
                    {
                        Console.WriteLine(i);
                    }
                    Console.WriteLine("Please name the nickname you want to remove: ");
                    string removeFromList = Convert.ToString(Console.ReadLine());
                    int idx = nicknamesList.IndexOf(removeFromList);
                    if (idx >= 0)
                    {
                        nicknamesList.Remove(removeFromList);
                        Console.WriteLine("Nickname removed");
                    } else
                    {
                        Console.WriteLine("No nickname with that name was found");
                    }
                    program.select = 0;
                    program.menuOpen = true;
                } else if (program.select == 6)
                { // End Program
                    program.run = false;
                }
            } 
        }
    }
}
