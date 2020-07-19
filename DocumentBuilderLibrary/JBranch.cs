using System.Collections.Generic;

namespace DocumentBuilderLibrary
{
    public class JBranch : IComposite
    {
        private Stack<IComposite> _children;
        private string _name;

        public JBranch(string name)
        {
            _name = name;
            _children = new Stack<IComposite>();
        }

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