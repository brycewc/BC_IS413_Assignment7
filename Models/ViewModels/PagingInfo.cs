using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BC_IS413_Assignment7.Models.ViewModels
{
    public class PagingInfo
    {
        public int TotalNumItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }

        public int TotalPages => (int) (Math.Ceiling((decimal) TotalNumItems / ItemsPerPage)); //calculate the number of pages, based on number of records and number of records to be displayed on each page
    }
}
