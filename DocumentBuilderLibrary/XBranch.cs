/*
 * Author: James Kidd
 * Date: July, 19 - 2020
 * 
 */

using System.Collections.Generic;

namespace DocumentBuilderLibrary
{
    public class XBranch : IComposite
    {
        private List<IComposite> _children;
        private string _name;

        public XBranch(string name)
        {
            _children = new List<IComposite>();
            _name = name;
        }


        public void AddChild(IComposite child)
        {
            _children.Add(child);
        }

        public string Print(int depth)
        {
            string indent = new string('\t', depth);
            string rtnStr = $"\n{indent}<{_name}>";

            foreach (IComposite child in _children)
            {
               rtnStr += child.Print(depth+1);
            }

            rtnStr += $"\n{indent}</{_name}>";
            return rtnStr;
        }
    }
}