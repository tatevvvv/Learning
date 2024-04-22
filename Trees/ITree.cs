namespace Trees
{
    public interface ITree<E> : IEnumerable<E>
    {
        IPosition<E> Root();

        IPosition<E> Parent(IPosition<E> p);

        IEnumerable<IPosition<E>> Children(IPosition<E> p);

        int NumChildren(IPosition<E> p);

        bool IsInternal(IPosition<E> p);

        bool IsExternal(IPosition<E> p);

        bool IsRoot(IPosition<E> p);

        int Size();

        bool IsEmpty();

        IEnumerator<E> Iterator();

        IEnumerable<IPosition<E>> Positions();
    }
}
