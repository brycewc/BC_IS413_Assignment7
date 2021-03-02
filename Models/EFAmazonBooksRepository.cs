using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BC_IS413_Assignment7.Models
{
    public class EFAmazonBooksRepository : IAmazonBooksRepository
    {
        private AmazonBooksDBContext _context;

        //Constructor
        public EFAmazonBooksRepository (AmazonBooksDBContext context)
        {
            _context = context;
        }
        public IQueryable<Book> Books => _context.Books;
        
    }
}
