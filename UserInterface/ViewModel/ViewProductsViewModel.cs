using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataModelLayer;

namespace UserInterface.ViewModel
{
    public class ViewProductsViewModel
    {
        public IEnumerable<ProductSize> ProductSizes { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}