
using System;
using System.Collections.Generic;
using System.Text;

namespace ManchahatBooks.Models.ViewModels
{
  public  class ProductVM
    {
        public Product Product { get; set; }
        public IEnumerable<SelectListItem> CategoryList { get; set; }
        public IEnumerable<SelectListItem> CoverTypeList { get; set; }

    }
}
