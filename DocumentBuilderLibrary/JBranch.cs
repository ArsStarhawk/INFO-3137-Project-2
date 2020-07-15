using System.Collections.Generic;

namespace DocumentBuilderLibrary
{
    public class JBranch : IComposite
    {
        private Stack<IComposite> _stack;
        private string _name;

        public void AddChild(IComposite child)
        {
            throw new System.NotImplementedException();
        }

        public string Print(int depth)
        {
            throw new System.NotImplementedException();
        }
    }
}