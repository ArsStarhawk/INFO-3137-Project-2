/*
 * Author: James Kidd
 * Date: July, 19 - 2020
 * 
 */

using System.Collections.Generic;
using System.Linq;

namespace DocumentBuilderLibrary
{
    public class JBranch : IComposite
    {
        private List<IComposite> _children;
        private string _name;

        public JBranch(string name)
        {
            _name = name;
            _children = new List<IComposite>();
        }

        public void AddChild(IComposite child)
        {
            _children.Add(child);
        }

        public string Print(int depth)
        {

            string indent = new string(' ', depth *3);

            string rtnStr = _name.Equals("root") 
                ? $"\n{indent}{{" 
                : $"\n{indent} \"{_name}\":\n{indent}{{";

            foreach (IComposite child in _children)
            {
                rtnStr += child.Print(depth + 1);
                if (!child.Equals(_children.Last()))
                {
                    rtnStr += ',';
                }
            }

            rtnStr += $"\n{indent}}}";
            return rtnStr;
        }
    }
}