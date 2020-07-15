namespace DocumentBuilderLibrary
{
    public class XLeaf: IComposite
    {
        private string _name;
        private string _content;

        public XLeaf(string name, string content)
        {
            _name = name;
            _content = content;
        }

        public void AddChild(IComposite child)
        {
        }

        public string Print(int depth)
        {
            throw new System.NotImplementedException();
        }
    }
}