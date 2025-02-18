using NUnit.Framework;
using System.Collections.Generic;

namespace TestProject1
{
    public class Tests
    {
        #region Stacks

        private readonly Stack<uint> stack1 = new Stack<uint>(new uint[] { 2, 34, 67, 89, 12, 45, 78, 56, 23, 90, 14, 38 });
        private readonly Stack<uint> stack2 = new Stack<uint>(new uint[] { 3, 19, 72, 84, 41, 95, 31, 50, 68, 21 });
        private readonly Stack<uint> stack3 = new Stack<uint>(new uint[] { 8, 18, 40, 60, 77, 60, 35, 91, 36, 52, 48 });
        private readonly Stack<uint> stack4 = new Stack<uint>(new uint[] { 7, 22, 55, 88, 96, 11, 47, 71, 39, 66, 93, 31, 25 });
        private readonly Stack<uint> stack5 = new Stack<uint>(new uint[] { 24, 26, 60, 85, 58, 56, 80, 63, 74, 92, 33, 49 });
        private readonly Stack<uint> stack6 = new Stack<uint>(new uint[] { 30, 20, 17, 53, 44, 61, 32, 86, 75, 94, 59 });
        private readonly Stack<uint> stack7 = new Stack<uint>(new uint[] { 22, 42, 80, 28, 51, 64, 82, 15, 100, 35, 57, 99 });
        private readonly Stack<uint> stack8 = new Stack<uint>(new uint[] { 40, 16, 54, 70, 81, 46, 87, 10, 98, 27, 90 });
        private readonly Stack<uint> stack9 = new Stack<uint>(new uint[] { 37, 65, 62, 9, 76, 24, 69, 14, 90, 55, 50 });
        private readonly Stack<uint> stack10 = new Stack<uint>(new uint[] { 11, 38, 67, 12, 48, 95, 22, 68, 44, 81, 31, 99 });

        private readonly Stack<uint> noFirstPrimeStack1 = new Stack<uint>(new uint[] { 2, 34, 67, 89, 12, 45, 78, 56, 90, 14, 38 });
        private readonly Stack<uint> noFirstPrimeStack2 = new Stack<uint>(new uint[] { 3, 19, 72, 84, 41, 95, 50, 68, 21 });
        private readonly Stack<uint> noFirstPrimeStack4 = new Stack<uint>(new uint[] { 7, 22, 55, 88, 96, 11, 47, 71, 39, 66, 93, 25 });
        private readonly Stack<uint> noFirstPrimeStack6 = new Stack<uint>(new uint[] { 30, 20, 17, 53, 44, 61, 32, 86, 75, 94 });
        private readonly Stack<uint> noFirstPrimeStack9 = new Stack<uint>(new uint[] { 65, 62, 9, 76, 24, 69, 14, 90, 55, 50 });
        private readonly Stack<uint> noFirstPrimeStack10 = new Stack<uint>(new uint[] { 11, 38, 67, 12, 48, 95, 22, 68, 44, 81, 99 });

        private Stack<uint>
            copyStack1, copyStack2, copyStack3,
            copyStack4, copyStack5, copyStack6,
            copyStack7, copyStack8, copyStack9, copyStack10;

        #endregion Stacks

        #region Queues

        private readonly Queue<uint> queue1 = new Queue<uint>(new uint[] { 38, 14, 90, 23, 56, 78, 45, 12, 89, 67, 34, 2 });
        private readonly Queue<uint> queue2 = new Queue<uint>(new uint[] { 21, 68, 50, 31, 95, 41, 84, 72, 19, 3 });
        private readonly Queue<uint> queue3 = new Queue<uint>(new uint[] { 48, 52, 36, 91, 35, 60, 77, 60, 40, 18, 8 });
        private readonly Queue<uint> queue4 = new Queue<uint>(new uint[] { 25, 31, 93, 66, 39, 71, 47, 11, 96, 88, 55, 22, 7 });
        private readonly Queue<uint> queue5 = new Queue<uint>(new uint[] { 49, 33, 92, 74, 63, 80, 56, 58, 85, 60, 26, 24 });
        private readonly Queue<uint> queue6 = new Queue<uint>(new uint[] { 59, 94, 75, 86, 32, 61, 44, 53, 17, 20, 30 });
        private readonly Queue<uint> queue7 = new Queue<uint>(new uint[] { 99, 57, 35, 100, 15, 82, 64, 51, 28, 80, 42, 22 });
        private readonly Queue<uint> queue8 = new Queue<uint>(new uint[] { 90, 27, 98, 10, 87, 46, 81, 70, 54, 16, 40 });
        private readonly Queue<uint> queue9 = new Queue<uint>(new uint[] { 50, 55, 90, 14, 69, 24, 76, 9, 62, 65, 37 });
        private readonly Queue<uint> queue10 = new Queue<uint>(new uint[] { 99, 31, 81, 44, 68, 22, 95, 48, 12, 67, 38, 11 });

        #endregion Queues

        #region Lists

        private readonly List<int> list1 = new List<int> { -50, 23, 87, -12, 4, 95, -66, 8, 32, -71, 42, -18 };
        private readonly List<int> list2 = new List<int> { 19, -5, 77, 33, -92, 41, -60, 58, -9, 84 };
        private readonly List<int> list3 = new List<int> { -99, 100, -34, 76, -88, 45, 11, -7, 24, 62, -56, 90, -19, 38 };
        private readonly List<int> list4 = new List<int> { 3, -22, 88, -44, 55, -78, 91, -6, 17, -25, 70, -11 };
        private readonly List<int> list5 = new List<int> { -30, 27, 95, -64, 81, -50, 33, -12, 59, -78, 99, -4, 66, -19 };
        private readonly List<int> list6 = new List<int> { -18, 72, -85, 44, 9, -56, 61, -2, 89, -91 };

        private readonly List<int> sortedList1 = new List<int> { -71, -66, -50, -18, -12, 4, 8, 23, 32, 42, 87, 95 };
        private readonly List<int> sortedList2 = new List<int> { -92, -60, -9, -5, 19, 33, 41, 58, 77, 84 };
        private readonly List<int> sortedList3 = new List<int> { -99, -88, -56, -34, -19, -7, 11, 24, 38, 45, 62, 76, 90, 100 };
        private readonly List<int> sortedList4 = new List<int> { -78, -44, -25, -22, -11, -6, 3, 17, 55, 70, 88, 91 };
        private readonly List<int> sortedList5 = new List<int> { -78, -64, -50, -30, -19, -12, -4, 27, 33, 59, 66, 81, 95, 99 };
        private readonly List<int> sortedList6 = new List<int> { -91, -85, -56, -18, -2, 9, 44, 61, 72, 89 };

        private List<int>
            copyList1, copyList2, copyList3,
            copyList4, copyList5, copyList6;

        #endregion Lists

        [TearDown]
        public void ResetAll()
        {
            ClearStacks();
            ClearLists();
        }

        private void SetupTestLists()
        {
            copyList1 = list1.Copy();
            copyList2 = list2.Copy();
            copyList3 = list3.Copy();
            copyList4 = list4.Copy();
            copyList5 = list5.Copy();
            copyList6 = list6.Copy();
        }

        private void SetupTestStacks()
        {
            copyStack1 = stack1.Copy();
            copyStack2 = stack2.Copy();
            copyStack3 = stack3.Copy();
            copyStack4 = stack4.Copy();
            copyStack5 = stack5.Copy();
            copyStack6 = stack6.Copy();
            copyStack7 = stack7.Copy();
            copyStack8 = stack8.Copy();
            copyStack9 = stack9.Copy();
            copyStack10 = stack10.Copy();
        }

        private void ClearLists()
        {
            copyList1.ClearAll();
            copyList2.ClearAll();
            copyList3.ClearAll();
            copyList4.ClearAll();
            copyList5.ClearAll();
            copyList6.ClearAll();
        }

        private void ClearStacks()
        {
            copyStack1.ClearAll();
            copyStack2.ClearAll();
            copyStack3.ClearAll();
            copyStack4.ClearAll();
            copyStack5.ClearAll();
            copyStack6.ClearAll();
            copyStack7.ClearAll();
            copyStack8.ClearAll();
            copyStack9.ClearAll();
            copyStack10.ClearAll();
        }

        [Test]
        public void TestStackFirstPrime()
        {
            SetupTestStacks();

            Assert.AreEqual(23, TestMethods.StackFirstPrime(copyStack1));
            Assert.AreEqual(31, TestMethods.StackFirstPrime(copyStack2));
            Assert.AreEqual(0, TestMethods.StackFirstPrime(copyStack3));
            Assert.AreEqual(31, TestMethods.StackFirstPrime(copyStack4));
            Assert.AreEqual(0, TestMethods.StackFirstPrime(copyStack5));
            Assert.AreEqual(59, TestMethods.StackFirstPrime(copyStack6));
            Assert.AreEqual(0, TestMethods.StackFirstPrime(copyStack7));
            Assert.AreEqual(0, TestMethods.StackFirstPrime(copyStack8));
            Assert.AreEqual(37, TestMethods.StackFirstPrime(copyStack9));
            Assert.AreEqual(31, TestMethods.StackFirstPrime(copyStack10));
        }

        [Test]
        public void TestRemoveFirstPrime()
        {
            SetupTestStacks();

            Assert.IsTrue(noFirstPrimeStack1.HasSameElementsAtIndeces(TestMethods.RemoveFirstPrime(copyStack1)));
            Assert.IsTrue(noFirstPrimeStack2.HasSameElementsAtIndeces(TestMethods.RemoveFirstPrime(copyStack2)));
            Assert.IsTrue(stack3.HasSameElementsAtIndeces(TestMethods.RemoveFirstPrime(copyStack3)));
            Assert.IsTrue(noFirstPrimeStack4.HasSameElementsAtIndeces(TestMethods.RemoveFirstPrime(copyStack4)));
            Assert.IsTrue(stack5.HasSameElementsAtIndeces(TestMethods.RemoveFirstPrime(copyStack5)));
            Assert.IsTrue(noFirstPrimeStack6.HasSameElementsAtIndeces(TestMethods.RemoveFirstPrime(copyStack6)));
            Assert.IsTrue(stack7.HasSameElementsAtIndeces(TestMethods.RemoveFirstPrime(copyStack7)));
            Assert.IsTrue(stack8.HasSameElementsAtIndeces(TestMethods.RemoveFirstPrime(copyStack8)));
            Assert.IsTrue(noFirstPrimeStack9.HasSameElementsAtIndeces(TestMethods.RemoveFirstPrime(copyStack9)));
            Assert.IsTrue(noFirstPrimeStack10.HasSameElementsAtIndeces(TestMethods.RemoveFirstPrime(copyStack10)));
        }

        [Test]
        public void TestCreateQueueFromStack()
        {
            SetupTestStacks();

            Assert.IsTrue(queue1.HasSameElementsAtIndeces(TestMethods.CreateQueueFromStack(copyStack1)));
            Assert.IsTrue(queue2.HasSameElementsAtIndeces(TestMethods.CreateQueueFromStack(copyStack2)));
            Assert.IsTrue(queue3.HasSameElementsAtIndeces(TestMethods.CreateQueueFromStack(copyStack3)));
            Assert.IsTrue(queue4.HasSameElementsAtIndeces(TestMethods.CreateQueueFromStack(copyStack4)));
            Assert.IsTrue(queue5.HasSameElementsAtIndeces(TestMethods.CreateQueueFromStack(copyStack5)));
            Assert.IsTrue(queue6.HasSameElementsAtIndeces(TestMethods.CreateQueueFromStack(copyStack6)));
            Assert.IsTrue(queue7.HasSameElementsAtIndeces(TestMethods.CreateQueueFromStack(copyStack7)));
            Assert.IsTrue(queue8.HasSameElementsAtIndeces(TestMethods.CreateQueueFromStack(copyStack8)));
            Assert.IsTrue(queue9.HasSameElementsAtIndeces(TestMethods.CreateQueueFromStack(copyStack9)));
            Assert.IsTrue(queue10.HasSameElementsAtIndeces(TestMethods.CreateQueueFromStack(copyStack10)));
        }

        [Test]
        public void TestStackToList()
        {
            SetupTestStacks();

            Assert.IsTrue(stack1.HasSameElementsAtIndeces(TestMethods.StackToList(copyStack1)));
            Assert.IsTrue(stack2.HasSameElementsAtIndeces(TestMethods.StackToList(copyStack2)));
            Assert.IsTrue(stack3.HasSameElementsAtIndeces(TestMethods.StackToList(copyStack3)));
            Assert.IsTrue(stack4.HasSameElementsAtIndeces(TestMethods.StackToList(copyStack4)));
            Assert.IsTrue(stack5.HasSameElementsAtIndeces(TestMethods.StackToList(copyStack5)));
            Assert.IsTrue(stack6.HasSameElementsAtIndeces(TestMethods.StackToList(copyStack6)));
            Assert.IsTrue(stack7.HasSameElementsAtIndeces(TestMethods.StackToList(copyStack7)));
            Assert.IsTrue(stack8.HasSameElementsAtIndeces(TestMethods.StackToList(copyStack8)));
            Assert.IsTrue(stack9.HasSameElementsAtIndeces(TestMethods.StackToList(copyStack9)));
            Assert.IsTrue(stack10.HasSameElementsAtIndeces(TestMethods.StackToList(copyStack10)));
        }

        [Test]
        public void TestFoundElementAfterSorted()
        {
            SetupTestLists();

            Assert.IsTrue(TestMethods.FoundElementAfterSorted(copyList1, -50));
            Assert.IsFalse(TestMethods.FoundElementAfterSorted(copyList2, 42));
            Assert.IsTrue(TestMethods.FoundElementAfterSorted(copyList3, 100));
            Assert.IsTrue(TestMethods.FoundElementAfterSorted(copyList4, 55));
            Assert.IsFalse(TestMethods.FoundElementAfterSorted(copyList5, 8));
            Assert.IsFalse(TestMethods.FoundElementAfterSorted(copyList6, 28));

            Assert.IsTrue(sortedList1.HasSameElementsAtIndeces(copyList1));
            Assert.IsTrue(sortedList2.HasSameElementsAtIndeces(copyList2));
            Assert.IsTrue(sortedList3.HasSameElementsAtIndeces(copyList3));
            Assert.IsTrue(sortedList4.HasSameElementsAtIndeces(copyList4));
            Assert.IsTrue(sortedList5.HasSameElementsAtIndeces(copyList5));
            Assert.IsTrue(sortedList6.HasSameElementsAtIndeces(copyList6));
        }
    }
}