using System.Linq;
using System.Collections.Generic;

namespace TreeBinary
{
    public class TreeBinaryService
    {
        public IEnumerable<int> DoTree(Tree<Ramification> tree)
        {
            ICollection<int> result = new List<int>();

            if (tree == null || tree.Data == null)
                return result;

            result.Add(tree.Data.Number);

            DoTree(tree, ref result);

            return result.Reverse();
        }

        private IEnumerable<int> DoTree(Tree<Ramification> tree, ref ICollection<int> result)
        {
            if (tree == null)
                return result;

            if (tree.Left != null)
                result.Add(tree.Left.Data.Number);

            if (tree.Right != null)
                result.Add(tree.Right.Data.Number);

            DoTree(tree.Left, ref result);
            DoTree(tree.Right, ref result);

            return result;
        }
    }
}
