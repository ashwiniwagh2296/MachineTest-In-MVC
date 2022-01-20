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

    public class CategoaryDAL
    {
        string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\MVC-Test\WebOnlineShop\WebOnlineShop\App_Data\onlineShopDatabase.mdf;Integrated Security=True";
        public void addcategory(string CategoryName)
        {
            try
            {
                using (SqlConnection objcon = new SqlConnection(connectionstring))
                {
                    SqlCommand objSqlComm = new SqlCommand("insert into Category (CategoryName) values ('" + CategoryName + "')", objcon);
                    objcon.Open();
                    objSqlComm.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

            }

        }

        public void Deletecategory(int categoryId)
        {
            try
            {
                using (SqlConnection objcon = new SqlConnection(connectionstring))
                {
                    SqlCommand objSqlComm = new SqlCommand("delete Category where CategoryId = " + categoryId + " ", objcon);
                    objcon.Open();
                    objSqlComm.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

            }
        }
        public DataTable Readcategory()
        {
            DataTable DT = new DataTable();

            try
            {
                using (SqlConnection objcon = new SqlConnection(connectionstring))
                {

                    SqlDataAdapter objsqldatAd = new SqlDataAdapter("select * from Category", objcon);
                    objsqldatAd.Fill(DT);

                }
            }
            catch (Exception ex)
            {

            }
            return DT;
        }
        public void UpdateCategory(string CategoryName, int CategoryId)
        {
            try
            {
                using (SqlConnection objcon = new SqlConnection(connectionstring))
                {
                    SqlCommand objSqlComm = new SqlCommand("update Category set CategoryName='" + CategoryName + "' where CategoryId = " + CategoryId + " ", objcon);
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