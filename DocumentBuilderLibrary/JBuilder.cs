using System.Collections.Generic;

namespace DocumentBuilderLibrary
{
    public class JBuilder : IBuilder
    {
        private JBranch _root;
        private Stack<JBranch> _stack;

        public JBuilder()
        {
            _root = new JBranch("root");
            _stack = new Stack<JBranch>();
            _stack.Push(_root);
        }

        public void BuildBranch(string name)  //aka BuildComposite
        {
            JBranch node = new JBranch(name);
            _stack.Peek().AddChild(node);
            _stack.Push(node);
        }

        public void BuildLeaf(string name, string content)
        {
            JLeaf leaf = new JLeaf(name, content);
            _stack.Peek().AddChild(leaf);
        }

        public void CloseBranch()
        {
            if (_stack.Count != 1)
            {
                _stack.Pop();
            }
        }

        public IComposite GetDocument()
        {
            return _root;
        }
    }
}