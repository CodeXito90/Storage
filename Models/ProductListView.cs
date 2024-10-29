using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Storage.Models
{
    public class ProductListViewModel
    {
        public IEnumerable<ProductViewModel> Products { get; set; }
        public IEnumerable<SelectListItem> Categories { get; set; }
        public string SelectedCategory { get; set; }

        public string SearchTerm { get; set; } 
        public ProductViewModel SelectedProduct { get; set; }
    }
}
