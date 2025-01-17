namespace ADV_Session2_Assignment
{
    internal class Program
    {
        static void Reverse<T>(ref T[] Arr)
        {
            for (int i = 0; i < Arr.Length / 2; i++)
            {
                T Temp;
                Temp = Arr[i];
                Arr[i] = Arr[Arr.Length - i - 1];
                Arr[Arr.Length - i - 1] = Temp;
            }
        }

        static List<int> GetEvenNumbers(List<int> Numbers)
        {
            List<int> evenNumbers = new List<int>();
            foreach (int number in Numbers)
            {
                // Check if the number is even
                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);
                }
            }
            return evenNumbers;
        }

        static void Main(string[] args)
        {
            #region Ex 1
            //string[] Arr = { "Ahmed", "Mohamed", "Amr", "Aya" };
            //Reverse(ref Arr);
            //foreach (string i in Arr)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #region Ex 2
            //List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //List<int> EvenNumbers = GetEvenNumbers(Numbers);
            //foreach (int number in EvenNumbers)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion
            #region Ex 3
            //try
            //{
            //    FixedSizeList<int> List = new FixedSizeList<int>(3);

            //    List.Add(1);
            //    List.Add(2);
            //    List.Add(3);
            //    Console.WriteLine(List.Get(0));
            //    Console.WriteLine(List.Get(1));
            //    Console.WriteLine(List.Get(2));

            //    List.Add(4);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //try
            //{
            //    FixedSizeList<int> List = new FixedSizeList<int>(3);
            //    List.Add(1);
            //    List.Add(2);
            //    List.Add(3);
            //    Console.WriteLine(List.Get(5));
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            #endregion
            #region Book
            //Book B1 = new Book("10", "C# Programming", new string[] { "Ahmed", "Mohamed" }, DateTime.Now, 250);
            //Console.WriteLine(B1);
            //string[] Authors = BookFunctions.GetAuthors(B1);
            //string Title = BookFunctions.GetTitle(B1);
            //decimal Price = BookFunctions.GetPrice(B1);
            //Console.WriteLine("Authors:");
            //foreach (string Author in Authors)
            //{
            //    Console.WriteLine(Author);
            //}
            //Console.WriteLine($"Title: {Title}");
            //Console.WriteLine($"Price: {Price}"); 
            #endregion
        }
    }
}
