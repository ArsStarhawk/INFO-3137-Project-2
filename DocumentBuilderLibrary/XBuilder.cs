using System.Collections.Generic;

namespace DocumentBuilderLibrary
{
    public class XBuilder : IBuilder
    {
        private XBranch _root;
        private Stack<XBranch> _stack;

        public XBuilder()
        {
            _root = new XBranch("root");
            _stack = new Stack<XBranch>();
            _stack.Push(_root);
        }

        public void BuildBranch(string name)
        {
            XBranch node = new XBranch(name);
            _stack.Peek().AddChild(node);
            _stack.Push(node);
        }

        public void BuildLeaf(string name, string content)
        {
            XLeaf leaf = new XLeaf(name, content);
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