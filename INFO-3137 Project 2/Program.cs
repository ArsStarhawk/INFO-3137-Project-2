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
            Director director = new Director("XML");
            
            director._name = "Team";
            director.BuildBranch();

            director._name = "Position";
            director._content = "Center";
            director.BuildLeaf();

            director._name = "Player";
            director._content = "Joe Blow";
            director.BuildLeaf();

            director.CloseBranch();
            director.CloseBranch();
            director.CloseBranch();

            director.Print();

        }
    }
}
