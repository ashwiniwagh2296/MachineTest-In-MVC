
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.Common;
using WebOnlineShop.AppCode.DAL;

namespace WebOnlineShop.AppCode.BAL
{
    public class ProductBAL
    {
        ProductDAL objProDal = new ProductDAL();
        public void addProduct(string productName, int CategouryId)
        {
            objProDal.addProduct(productName,CategouryId);
        }
      
        public void DeleteProduct(int productId)
        {
            objProDal.DeleteProduct(productId);
        }
        public DataTable ReadProduct()
        {

            return objProDal.ReadProduct();
        }
        public void UpdateProduct(int ProductId,string  ProductName, int CategoryId)
        {
             objProDal.UpdateProduct(ProductId, ProductName, CategoryId);
        }
    }
}