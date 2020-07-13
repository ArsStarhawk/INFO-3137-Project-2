using System.Collections.Generic;

namespace DocumentBuilderLibrary
{
    public class JBuilder : IBuilder
    {
        private JBranch root;
        private List<JBranch> list;

        public void BuildBranch(string name)
        {
            throw new System.NotImplementedException();
        }

        public void BuildLeaf(string name, string content)
        {
            throw new System.NotImplementedException();
        }

        public void CloseBranch()
        {
            throw new System.NotImplementedException();
        }

        public IComposite GetDocument()
        {
            throw new System.NotImplementedException();
        }
    }
}