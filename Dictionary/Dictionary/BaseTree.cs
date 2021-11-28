using System;


namespace Dictionary
{
    public class BaseTree<T> : Tree<T, BaseComparer<T>> where T : IComparable<T>
    {
        public BaseTree(bool isUnique) : base(isUnique)
        {

        }
    }
}
