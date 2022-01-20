using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebOnlineShop.Models
{
    public class CategoryModel
    {
        public int SerialNum { get; set; }
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }
    }
    public class ProductModel
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int SerialNum { get; set; } 

    }

}