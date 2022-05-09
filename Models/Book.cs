using System;
using System.Collections.Generic;
using System.Text;

namespace NEWtask.Models
{
    class Book
    {
        public static int count;
        public string Code { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }

        static Book()
        {
            count = 1;
        }

        public Book(string code, string name, string authorname, int pagecount)
        {

            Code = $"{Name.Substring(0, 2)} {count}";
            Name = name;
            AuthorName = authorname;
            PageCount = pagecount;
            count++;
        }

    }
}
