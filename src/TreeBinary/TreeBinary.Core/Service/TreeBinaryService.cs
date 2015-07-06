using System.Linq;
using System.Collections.Generic;
using System;

namespace TreeBinary
{
    public class TreeBinaryService
    {
        public IEnumerable<int> DoTree(IEnumerable<Tree<Ramification>> tree, int number)
        {
            ICollection<int> result = new List<int>();

            if (tree == null || tree.Any() == false)
                return result;

            Tree<Ramification> ramification = tree.FirstOrDefault(x => x.Data.Number == number);

            if (ramification == null || ramification.Data == null)
                return result;

            result.Add(ramification.Data.Number);

            DoTree(ramification, ref result);

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
