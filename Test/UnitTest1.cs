using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ex58____Trees;
using System.Collections.Generic;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestBST()
        {
            int[] data = { 47, 22, 68, 9, 33, 53, 88, 5, 17, 29, 46, 48 };
            List<int> controlList = new List<int>(data);
            controlList.Sort();

            MyBST<int> bst = new MyBST<int>();
            foreach (int intData in data)
            {
                bst.Insert(intData);
            }

            List<int> inOrderList = bst.InOrder();
            Assert.AreEqual(controlList.Count, inOrderList.Count);
            for (int i = 0; i < controlList.Count; i++)
            {
                Assert.AreEqual(controlList[i], inOrderList[i]);
            }
        }
        [TestMethod]
        public void TestPreOrderTrav()
        {
            int[] data = { 47, 22, 68, 9, 33, 53, 88, 5, 17, 29, 46, 48 };
            MyBST<int> my = new MyBST<int>();
            foreach (int item in data)
            {
                my.Insert(item);
            }

            List<int> preorder = new List<int>() { 47, 22, 9, 5, 17, 33, 29, 46, 68, 53, 48, 88 };

            for (int i = 0; i < preorder.Count; i++)
            {
                Assert.AreEqual(my.PreOrderTrav()[i], preorder[i]);
            }
        }
        [TestMethod]
        public void TestPostOrderTrav()
        {
            int[] data = { 47, 22, 68, 9, 33, 53, 88, 5, 17, 29, 46, 48 };
            MyBST<int> my = new MyBST<int>();
            foreach (int item in data)
            {
                my.Insert(item);
            }

            List<int> postorder = new List<int>() { 22, 9, 5, 17, 33, 29, 16, 68, 53, 48, 88, 47 };

            for (int i = 0; i < postorder.Count; i++)
            {
                Assert.AreEqual(my.PostOrderTrav()[i], postorder[i]);
            }
        }
    }
}
