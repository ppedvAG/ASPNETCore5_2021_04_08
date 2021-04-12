﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreNMSampleMVC.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}

//namespace Old
//{
//    public class Author
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//    }
//    public class Book
//    {
//        public int BookId { get; set; }
//        public string Title { get; set; }
//        public Author Author { get; set; }
//        public ICollection<BookCategory> BookCategories { get; set; }
//    }
//    public class Category
//    {
//        public int CategoryId { get; set; }
//        public string CategoryName { get; set; }
//        public ICollection<BookCategory> BookCategories { get; set; }
//    }
//    public class BookCategory
//    {
//        public int BookId { get; set; }
//        public Book Book { get; set; }
//        public int CategoryId { get; set; }
//        public Category Category { get; set; }
//    }
//}
