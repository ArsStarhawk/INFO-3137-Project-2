using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentBuilderLibrary;

namespace INFO_3137_Project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director("JSON");
            
            director._name = "branch1";
            director.BuildBranch();

            director._name = "leaf1";
            director._content = "content";
            director.BuildLeaf();
director.CloseBranch();
            director._name = "leaf2";
            director._content = "content";
            director.BuildLeaf();

          

            director.Print();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
