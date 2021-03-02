using BC_IS413_Assignment7.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BC_IS413_Assignment7.Models.ViewModels;

namespace BC_IS413_Assignment7.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IAmazonBooksRepository _repository;

        public int PageSize = 5; //Page size variable. Stores how many records you want displayed per page. Change this value to change number of records on a page. 

        public HomeController(ILogger<HomeController> logger, IAmazonBooksRepository repository)
        {
            _logger = logger;
            _repository = repository; //Setting the IAmazonBooksRepository to the private attribute to send to Index
        }

        public IActionResult Index(string category, int page = 1)
        {
            return View(new BookListViewModel
            {
                Books = _repository.Books
                    .Where(p => category == null || p.Category == category)
                    .OrderBy(p => p.BookId)
                    .Skip((page - 1) * PageSize)
                    .Take(PageSize),
                
                    PagingInfo = new PagingInfo
                    {
                        CurrentPage = page,
                        ItemsPerPage = PageSize,
                        TotalNumItems = category == null ?_repository.Books.Count() :
                            _repository.Books.Where (x => x.Category == category).Count()
                    },
                    Type = category
            });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
