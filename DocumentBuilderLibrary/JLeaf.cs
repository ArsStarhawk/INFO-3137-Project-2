namespace DocumentBuilderLibrary
{
    public class JLeaf : IComposite
    {
        private string _name;
        private string _content;

        public JLeaf(string name, string content)
        {
            _name = name;
            _content = content;
        }





        public void AddChild(IComposite child)
        {
            throw new System.NotImplementedException();
        }

        public string Print(int depth)
        {
            return "butts";
        }
    }
}