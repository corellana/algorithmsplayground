using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsPlayground.DataStructures.Lists
{
    [TestClass]
    public class SingleLinkedListTests
    {
        [TestMethod]
        public void AddElementsTest()
        {
            var list = new SingleLinkedList();

            list.AddToHead(3);
            list.AddToHead(4);
            list.AddToHead(6);
        }

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
            var list = new SingleLinkedList();
            list.AddToHead(3);
            list.AddToHead(4);
            list.AddToHead(6);

            Assert.AreEqual(6, list.GetAtIndex(0), "The first element of the list should be 6");
            Assert.AreEqual(4, list.GetAtIndex(1), "The second element of the list should be 4");
        }
        
        [TestMethod]
        public void GetAtIndexOutOfBoundsTest()
        {
            var list = new SingleLinkedList();
            list.AddToHead(3);
            list.AddToHead(4);
            list.AddToHead(6);

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
            var list = new SingleLinkedList();
            Assert.AreEqual(0, list.Count, "An empty list should report a 0 count");

            list.AddToHead(3);
            list.AddToHead(4);
            list.AddToHead(6);

            Assert.AreEqual(3, list.Count, "The list should declare it has 3 elements");
        }

        [TestMethod]
        public void DeleteAtIndexTest()
        {
            var list = new SingleLinkedList();
            list.AddToHead(3);
            list.AddToHead(4);
            list.AddToHead(6);

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
            var list = new SingleLinkedList();
            list.AddToHead(3);
            list.AddToHead(4);
            list.AddToHead(6);

            
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => {
                list.DeleteAtIndex(5);
            }, "When deleting an object out of range an ArgumentOutOfRangeException should be thrown");

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => {
                list.DeleteAtIndex(-1);
            }, "When deleting an object on a negative index ArgumentOutOfRangeException should be thrown");

        }


        [TestMethod]
        public void AddToTailTest()
        {
            var list = new SingleLinkedList();
            list.AddToTail(3);
            list.AddToHead(4);
            list.AddToTail(6);

            Assert.AreEqual(3, list.Count, "The list should declare it has 3 elements");
            Assert.AreEqual(4, list.GetAtIndex(0), "The first element of the list should be 6");
            Assert.AreEqual(3, list.GetAtIndex(1), "The second element of the list should be 6");
            Assert.AreEqual(6, list.GetAtIndex(2), "The third element of the list should be 6");
        }
    }
}
