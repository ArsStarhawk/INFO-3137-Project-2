namespace DocumentBuilderLibrary
{
    public class XLeaf: IComposite
    {
        private string name;
        private string content;

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