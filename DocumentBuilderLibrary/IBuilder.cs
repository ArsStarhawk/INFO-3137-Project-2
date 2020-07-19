/*
 * Author: James Kidd
 * Date: July, 19 - 2020
 * 
 */

namespace DocumentBuilderLibrary
{
    public interface IBuilder
    {
        void BuildBranch(string name);
        void BuildLeaf(string name, string content);
        void CloseBranch();
        IComposite GetDocument();
    }
}