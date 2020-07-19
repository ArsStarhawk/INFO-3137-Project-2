namespace DocumentBuilderLibrary
{
    public interface IComposite
    {
        void AddChild(IComposite child);

        string Print(int depth);
    }
}