using System;
using System.Collections.Generic;

class nicknameGenerator {
    static void Main()
    {
        // Program Variables
        Random random = new Random(); // Helps Create The Random Int
        string userFirstName = ""; // Users Last Name
        string userLastName = ""; // Users First Name
        int select = 0; // For Selecting From menu
        string [] nicknamesArray = {"The Quick", "The Hacker", "The Big", "The Small", "The Weird"};
        List<string> nicknamesList = new List<string>(nicknamesArray); // Creates List

        // Checks For First Time Opening Program
        Console.Write("Please enter your first name: ");
        userFirstName = Console.ReadLine();
        Console.Write("Please enter your last name: ");
        userLastName = Console.ReadLine();

        // Main Loop
        bool run = true; // Keeps The Whole Thing Under A Loop
        while (run)
        { // Creates The Main Menu
            Console.WriteLine(" ");             
            Console.WriteLine("---NICKNAME GENERATOR");
            Console.WriteLine("1: Change full name.");
            Console.WriteLine("2: Generate one nickname.");
            Console.WriteLine("3: Generate all nicknames.");
            Console.WriteLine("4: Add a nickname.");
            Console.WriteLine("5: Remove a nickname.");
            Console.WriteLine("6: Exit.");
            Console.Write("---SELECT (1-6): ");
            select = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");  
                
            switch (select)
            {
                case 1: // Change Name Variables
                    Console.Write("Please enter your new first name: ");
                    userFirstName = Console.ReadLine();
                    Console.Write("Please enter your new last name: ");
                    userLastName = Console.ReadLine();
                    select = 0;                  
                    break;
                case 2: // Generate One Nickname
                    int randNum = random.Next(0, nicknamesList.Count);
                    Console.WriteLine(userFirstName + " " + nicknamesList[randNum] + " " + userLastName);
                    select = 0;
                    break;                               
                case 3: // Generate All Nicknames In List
                    for (int i = 0; i < nicknamesList.Count; i++)
                    {
                        Console.WriteLine(userFirstName + " " + nicknamesList[i] + " " + userLastName);
                    }
                    select = 0;
                    break;                                        
                case 4: // Add A Nickname To The List
                    Console.WriteLine("Please add your new nickname: ");
                    string addToList = Console.ReadLine();
                    nicknamesList.Add(addToList);
                    select = 0;
                    break;                                            
                case 5: // Remove A Nickname From The List
                    foreach (string nickname in nicknamesList)
                    {
                        Console.WriteLine(nickname);
                    }
                    Console.Write("Please name the nickname you want to remove: ");
                    string removeFromList = Console.ReadLine();
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
                    break;                                            
                case 6: // End Program
                    run = false;
                    break;
                default:
                    Console.WriteLine("Value does not work");
                    select = 0;
                    break;
            }
        } 
    }
}
