using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trees;

namespace Iterator
{
    public class Tree : IEnumerable<TreeNode>
    {
        private TreeNode _root;

        public Tree(TreeNode root)
        {
            _root = root;
        }

        public IEnumerator<TreeNode> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new BSTIterator(_root);
        }
    }
}
