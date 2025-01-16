using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV_Session2_Assignment
{
    internal class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }

        public Book(string _ISBN, string _Title, string[] _Authors, DateTime _PublicationDate, decimal _Price)
        {
            ISBN = _ISBN;
            Title = _Title;
            Authors = _Authors;
            PublicationDate = _PublicationDate;
            Price = _Price;
        }
        public override string ToString()
        {
            StringBuilder Resault = new StringBuilder();
            Resault.Append($"ISBN: {ISBN}\n");
            Resault.Append($"Title: {Title}\n");
            Resault.Append("Authors:\n");
            for (int i = 0; i < Authors.Length; i++)
            {
                Resault.Append($"{i + 1}- {Authors[i]}\n");
            }
            Resault.Append($"Publication Date: {PublicationDate}\n");
            Resault.Append($"Price: {Price}");
            return Resault.ToString();
        }
    }
}
