using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace MvcBookapp.Models
{
    public class BookDetails
    {
        [Key]
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public decimal Price { get; set; }

        public class BookDetailContext : DbContext
        {
            public BookDetailContext(): base("BookDetailContext")
            {
                    
            }
            public DbSet<BookDetails> BookDetails
            {
                get;
                set;
            }
        }
    }
}