using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TreeBinary.Tests
{
    [TestClass]
    public class TreeBinayService_Should
    {
        static IEnumerable<Tree<Ramification>> _tree;

        [TestInitialize]
        public void Initialize()
        {
            _tree = BuilderTree.Buider();
        }

        [TestMethod]
        public void Enter_number_9_result_1_4_2_12_13_9()
        {
            //arrange
            TreeBinaryService service = new TreeBinaryService();            

            //act
            IEnumerable<int> result = service.DoTree(_tree, 9);

            //assert
            Assert.AreEqual("[1,4,2,12,13,9]", String.Format("[{0}]", String.Join(",", result.Select(x => x))));            
        }

        [TestMethod]
        public void Enter_number_1_result_1()
        {
            //arrange
            TreeBinaryService service = new TreeBinaryService();            

            //act
            IEnumerable<int> result = service.DoTree(_tree, 1);

            //assert
            Assert.AreEqual("[1]", String.Format("[{0}]", String.Join(",", result.Select(x => x))));
        }

        [TestMethod]
        public void Enter_number_17_result_nothing()
        {
            //arrange
            TreeBinaryService service = new TreeBinaryService();            

            //act
            IEnumerable<int> result = service.DoTree(_tree, 17);

            //assert
            Assert.AreEqual("[]", String.Format("[{0}]", String.Join(",", result.Select(x => x))));
        }

        [TestMethod]
        public void Enter_number_4_result_1_4()
        {
            //arrange
            TreeBinaryService service = new TreeBinaryService();            

            //act
            IEnumerable<int> result = service.DoTree(_tree, 4);

            //assert
            Assert.AreEqual("[1,4]", String.Format("[{0}]", String.Join(",", result.Select(x => x))));
        }

        [TestMethod]
        public void Result_empty_when_tree_invalid()
        {
            //arrange
            TreeBinaryService service = new TreeBinaryService();            

            //act
            IEnumerable<int> result = service.DoTree(null, 0);

            //assert
            Assert.IsFalse(result.Any());
        }

        [TestMethod]
        public void Result_empty_when_tree_not_any_info()
        {
            //arrange
            TreeBinaryService service = new TreeBinaryService();

            //act
            IEnumerable<int> result = service.DoTree(new List<Tree<Ramification>>(), 0);

            //assert
            Assert.IsFalse(result.Any());
        }
    }
}
