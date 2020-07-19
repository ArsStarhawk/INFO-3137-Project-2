using System;

namespace INFO_3137_Project_2
{
    abstract class UIHelper
    {
        public static void PrintUsage()
        {
            Console.WriteLine("\n\nUsage: ");
            Console.WriteLine("{0,-25}{1,-25}", "\thelp", "-Prints Usage (this page).");
            Console.WriteLine("{0,-25}{1,-25}", "\tmode:<JSON|XML>", "-Sets mode to JSON or XML. Must be set before creating or closing.");
            Console.WriteLine("{0,-25}{1,-25}", "\tbranch:<name>", "-Creates a new branch, assigning it the passed name.");
            Console.WriteLine("{0,-25}{1,-25}", "\tleaf:<name>:<content>", "-Creates a new leaf, assigning the passed name and content.");
            Console.WriteLine("{0,-25}{1,-25}", "\tclose", "-Closes the current branch, as long as it is not the root.");
            Console.WriteLine("{0,-25}{1,-25}", "\tprint", "-Prints the document in its current state to the console.");
            Console.WriteLine("{0,-25}{1,-25}", "\texit", "-Exits the application.");
        }



    }
}