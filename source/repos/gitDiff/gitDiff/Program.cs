using System;
using System.Collections.Generic;
using System.IO;

namespace gitDiff
{
    class Program
    {
        static void Main(string[] args)
        {
//asks which files are to be compared
            Console.WriteLine("Which files would you like to compare");
            Console.WriteLine("1: 1a and 1b");
            Console.WriteLine("2: 2a and 2b");
            Console.WriteLine("3: 3a and 3b");
            string input = Console.ReadLine();
//switch statement determines from user input which files are being compared           
            switch (Convert.ToInt32(input))
            {
                case 1:
                    //reads the text files then calls the compare function
                    string textOne = File.ReadAllText("GitRepositories_1a.txt");
                    string textTwo = File.ReadAllText("GitRepositories_1b.txt");
                    if (Compare.compare(textOne, textTwo))
                    {
                        Console.WriteLine("They are the same");
                    }
                    else
                    {
                        Console.WriteLine("They are not the same");
                    }
                    
                    break;
                case 2:
                    string textThree = File.ReadAllText("GitRepositories_2a.txt");
                    string textFour = File.ReadAllText("GitRepositories_2b.txt");
                    if (Compare.compare(textThree, textFour))
                    {
                        Console.WriteLine("They are the same");
                    }
                    else
                    {
                        Console.WriteLine("They are not the same");
                    }
                    break;
                case 3:
                    string textFive = File.ReadAllText("GitRepositories_3a.txt");
                    string textSix = File.ReadAllText("GitRepositories_3b.txt");
                    if (Compare.compare(textFive, textSix))
                    {
                        Console.WriteLine("They are the same");
                    }
                    else
                    {
                        Console.WriteLine("They are not the same");
                    }
                    break;
                default:
                    Console.WriteLine("Incorrect input");
                    break;

            }
           

        }
    }
}
