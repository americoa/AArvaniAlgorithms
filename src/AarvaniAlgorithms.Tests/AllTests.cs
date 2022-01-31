using AArvaniAlgorithms.Others;
using AArvvaniAlgorithms.Search;
using AArvvaniAlgorithms.Sort;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AarvaniAlgorithms.Tests
{
    [TestClass]
    public class AllTests
    {
        [TestMethod]
        public void SelectionSort()
        {
            int[] numbers = { 10, 6, 9, 5 };
            new SelectionSort().Sort(numbers);
        }

        [TestMethod]
        public void QuickSort() {

            int[] arr = { 67, 12, 95, 56, 85, 1, 100, 23, 60, 9 };    
            new QuickSort().quickSort(arr, 0, 9);
        }

        [TestMethod]        
        public void LinearSearch() {
            
            int[] numbers = { 10, 6, 9, 5 };
            int search = 5;
            var match = new LinearSearch().Search(numbers,search);
            Assert.IsTrue(match);
            search = 30;
            match = new LinearSearch().Search(numbers, search);
            Assert.IsTrue(!match);
        }

        [TestMethod]
        public void BinarySearchTest() {

            int[] numbers = { 10, 6, 9, 5 };
            new SelectionSort().Sort(numbers);
            int search = 5;
            var result = BinarySearch.Search(numbers, search);
            Assert.IsTrue(result == 0);
            search = 50;
            result = BinarySearch.Search(numbers, search);
            Assert.IsTrue(result == null);
        }

        [TestMethod]
        public void MergeSort() {

            int[] arr = { 12, 11, 13, 5, 6, 7 };                        
            MergeSort ob = new MergeSort();
            ob.sort(arr, 0, arr.Length - 1);       
        }

        [TestMethod]        
        public void SequentialBruteForce() {
            //arrange
            int low = 100, right = 400;            
            List<int> expect = new List<int> { 123, 234, 345 };

            //act
            List<int> result = SequencialDigits.BruteForce(low, right);

            //assert
            CollectionAssert.AreEqual(expect, result);
        }

        [TestMethod]
        public void SequentialBruteForceDymanic()
        {
            //arrange
            int low = 100, right = 400;
            List<int> expect = new List<int> { 123, 234, 345 };

            //act
            List<int> result = SequencialDigits.BruteForceDynamic(low, right);

            //assert
            CollectionAssert.AreEqual(expect, result);
        }

        [TestMethod]
        [DataRow(100,400,new[]{123, 234, 345})]
        [DataRow(1000,13000,new[]{1234,2345,3456,4567,5678,6789,12345})]
        public void SequentialDepthFirstSearch(int low, int right , int[] expect)
        {
            //arrange
     
            //act
            List<int> result = SequencialDigits.DepthFirstSearch(low, right);

            //assert
            CollectionAssert.AreEqual(expect, result.ToArray());
        }
    }
}
