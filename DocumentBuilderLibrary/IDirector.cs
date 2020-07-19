/*
 * Author: James Kidd
 * Date: July, 19 - 2020
 * 
 */

namespace DocumentBuilderLibrary
{
    public interface IDirector
    {
        void BuildBranch();
        void BuildLeaf();
        void CloseBranch();
    }
}