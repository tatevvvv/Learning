using System.Collections;

namespace Trees
{
    internal abstract class AbstractTree<E> : ITree<E>
    {
        public abstract IEnumerable<IPosition<E>> Children(IPosition<E> p);

        public IEnumerator<E> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            return Size() == 0;
        }

        public bool IsExternal(IPosition<E> p)
        {
            return NumChildren(p) == 0;
        }

        public bool IsInternal(IPosition<E> p)
        {
            return NumChildren(p) > 0;
        }

        public bool IsRoot(IPosition<E> p)
        {
            return p == Root();
        }

        public IEnumerator<E> Iterator()
        {
            throw new NotImplementedException();
        }

        public int NumChildren(IPosition<E> p)
        {
            if (IsExternal(p)) return 0;

            var result = 0;
            foreach (var c in Children(p))
            {
                result++;
            }

            return result;
        }

        public abstract IPosition<E> Parent(IPosition<E> p);

        public abstract IPosition<E> Root();

        public int Size()
        {
            int count = 0;
            foreach (var p in Positions())
            {
                count++;
            }
            return count;
        }

        // the depth of p is the number of ancestors other than p. Time complexity is O(dp + 1), worst case is O(n), best case is O(1).
        public int Depth(IPosition<E> p)
        {
            if (p == Root()) return 0;

            return 1 + Depth(Parent(p));
        }

        // Ancestor of p is all u, where u = p or u = p.Parent recursively.
        public List<IPosition<E>> Ancestors(IPosition<E> p)
        {
            var result = new List<IPosition<E>>();

            while (p != Root())
            {
                result.Add(p);
                p = Parent(p);
            }

            result.Add(Root());

            return result;
        }

        // bad algorithm for computing height.
        // Height of tree is the max depth of leaves. Quadratic complexity
        private int HeightBad()
        {
            int result = 0;

            foreach (var p in Positions().Where(p => IsExternal(p)))
            {
                result = Math.Max(result, Depth(p));
            }

            return result;
        }

        // complexity of the method is O(n).
        private int Height(IPosition<E> p)
        {
            var h = 0;

            foreach (var c in Children(p))
            {
                h = Math.Max(h, 1 + Height(c));
            }

            return h;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Positions().GetEnumerator();
        }

        public IEnumerable<IPosition<E>> Positions()
        {
            return BreadFirst();
        }

        public IEnumerable<IPosition<E>> PostOrderTraversal()
        {
            if (!IsEmpty())
            {
                return PostOrderPrivate(Root());
            }

            return Enumerable.Empty<IPosition<E>>();

            IEnumerable<IPosition<E>> PostOrderPrivate(IPosition<E> p)
            {
                foreach (var c in Children(p))
                {
                    PostOrderPrivate(c);
                }

                yield return p;
            }
        }

        public IEnumerable<IPosition<E>> PreOrderTraversal()
        {
            if (!IsEmpty())
            {
                return PreOrderPrivate(Root());
            }

            return Enumerable.Empty<IPosition<E>>();
        }

        private IEnumerable<IPosition<E>> PreOrderPrivate(IPosition<E> p)
        {
            yield return p;
            foreach (var c in Children(p))
            {
                PreOrderPrivate(c);
            }
        }

        public IEnumerable<IPosition<E>> BreadFirst()
        {
            if (!IsEmpty())
            {
                var queue = new Queue<IPosition<E>>();

                queue.Enqueue(Root());

                while (queue.Count > 0)
                {
                    var p = queue.Dequeue();
                    yield return p;

                    foreach (var c in Children(p))
                    {
                        queue.Enqueue(c);
                    }
                }
            }
        }
    }
}
