using System.Collections;

namespace ADV_Session2_Demo
{
    internal class Program
    {
        public static int SumArrayList (ArrayList arrayList)
        {
            int sum = 0;
            if (arrayList != null)
            {
                for (int i = 0; i < arrayList.Count; i++)
                {
                    sum += (int)arrayList[i]; // Casting from object to int (Unsafe)[Unboxing]
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            #region Non Generic Collection
            //ArrayList arrayList = new ArrayList();
            //Console.WriteLine($"Count of arrayList = {arrayList.Count}");
            //// Count => Number of elements in the ArrayList
            //Console.WriteLine($"Capacity of arrayList = {arrayList.Capacity}");
            //// Capacity => Number of elements that arrayList can hold
            //arrayList.Add(1);
            //// upon adding the first element to the arralist the capacity is increased to default capacity (4)
            //// new array created at heap with size of 4
            ////Console.WriteLine("After adding first element");
            ////Console.WriteLine($"Count of arrayList = {arrayList.Count}");
            ////Console.WriteLine($"Capacity of arrayList = {arrayList.Capacity}");
            //arrayList.Add(2);
            //arrayList.AddRange(new int[] { 3, 4 });
            //Console.WriteLine($"Count of arrayList = {arrayList.Count}");
            //Console.WriteLine($"Capacity of arrayList = {arrayList.Capacity}");
            //arrayList.Add(5);
            //// Create new array at heap with twice the size = 8
            //// Take the old array elements and add it to the new array
            //Console.WriteLine($"Count of arrayList = {arrayList.Count}");
            //Console.WriteLine($"Capacity of arrayList = {arrayList.Capacity}");

            //ArrayList arrayList2 = new ArrayList(5) { 1, 2, 3, 4, 5 };
            //Console.WriteLine($"Count of arrayList = {arrayList2.Count}");
            //Console.WriteLine($"Capacity of arrayList = {arrayList2.Capacity}");
            //arrayList2.Add( 1 );
            //Console.WriteLine("After adding the sixth element");
            //Console.WriteLine($"Count of arrayList = {arrayList2.Count}");
            //Console.WriteLine($"Capacity of arrayList = {arrayList2.Capacity}");
            //// 4 x 4 = 16 Bytes not used
            //// Free / Delete / deallocate unused bytes
            //arrayList2.TrimToSize();
            //// Create a new array at heap with size = count
            //// Old elements and new elements are copied to the new array
            //// Old array is unreachable
            //Console.WriteLine($"Count of arrayList = {arrayList2.Count}");
            //Console.WriteLine($"Capacity of arrayList = {arrayList2.Capacity}");

            //arrayList2.Add(7); // Casting from value type to reference type (Boxing)
            //Console.WriteLine($"Count of arrayList = {arrayList2.Count}");
            //Console.WriteLine($"Capacity of arrayList = {arrayList2.Capacity}");
            //arrayList2.Add(8);
            //arrayList2.Add("Rana");
            //// ArrayList is now hetrogeneuos
            //// Compiler can not ensure type safety at compilation time
            //foreach (int i in arrayList2)
            //{
            //    Console.WriteLine(i);
            //}
            //int SumResault = SumArrayList(arrayList2);
            //Console.WriteLine($"The Resault is {SumResault}"); 
            #endregion

            #region Generic Collections [List]
            //List<int> Numbers = new List<int>();
            //Console.WriteLine($"Count of List = {Numbers.Count}");
            //Console.WriteLine($"Capacity of List = {Numbers.Capacity}");
            //Numbers.Add(1);
            //Console.WriteLine($"Count of List = {Numbers.Count}");
            //Console.WriteLine($"Capacity of List = {Numbers.Capacity}");
            //Numbers.AddRange(new int[] { 2, 3, 4 });
            //Console.WriteLine($"Count of List = {Numbers.Count}");
            //Console.WriteLine($"Capacity of List = {Numbers.Capacity}");
            //Numbers.Add(5);
            //Console.WriteLine($"Count of List = {Numbers.Count}");
            //Console.WriteLine($"Capacity of List = {Numbers.Capacity}");
            //Numbers.TrimExcess();
            //Console.WriteLine($"Count of List = {Numbers.Count}");
            //Console.WriteLine($"Capacity of List = {Numbers.Capacity}");

            //List<int> Numbers = new List<int>(5) { 1, 2, 3, 4, 5 };
            //Console.WriteLine($"Count of List = {Numbers.Count}");
            //Console.WriteLine($"Capacity of List = {Numbers.Capacity}");
            //Numbers.Add(6);
            //Console.WriteLine($"Count of List = {Numbers.Count}");
            //Console.WriteLine($"Capacity of List = {Numbers.Capacity}");
            //Numbers[0] = 100; // Using indexer as setter
            //Numbers[9] = 900; // Invalid can not use indexer for adding
            //foreach (int i in Numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //List<int> Numbers = new List<int>(5) { 1, 2, 3, 4, 5 };
            ////Numbers.Add("Rana"); // Invalid
            //Console.WriteLine(Helper.SumList(Numbers));
            #endregion

            #region List Methods
            //List<int> Numbers = new List<int>();
            //Numbers.Add(1);
            //// Adds one element
            //Numbers.AddRange(new int[] { 2, 3 });
            //// Adds many elements
            //Numbers.Insert(3, 4);
            //// Inserts an element in desired index and pushes the other elements to the right
            //Numbers.InsertRange(4, new int[] { 5, 6 });

            //foreach (int i in Numbers)
            //{
            //    Console.WriteLine(i);
            //}


            //// Inserts many elements in desired index and pushes the other elements to the right
            ////Numbers.Clear(); 
            //// Removes all elements
            //Console.WriteLine(Numbers.BinarySearch(2));
            //Console.WriteLine(Numbers.BinarySearch(9));
            //// Binary searches a sorted list and return the index
            //Console.WriteLine(Numbers.Contains(2));
            //Console.WriteLine(Numbers.Contains(9));
            //// Returns true if the element is in the list, otherwise returns false
            //Console.WriteLine(Numbers.Capacity); // 8
            //Console.WriteLine(Numbers.EnsureCapacity(3));
            //Console.WriteLine(Numbers.EnsureCapacity(10));
            //// Ensure the capacity is as specified, if less => it keeps doubling the capacity
            //// untill it is larger than sepecified or equals to it
            //Console.WriteLine(Numbers.IndexOf(1));
            //Console.WriteLine(Numbers.IndexOf(50));

            #endregion

        }
    }
}
