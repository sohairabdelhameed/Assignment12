using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12
{
     //Create a generic class named FixedSizeList<T>.
    public class FixedSizeList <T>
    {
        #region Properties
       
        private T[] items;
        
        private int count;

        #endregion

        #region Constructor

        //Implement a constructor that takes the fixed capacity of the list as a parameter.

        public FixedSizeList(int capacity)
        {
            items = new T[capacity];
            count = 0;
        }
        #endregion

        #region Add  Method
        // Implement an Add method that adds an element to the list,
        // but throws an exception if the list is already full.
        public void Add(T item)
        {
            // Check if the current count is equal to or exceeds the capacity of the list
            if (count >= items.Length)
            {
                // If the list is full, throw an InvalidOperationException
                throw new InvalidOperationException("The list is full.");
            }

            // Add the item to the list at the current count index and then increment the count
            items[count++] = item;
        }

        // Implement a Get method that retrieves an element at a specific index
        // in the list but throws an exception for invalid indices.
        public T Get(int index)
        {
            // Check if the provided index is less than 0 or greater than or equal to the current count
            if (index < 0 || index >= count)
            {
                // If the index is invalid, throw an ArgumentOutOfRangeException
                throw new ArgumentOutOfRangeException(nameof(index), "Invalid index.");
            }

            // Return the item at the specified index
            return items[index];
        }
        #endregion

        #region GetMethods
        // Property to get the current number of elements in the list
        public int Count => count;

        // Property to get the total capacity of the list
        public int Capacity => items.Length;

        #endregion




    }
}
