using System.Collections;
using Trees;

namespace Iterator
{
    public class BSTIterator : IEnumerator<int>
    {
        private List<int> _snapshot;
        private TreeNode _root;
        private int _cursor;
        private int _current;

        public BSTIterator(TreeNode root)
        {
            _root = root;
            _snapshot = new List<int>();
            _cursor = 0;

            InOrderPrivate(_root, _snapshot);

            void InOrderPrivate(TreeNode? node, List<int> snapshot)
            {
                if (node == null) { return; }

                InOrderPrivate(node.left, snapshot);
                _snapshot.Add(node.val);
                InOrderPrivate(node.right, snapshot);
            }
        }

        public int Current => _current;

        object IEnumerator.Current => _current;

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if (_cursor < _snapshot.Count)
            {
                _current = _snapshot[_cursor++];
                return true;
            }

            return false;
        }

        public void Reset()
        {
            _snapshot.Clear();

            InOrderPrivate(_root, _snapshot);

            void InOrderPrivate(TreeNode? node, List<int> snapshot)
            {
                if (node == null) { return; }

                InOrderPrivate(node.left, snapshot);
                _snapshot.Add(node.val);
                InOrderPrivate(node.right, snapshot);
            }
        }
    }
}
