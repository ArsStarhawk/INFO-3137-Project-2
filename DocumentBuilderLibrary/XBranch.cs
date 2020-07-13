using System.Collections.Generic;

namespace DocumentBuilderLibrary
{
    public class XBranch : IComposite
    {
        private List<IComposite> list;
        private string name;


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