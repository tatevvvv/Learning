namespace Trees
{
    public interface IBinaryTree<E> : ITree<E>
    {

        /**
         * Returns the Position of p's left child (or null if no child exists).
         *
         * @param p A valid Position within the tree
         * @return the Position of the left child (or null if no child exists)
         * @throws IllegalArgumentException if p is not a valid Position for this tree
         */
        IPosition<E> left(IPosition<E> p);

        /**
         * Returns the Position of p's right child (or null if no child exists).
         *
         * @param p A valid Position within the tree
         * @return the Position of the right child (or null if no child exists)
         * @throws IllegalArgumentException if p is not a valid Position for this tree
         */
        IPosition<E> right(IPosition<E> p);

        /**
         * Returns the Position of p's sibling (or null if no sibling exists).
         *
         * @param p A valid Position within the tree
         * @return the Position of the sibling (or null if no sibling exists)
         * @throws IllegalArgumentException if p is not a valid Position for this tree
         */
        IPosition<E> sibling(IPosition<E> p);
    }
}
