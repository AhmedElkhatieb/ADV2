namespace ADV_Session2_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book B1 = new Book("10", "C# Programming", new string[] { "Ahmed", "Mohamed" }, DateTime.Now, 250);
            Console.WriteLine(B1);
            string[] Authors = BookFunctions.GetAuthors(B1);
            string Title = BookFunctions.GetTitle(B1);
            decimal Price = BookFunctions.GetPrice(B1);
            Console.WriteLine("Authors:");
            foreach (string Author in Authors)
            {
                Console.WriteLine(Author);
            }
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Price: {Price}");
        }
    }
}
