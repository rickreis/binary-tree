using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TreeBinary.Tests
{
    [TestClass]
    public class TreeBinayService_Should
    {
        static IEnumerable<Tree<Ramification>> _treeRoot;

        [TestInitialize]
        public void Initialize()
        {
            _treeRoot = BuilderTree.Buider();
        }

        [TestMethod]
        public void Enter_number_9_result_1_4_2_12_13_9()
        {
            //arrange
            TreeBinaryService service = new TreeBinaryService();

            Tree<Ramification> tree = _treeRoot.FirstOrDefault(x => x.Data.Number == 9);

            //act
            IEnumerable<int> result = service.DoTree(tree);

            //assert
            Assert.AreEqual("[1,4,2,12,13,9]", String.Format("[{0}]", String.Join(",", result.Select(x => x))));            
        }

        [TestMethod]
        public void Enter_number_1_result_1()
        {
            //arrange
            TreeBinaryService service = new TreeBinaryService();

            Tree<Ramification> tree = _treeRoot.FirstOrDefault(x => x.Data.Number == 1);

            //act
            IEnumerable<int> result = service.DoTree(tree);

            //assert
            Assert.AreEqual("[1]", String.Format("[{0}]", String.Join(",", result.Select(x => x))));
        }

        [TestMethod]
        public void Enter_number_17_result_nothing()
        {
            //arrange
            TreeBinaryService service = new TreeBinaryService();

            Tree<Ramification> tree = _treeRoot.FirstOrDefault(x => x.Data.Number == 17);

            //act
            IEnumerable<int> result = service.DoTree(tree);

            //assert
            Assert.AreEqual("[]", String.Format("[{0}]", String.Join(",", result.Select(x => x))));
        }

        [TestMethod]
        public void Enter_number_4_result_1_4()
        {
            //arrange
            TreeBinaryService service = new TreeBinaryService();

            Tree<Ramification> tree = _treeRoot.FirstOrDefault(x => x.Data.Number == 4);

            //act
            IEnumerable<int> result = service.DoTree(tree);

            //assert
            Assert.AreEqual("[1,4]", String.Format("[{0}]", String.Join(",", result.Select(x => x))));
        }
    }
}
