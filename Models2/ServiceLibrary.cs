using System;
using System.Collections.Generic;
using System.Text;

namespace NEWtask.Models2
{
    class ServiceLibrary : ILibraryManager
    {
        public List<Book> Books;
        public List<Book> Book => Books;

        public void Add(Book book)
        {
            List<Book> books = new List<Book>();
            foreach (Book _book in Books)
            {
                if (_book.Name.ToUpper() != book.Name.ToUpper())
                {
                    books.Add(book);
                }

            }
            throw new Exception("SameBookalreadyAddedExpection");

        }
        public Book ShowInfo(string bookname)
        {
            foreach (Book book in Books)
            {
                if (book.Name.ToLower() == bookname.ToLower())
                    return book;
            }
            throw new Exception("BookNotFoundException");
        }
        public List<Book> Search(Predicate<Book> predicate)
        {
            List<Book> books = new List<Book>();
            foreach (Book book in Books)
            {
                if (predicate(book))
                {
                    books.Add(book);
                }
            }
            return books;

        }

        public List<Book> Filter(string genre)
        {
            List<Book> books = new List<Book>();
            foreach (Book book in books)
            {
                if (book.Genre.ToLower() == genre.ToLower())
                {
                    books.Add(book);
                }
            }
            return books;

        }


    }



}

