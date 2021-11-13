using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsPlayground.DataStructures.Lists
{
    [TestClass]
    public class SingleLinkedListTests
    {
        [TestMethod]
        public void IsEmptyTest()
        {
            var list = new SingleLinkedList();
            Assert.IsTrue(list.IsEmpty(), "A new list should be empty");
            
            list.AddToHead(3);
            Assert.IsFalse(list.IsEmpty(), "A list with elements should not be empty");
        }

        [TestMethod]
        public void GetAtIndexTest()
        {
            var list = MakeTestList();

            Assert.AreEqual(6, list.GetAtIndex(0), "The first element of the list should be 6");
            Assert.AreEqual(4, list.GetAtIndex(1), "The second element of the list should be 4");
        }

        [TestMethod]
        public void GetAtIndexOutOfBoundsTest()
        {
            var list = MakeTestList();

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => {
                list.GetAtIndex(100);
            }, "When requesting an object out of range an ArgumentOutOfRangeException should be thrown");

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => {
                list.GetAtIndex(-1);
            }, "When requesting an object on a negative index an ArgumentOutOfRangeException should be thrown");
        }

        [TestMethod]
        public void GetAtIndexEmptyListTest()
        {
            var list = new SingleLinkedList();

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => {
                list.GetAtIndex(0);
            }, "When requesting an object out of range an ArgumentOutOfRangeException should be thrown");
        }

        [TestMethod]
        public void CountElementsTest()
        {
            var list1 = new SingleLinkedList();
            Assert.AreEqual(0, list1.Count, "An empty list should report a 0 count");

            var list2 = MakeTestList();

            Assert.AreEqual(3, list2.Count, "The list should declare it has 3 elements");
        }

        [TestMethod]
        public void DeleteAtIndexTest()
        {
            var list = MakeTestList();

            var deletedElement = list.DeleteAtIndex(1);
            Assert.AreEqual(4, deletedElement, "The the list has a 4 on the index 1 position");
            Assert.AreEqual(2, list.Count, "The list should declare it has 2 elements");
        }

        [TestMethod]
        public void DeleteAtIndexEmptyListTest()
        {
            var list = new SingleLinkedList();
            
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => {
                list.DeleteAtIndex(0);
            }, "When deleting an object out of range an ArgumentOutOfRangeException should be thrown");
        }
        
        [TestMethod]
        public void DeleteAtIndexOutOfBoundsTest()
        {
            var list = MakeTestList();

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => {
                list.DeleteAtIndex(5);
            }, "When deleting an object out of range an ArgumentOutOfRangeException should be thrown");

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => {
                list.DeleteAtIndex(-1);
            }, "When deleting an object on a negative index ArgumentOutOfRangeException should be thrown");
        }

        [TestMethod]
        public void GetNodeAtIndexTest()
        {
            var list = MakeTestList();

            Assert.AreEqual(3, list.Count, "The list should declare it has 3 elements");
            Assert.AreEqual(6, list.GetNodeAtIndex(0).Value, "The first element of the list should be 6");
            Assert.AreEqual(4, list.GetNodeAtIndex(1).Value, "The second element of the list should be 6");
            Assert.AreEqual(3, list.GetNodeAtIndex(2).Value, "The third element of the list should be 6");
        }

        [TestMethod]
        public void GetNodeAtIndexEmptyListTest()
        {
            var list = new SingleLinkedList();
            
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => {
                list.GetNodeAtIndex(0);
            }, "When deleting an object out of range an ArgumentOutOfRangeException should be thrown");
        }
        
        [TestMethod]
        public void GetNodeAtIndexOutOfBoundsTest()
        {
            var list = MakeTestList();

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => {
                list.GetNodeAtIndex(5);
            }, "When deleting an object out of range an ArgumentOutOfRangeException should be thrown");

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => {
                list.GetNodeAtIndex(-1);
            }, "When deleting an object on a negative index ArgumentOutOfRangeException should be thrown");
        }

        [TestMethod]
        public void RemoveDuplicatesTest()
        {
            var list = MakeTestList();
            list.AddToHead(3);
            list.AddToHead(8);

            list.RemoveDuplicates();

            Assert.AreEqual("8 3 6 4", list.ToString(), "remove duplicates failed");

            Assert.AreEqual(8, list.GetAtIndex(0), "The first element of the list should be 8");
            Assert.AreEqual(3, list.GetAtIndex(1), "The second element of the list should be 6");
            Assert.AreEqual(6, list.GetAtIndex(2), "The third element of the list should be 4");
            Assert.AreEqual(4, list.GetAtIndex(3), "The third element of the list should be 3");
        }

        // A helper function to get a simple list created
        private SingleLinkedList MakeTestList()
        {
            var list = new SingleLinkedList();
            list.AddToHead(3);
            list.AddToHead(4);
            list.AddToHead(6);

            return list;
        }
    }
}
