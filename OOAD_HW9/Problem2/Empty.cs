namespace OOAD_HW9.Problem2
{
    // Leaf
    public class Empty : BinaryTree
    {
        private static Empty? _singltoneInstance;

        private Empty()
        {
        }

        public static Empty getInstance()
        {
            if (_singltoneInstance is null)
            {
                _singltoneInstance = new();
            }

            return _singltoneInstance;
        }

        public override int height()
        {
            return 0;
        }

        public override int NumberOfLeaves()
        {
            return 0;
        }

        public override int size()
        {
            return 0;
        }
    }
}
