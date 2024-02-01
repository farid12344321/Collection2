using Homework_Collection.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Collection
{
    internal class Library
    {
        List<string> Books = new List<string>();
        public void Add(string name)
        {
            if (Books.Contains(name)) throw new BookAlreadyExist("Eyni adda book olmaz");


            Books.Add(name);
        }
        public bool Remove(string name)
        {
            if (Books.Remove(name)) return true;

            return false;
        }
        public void ShowBook()
        {
            foreach (var item in Books)
            {
                Console.WriteLine(item);
            }
        }
        public void SearchBook(string text)
        {
            foreach (var item in Books)
            {
                if (item.Contains(text))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
