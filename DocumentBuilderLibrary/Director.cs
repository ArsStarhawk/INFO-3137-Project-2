namespace DocumentBuilderLibrary
{
    public class Director : IDirector
    {
        private IBuilder builder;

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