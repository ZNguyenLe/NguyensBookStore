using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace NguyensBooks.Models.ViewModels
{
    public class ProductVM
    {
        public Product Product { get; set; } // displays all the product details
        public IEnumerable<SelectListItem> CategoryList { get; set; } // oh i need to install the package
        public IEnumerable<SelectListItem> CoverTypeList { get; set; }


    }
}
