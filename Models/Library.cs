using System;
using System.Collections.Generic;
using System.Text;

namespace NEWtask.Models
{
    class Library
    {
        List<Book> Books { get; set; }

        public Library()
        {
            Books = new List<Book>();
        }

        public List<Book> FindAllBooksByName(string name)
        {
            List<Book> book = Books.FindAll(b => b.Name.ToLower().Contains(name));
            {
                foreach (Book _book in book)
                {
                    Console.WriteLine(_book);
                }
            }
            return book;
        }

        public void RemoveAllBookByName(string name)
        {
            List<Book> book = new List<Book>();

            foreach (Book _book in Books)
            {
                if (_book.Name.ToLower() == name.ToLower())
                {
                    book.Remove(_book);
                }
            }
        }

        public List<Book> SearchBooks(string name)
        {
            List<Book> book = Books.FindAll(b => b.Name.ToLower().Contains(name) || b.Code.ToLower().Contains(name) || b.AuthorName.ToLower().Contains(name));
            {
                foreach (Book _book in book)
                {
                    Console.WriteLine(_book);
                }
            }
            return Books;
        }

        public List<Book> FindAllBooksByPageCountRange(int min, int max)
        {
            List<Book> book = new List<Book>();
            foreach (Book _book in Books)
            {
                if (book.Count > min && book.Count < max)
                {
                    book.Add(_book);
                }
            }
            return Books;
        }
        public void RemoveByNo(string name)
        {
            List<Book> book = new List<Book>();

            foreach (Book _book in Books)
            {
                if (_book.Code.ToLower() == name.ToLower())
                {
                    book.Remove(_book);
                }
            }
        }
    }
}
