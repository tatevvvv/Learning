using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_HW9.Problem2
{
    // Complex  unit
    internal class NonEmpty : BinaryTree
    {
        private string _root;

        private BinaryTree _leftSubtree;

        private BinaryTree _rightSubtree;

        // every component is either simple(Empty) or again composite (NonEmpty)
        private List<BinaryTree> _subElements = new List<BinaryTree>();

        public NonEmpty(BinaryTree leftSubtree, BinaryTree rightSubtree, string root)
        {
            if(leftSubtree is not null)
            {
                _subElements.Add(leftSubtree);
            }

            if(rightSubtree is not null)
            {
                _subElements.Add(rightSubtree);
            }

            _leftSubtree = leftSubtree;
            _rightSubtree = rightSubtree;
            _root = root;
        }

        //  Implements the polymorphic operation() through its
        // readdressing to components.
        public override int height()
        {
            return Math.Max(_leftSubtree.height(), _rightSubtree.height()) + 1;
        }

        //  Implements the polymorphic operation() through its
        // readdressing to components.
        public override int NumberOfLeaves()
        {
            if(_leftSubtree == Empty.getInstance() && _rightSubtree == Empty.getInstance())
            {
                return 1;
            }

            var result = 0;
            foreach (BinaryTree subElement in _subElements)
            {
                result += subElement.NumberOfLeaves();
            }

            return result;
        }

        //  Implements the polymorphic operation() through its
        // readdressing to components.
        public override int size()
        {
            int result = 1;
            foreach (BinaryTree subElement in _subElements)
            {
                result += subElement.size();
            }

            return result;
        }
    }
}
