namespace Demo
{
    internal class Program
    {
        #region Sum ArrayList Method
        //public static int SumArrayList(ArrayList array)
        //{
        //    int sum = 0;
        //    if(array is not null)
        //    {
        //        for(int i =0; i< array.Count; i++)
        //        {
        //            sum += (int)array[i]; //From object to int
        //            //Unboxing
        //            //unsafe
        //        }

        //    }
        //    return sum;
        //} 
        #endregion

        #region Sum Array using List - Method
        public static int SumList(List<int> list)
        {
            int sum = 0;
            if (list is not null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    sum += list[i];
                }

            }
            return sum;
        }
        #endregion
        static void Main(string[] args)
        {
            #region ArrayList NonGeneric
            //ArrayList arrayList = new ArrayList(5) { 1,2,3,4,5};
            ////Console.WriteLine($"{arrayList.Count}"); //5
            ////Console.WriteLine($"{arrayList.Capacity}"); //5

            //arrayList.Add(6);
            ////Console.WriteLine("after adding 6th element");
            ////Console.WriteLine($"{arrayList.Count}"); //6
            ////Console.WriteLine($"{arrayList.Capacity}"); //10

            ////4 Object => 4Bytes * 4 => 16 Bytes Unused

            ////arrayList.TrimToSize(); // Free || Deallocate unUsedBytes
            //////Create new Array at the Heap the size will be the same size of the elements 
            //////which is 6 and the old elemnet from the old array and put it in the new array 
            ////// the old array now is unreached object

            ////Console.WriteLine("after Trim");
            ////Console.WriteLine($"{arrayList.Count}"); //6
            ////Console.WriteLine($"{arrayList.Capacity}"); //6

            //////but when we want to add a new element it will douple the 
            //////Array again

            //arrayList.Add(7); // Casting from (7) Value type to 0bject (Refrence) type
            //                  //Boxing

            ////arrayList.Add("sohair");
            //////ArrayList => Heterogenous List

            ////arrayList.Add('A');
            //////Compiler Canot Enforce Type Safety

            ////foreach(int i in arrayList)
            ////{
            ////    Console.WriteLine(i);
            ////    //Unhandled exception. System.InvalidCastException: Unable to cast object of type 'System.String' to type 'System.Int32'.

            ////}
            ////arrayList.Add("sohair"); it canot convert from string to int
            //int result = SumArrayList(arrayList);
            //Console.WriteLine(result); 
            #endregion

            #region Generic Collection - List
            // //Generic Collections
            // //Listing[List] //Deosnot depens on the object

            // //List => arrayList New Version
            // //List<int> Numbers = new List<int>();
            // //Console.WriteLine($"{Numbers.Count} {Numbers.Capacity}");

            // //Numbers.Add(1);
            // ////Upon adding the first element to the
            // ////increased to 

            // //Numbers.Add(2);

            // //Numbers.AddRange(new int[] { 3 ,4 });
            // //Console.WriteLine($"{ Numbers.Count} { Numbers.Capacity}");
            // //Numbers.Add(5);
            // //Numbers.TrimExcess();
            // ////Create new array with size of count 
            // //// the old array will be un reachable
            // ////Homogeonous List

            //// List<int> Numbers = new List<int>(5) { 1,2,3,4,5}; //Takes the capacity

            //// Console.WriteLine($" Count : {Numbers.Count} Capacity : {Numbers.Capacity}");

            //// Numbers.Add(6);

            // //Console.WriteLine($" Count : {Numbers.Count} Capacity : {Numbers.Capacity}"); // 6 10

            // ////Print list with for each or for loop

            // //foreach( int i in Numbers )
            // //{
            // //    Console.WriteLine(i);

            // //}
            // //Numbers[0] = 100; //Using Indexer as Setter for Value
            // //for ( int i = 0; i < Numbers.Count; i++)
            // //{
            // //    Console.WriteLine( Numbers[i]); //Using Indexer as getter
            // //}

            // //Numbers[6] = 100 //WE canot use the Indexer as Adding

            // //int result = SumList(Numbers);
            // //Console.WriteLine(result); 
            #endregion

            #region List Method
            //List<int> Numbers = new List<int>() { 1, 2, 3, 4,5,6,4};

            //Console.WriteLine($"{Numbers.Count} {Numbers.Capacity}");

            // Numbers.Add(5);
            //Numbers.AddRange(new int[] { 6,7});

            //foreach (int i in Numbers)
            //{
            //    Console.WriteLine(i);
            //}
            //Numbers.Insert(6, 8); //Insert in specific index

            //foreach (int i in Numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //Numbers.InsertRange(4, new int[] { 9, 10 });
            //foreach (int i in Numbers)
            //{
            //    Console.Write($" {i}  ");
            //}


            //Console.WriteLine($"Count : {Numbers.Count} Capacity : {Numbers.Capacity}");

            //int index = Numbers.BinarySearch(3);
            //Console.WriteLine(index);

            //index = Numbers.BinarySearch(10);
            //Console.WriteLine(index);

            //Numbers.Clear(); //Removes the elements in the list
            //Console.WriteLine($"Count : {Numbers.Count} Capacity : {Numbers.Capacity}");

            //Console.WriteLine(Numbers.Contains(9)); //Boolen check if number exists or not

            // int[] array = new int[10];

            //Numbers.CopyTo( array); // array has 1,2,3,4 - and Numbers too

            //int[] array = new int[3];

            //Numbers.CopyTo(array); //Invalid the length is less than Original

            //int[] array = new int[5];

            //Numbers.CopyTo(array); //valid the length is greater than Original - 1,2,3,4,0

            // Numbers.CopyTo(array, 0);

            //Numbers.CopyTo(1, array, 5, 3);
            ////array =>0 0 0 0 0 2 3 4 0 0 
            //foreach (int i in array)
            //{
            //    Console.WriteLine(i);
            //}

            //Numbers.EnsureCapacity(10);
            //Console.WriteLine($"Count : {Numbers.Count} Capacity : {Numbers.Capacity}");

            //Numbers.EnsureCapacity(9);
            //Console.WriteLine($"Count : {Numbers.Count} Capacity : {Numbers.Capacity}");
            //Console.WriteLine(Numbers.IndexOf(4));
            //Console.WriteLine(Numbers.LastIndexOf(4));

            //Numbers.Find(); //Takes deligate -- functions

            #endregion

            #region LinkedList
            //  LinkedList<int> list = new LinkedList<int>();
            //  Console.WriteLine($"Linked list Count : {list.Count} " );
            //  list.AddFirst(1); //One node
            //  Console.WriteLine($"Linked list Count : {list.Count} ");
            //  list.AddFirst(2); //One node
            //  Console.WriteLine($"Linked list Count : {list.Count} ");
            //  list.AddLast(3);

            //LinkedListNode<int> Node =  list.Find(2); // return value with address
            //  list.AddAfter(Node, 6);
            //  LinkedListNode<int> BeforeNode = list.Find(1);
            //  list.AddBefore(BeforeNode, 10);
            //  foreach (int i in list)
            //  {
            //      Console.WriteLine(i); //2 6 10 1 3


            //  }


            #endregion

            #region Stack Last in First Out
            //Stack<int> stack = new Stack<int>();
            //Console.WriteLine($"Count :  {stack.Count}" );

            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //Console.WriteLine(stack.Peek());
            //Console.WriteLine(stack.Pop());
            //stack.Pop();
            //stack.Peek();
            //stack.Pop();
            //stack.Pop();

            //Console.WriteLine($"Count :  {stack.Count}");



            //foreach (int item in stack) 
            //{
            //    Console.WriteLine(item);

            //}

            #endregion

            #region Queue
            //Queue <int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);

            ////Console.WriteLine(queue.Peek()); //First element
            //Console.WriteLine(queue.Dequeue()); ///Retuen and remove
            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine(queue.Dequeue());

            //bool Result  = 
            //foreach (int item in queue)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


        }
    }
}
