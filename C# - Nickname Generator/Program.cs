using System;
using System.Collections.Generic;

namespace Test
{
    class nicknameGenerator {
        static void Main(string[] args)
        {
            Random random = new Random(); // Helps Create The Random Int
            bool menuOpen = true; // To Load Menu
            string userFirstName = ""; // Users Last Name
            string userLastName = ""; // Users First Name
            int select = 0; // For Selecting From menu
            bool programOpenedBefore = false; // To Start Program By Asking For Name
            string [] nicknamesArray = {"The Quick", "The Hacker", "The Big", "The Small", "The Weird"};
            List<string> nicknamesList = new List<string>(nicknamesArray); // Creates List
            bool run = true; // Keeps The Whole Thing Under A Loop
            while (run)
            {
                if (programOpenedBefore == false)
                { // Checks For First Time Opening Program
                    Console.WriteLine("Please enter your first name: ");
                    userFirstName = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Please enter your last name: ");
                    userLastName = Convert.ToString(Console.ReadLine());
                    programOpenedBefore = true;
                }
                while (menuOpen == true)
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
                    select = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(" ");  
                    menuOpen = false;
                }
                if (select == 1)
                { // Change Name Variables
                    Console.WriteLine("Please enter your new first name: ");
                    userFirstName = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Please enter your new last name: ");
                    userLastName = Convert.ToString(Console.ReadLine());
                    select = 0;
                    menuOpen = true;
                } else if (select == 2)
                { // Generate One Nickname
                    int randNum = random.Next(0, nicknamesList.Count);
                    Console.WriteLine(userFirstName + " " + nicknamesList[randNum] + " " + userLastName);
                    select = 0;
                    menuOpen = true;
                } else if (select == 3)
                { // Generate All Nicknames In List
                    for (int i = 0; i < nicknamesList.Count; i++)
                    {
                        Console.WriteLine(userFirstName + " " + nicknamesList[i] + " " + userLastName);
                    }
                    select = 0;
                    menuOpen = true;
                } else if (select == 4)
                { // Add A Nickname To The List
                    Console.WriteLine("Please add your new nickname: ");
                    string addToList = Convert.ToString(Console.ReadLine());
                    nicknamesList.Add(addToList);
                    select = 0;
                    menuOpen = true;
                } else if (select == 5)
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
                    select = 0;
                    menuOpen = true;
                } else if (select == 6)
                { // End Program
                    run = false;
                } else
                {
                    Console.WriteLine("Value does not work");
                    select = 0;
                    menuOpen = true;
                }
            } 
        }
    }
}
