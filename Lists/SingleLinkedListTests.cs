using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsPlayground.Lists
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
    }
}
