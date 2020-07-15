using System.Collections.Generic;

namespace DocumentBuilderLibrary
{
    public class XBranch : IComposite
    {
        private Stack<IComposite> _children;
        private string _name;


        public void AddChild(IComposite child)
        {
            throw new System.NotImplementedException();
        }

        public string Print(int depth)
        {
            //form all the string shit?
            return "butts";
        }
    }
}