using System;
using System.CodeDom;

namespace core3900.Assignment1
{
    class Program
    {
        const string MENU =
            "================ CS 394 Assignment 1 ===============  \n" +
            "G/g:   Ask for a N, and generate N members of mixed \n" +
            "    Member class's objects, and store in a Vector  \n" +
            "     and a array Objects.\n" +
            "S/s/ : Sort the members in the vector and array in \n" +
            "     ascending order.\n" +
            "V/v/ : Show the members in the vector and array .\n" +
            "O/o/ : Save objects inside vector into a HTML file \n" +
            "  with objects saved in the format of HTML \n" +
            "  Table.\n" +
            "F/f  : Show HTML file contents on screen.\n" +
            "L/l  : Launch the default internet browser to \n" +
            " display the generated HTML file.\n" +
            " --------------------------------------------------\n" +
            " H/h/?: Display this menu.\n" +
            " E/e  : Exit\n" +
            " =================================================";
        static void Main(string[] args)
        {
            DisplayMenu();
            ProcessInput();
            System.Console.Read();
        }

        private static void ProcessInput()
        {
            var input = System.Console.ReadLine();
            
            switch (input)
            {
                case "G":
                case "g":
                  System.Console.WriteLine("Generating...");
                    break;
                case "S":
                case "s":
                    System.Console.WriteLine("Sorting...");
                    break;
                case "V":
                case "v":
                    System.Console.WriteLine("Show in Verctor and array...");
                    break;
                case "O":
                case "o":
                    System.Console.WriteLine("Save Objects into HTML...");
                    break;
                case "F":
                case "f":
                    System.Console.WriteLine("Show Files...");
                    break;
                case "L":
                case "l":
                    System.Console.WriteLine("Launch...");
                    break;
                case "H":
                case "h":
                    System.Console.WriteLine("Show display...");
                    DisplayMenu();
                    break;
                case "E":
                case "e":
                    System.Console.WriteLine("Exit...");
                    break;
                default:
                    System.Console.WriteLine("Invalid input:");
                    break;

            }
        }

        private static void DisplayMenu()
        {
            System.Console.WriteLine(MENU);
        }
    }
}
