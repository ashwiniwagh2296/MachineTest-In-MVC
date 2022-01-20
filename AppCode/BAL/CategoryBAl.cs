using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using WebOnlineShop.AppCode.DAL;

namespace WebOnlineShop.AppCode.BAL
{
    public class CategoryBAl
    {

        CategoaryDAL objCateDal = new CategoaryDAL();
        public void addcategory(string category)
        {
            objCateDal.addcategory(category);
        }
        public void Deletecategory(int categoryId)
        {
            objCateDal.Deletecategory(categoryId);
        }
        public DataTable Readcategory()
        {

            return objCateDal.Readcategory();
        }
        public void UpdateCategory(string CategoryName, int CategoryId)
        {
            objCateDal.UpdateCategory( CategoryName, CategoryId);
        }
    }


}