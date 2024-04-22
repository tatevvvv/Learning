namespace OOAD_HW9.Problem2
{
    internal class Client
    {
        private BinaryTree binaryTree;

        public Client(BinaryTree binaryTree)
        {
            this.binaryTree = binaryTree;
        }

        public int getSize()
        {
            return binaryTree.size();
        }

        public int getHeight()
        {
            return binaryTree.height();
        }

        public int getNumberOfLeaves()
        {
            return binaryTree.NumberOfLeaves();
        }
    }
}
