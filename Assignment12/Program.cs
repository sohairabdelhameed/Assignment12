using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment12
{
    internal class Program
    {
        #region Reversed Array Method
        static void ReverseArrayList(ArrayList arrayList)
        {
            // Initialize pointers at the beginning and end of the ArrayList
            int left = 0;
            int right = arrayList.Count - 1;

            // Loop until the two pointers meet in the middle
            while (left < right)
            {
                // Temporarily store the value at the 'left' index
                var temp = arrayList[left];

                // Swap the value at 'left' index with the value at 'right' index
                arrayList[left] = arrayList[right];

                // Assign the temporarily stored value to the 'right' index
                arrayList[right] = temp;

                // Move the 'left' pointer one step to the right
                left++;

                // Move the 'right' pointer one step to the left
                right--;
            }
        }

        #endregion

        #region GetEvenNumbers Method
        static List<int> GetEvenNumbers(List<int> list)
        {
            // Create a new list to store the even numbers
            List<int> evenList = new List<int>();

            // Iterate through each number in the input list
            foreach (int number in list)
            {
                // Check if the number is even
                if (number % 2 == 0)
                {
                    // If the number is even, add it to the evenList
                    evenList.Add(number);
                }
            }

            // Return the list containing all the even numbers
            return evenList;
        }

        #endregion
        public static void Main(string[] args)
        {
            #region Part02


            #region Question01
            //You are given an ArrayList containing a sequence of elements. try to
            //reverse the order of elements in the ArrayList in-place(in the same
            //arrayList) without using the built-in Reverse.Implement a function that
            //takes the ArrayList as input and modifies it to have the reversed order of
            //elements.

            //ArrayList arrayList = new ArrayList() { 1, 2, 3, 4, 5 };
            //ReverseArrayList(arrayList);

            //foreach (var item in arrayList)
            //{
            //    Console.Write(item + " ");
            //}


            #endregion

            #region Question02
            //You are given a list of integers.Your task is to find and return a new list
            //containing only the even numbers from the given list.

            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //List<int> evenList = GetEvenNumbers(list);

            //foreach (var number in evenList)
            //{
            //    Console.Write(number + " ");
            //}

            #endregion


            #region Question03
            //implement a custom list called FixedSizeList<T> with a predetermined
            //capacity. This list should not allow more elements than its capacity and
            //should provide clear messages if one tries to exceed it or access invalid
            //indices.

            try
            {
                // Create a FixedSizeList of integers with a capacity of 5
                FixedSizeList<int> fixedSizeList = new FixedSizeList<int>(5);

                // Add elements to the list
                fixedSizeList.Add(1);
                fixedSizeList.Add(2);
                fixedSizeList.Add(3);
                fixedSizeList.Add(4);
                fixedSizeList.Add(5);

                // Attempt to add a sixth element which should throw an exception
                fixedSizeList.Add(6);
            }
            catch (Exception ex)
            {
                // Catch the exceptions and print it
                Console.WriteLine(ex.Message);
            }

            try
            {
                // Create a FixedSizeList of integers with a capacity of 3
                FixedSizeList<int> fixedSizeList = new FixedSizeList<int>(3);

                // Add elements to the list
                fixedSizeList.Add(1);
                fixedSizeList.Add(2);
                fixedSizeList.Add(3);

                // Attempt to get an element at index 5 which should throw an exception
                Console.WriteLine(fixedSizeList.Get(5));
            }
            catch (Exception ex)
            {
                // Catch the exceptions and print it
                Console.WriteLine(ex.Message);
            }



            #endregion

















            #endregion


        }
    }
}
