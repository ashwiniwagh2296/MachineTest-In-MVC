using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Data.Common;


namespace WebOnlineShop.AppCode.DAL
{
    public class ProductDAL
    {
        string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\MVC-Test\WebOnlineShop\WebOnlineShop\App_Data\onlineShopDatabase.mdf;Integrated Security=True";
        public void addProduct(String ProductName, int CategoryId)
        {
            try
            {
                using (SqlConnection objcon = new SqlConnection(connectionstring))
                {
                    SqlCommand objSqlComm = new SqlCommand("insert into Product (ProductName, CategoryId) values ('" + ProductName + "','"+ CategoryId +"')", objcon);
                    objcon.Open();
                    objSqlComm.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

            }

        }
        
        public void DeleteProduct(int productId)
        {
            try
            {
                using (SqlConnection objcon = new SqlConnection(connectionstring))
                {
                    SqlCommand objSqlComm = new SqlCommand("delete Product where ProductId = " + productId + " ", objcon);
                    objcon.Open();
                    objSqlComm.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

            }
        }
        public DataTable ReadProduct()
        {
            DataTable DT = new DataTable();

            try
            {
                using (SqlConnection objcon = new SqlConnection(connectionstring))
                {

                    SqlDataAdapter objsqldatAd = new SqlDataAdapter("select * from Product", objcon);
                    objsqldatAd.Fill(DT);

                }
            }
            catch (Exception ex)
            {

            }
            return DT;
        }
        public void UpdateProduct( int ProductId,string ProductName,int CategoryId)
        {
            try
            {
                using (SqlConnection objcon = new SqlConnection(connectionstring))
                {
                    SqlCommand objSqlComm = new SqlCommand("update Product set ProductName='"+ ProductName + "',CategoryId='"+ CategoryId + "' where ProductId = " + ProductId + " ", objcon);
                    objcon.Open();
                    objSqlComm.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

            }
        }
    

    }
}