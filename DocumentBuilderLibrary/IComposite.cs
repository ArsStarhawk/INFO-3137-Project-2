/*
 * Author: James Kidd
 * Date: July, 19 - 2020
 * 
 */

namespace DocumentBuilderLibrary
{
    public interface IComposite
    {
        void AddChild(IComposite child);

        string Print(int depth);
    }
}