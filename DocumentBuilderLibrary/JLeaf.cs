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
        }

        public string Print(int depth)
        {
            string indent = new string(' ', depth *3);
            return $"\n{indent} \"{_name}\": \"{_content}\"";
        }
    }
}