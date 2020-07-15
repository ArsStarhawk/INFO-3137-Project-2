namespace DocumentBuilderLibrary
{
    public class Director : IDirector
    {
        private IBuilder builder;

        private string name { get; set; }
        private string content { get; set; }

        public Director(string mode)
        {
            if (mode.Equals("JSON"))
            {
                builder = new JBuilder();
            }
            else
            {
                builder = new XBuilder();
            }
        }




        public void BuildBranch()
        {
            throw new System.NotImplementedException();
        }

        public void BuildLeaf()
        {
            throw new System.NotImplementedException();
        }

        public void CloseBranch()
        {
            throw new System.NotImplementedException();
        }
    }
}