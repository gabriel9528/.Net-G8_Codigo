using StoreProcedureWithASP.Net_Framework.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace StoreProcedureWithASP.Net_Framework.DAL
{
    public class ProductDAL
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();

        #region GetAllProducts

        public List<ProductModel> GetAllProducts()
        {
            List<ProductModel> listProducts = new List<ProductModel> ();
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_get_all_products";

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dtProducts = new DataTable();

                connection.Open();
                adapter.Fill(dtProducts);
                connection.Close();

                foreach(DataRow row in dtProducts.Rows)
                {
                    ProductModel product = new ProductModel();
                    product.id = Convert.ToInt32(row["id"]);
                    product.product_name = row["product_name"].ToString();
                    product.price = Convert.ToInt32(row["price"]);
                    product.quantity = Convert.ToInt32(row["quantity"]);
                    product.remarks = row["remarks"].ToString();

                    listProducts.Add(product);
                }

            }
            return listProducts;

        }
        #endregion

        #region GetProductById

        public ProductModel GetProductById(int id)
        {
            ProductModel product = new ProductModel();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_get_product_by_id";
                command.Parameters.AddWithValue("@product_id", id);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dtProducts = new DataTable();

                connection.Open();
                adapter.Fill(dtProducts);
                connection.Close();

                foreach (DataRow row in dtProducts.Rows)
                {
                    product.id = Convert.ToInt32(row["id"]);
                    product.product_name = row["product_name"].ToString();
                    product.price = Convert.ToInt32(row["price"]);
                    product.quantity = Convert.ToInt32(row["quantity"]);
                    product.remarks = row["remarks"].ToString();

                }

            }
            return product; ;

        }
        #endregion

        #region InsertProduct

        public bool InsertProduct(ProductModel product)
        {
            int id = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("sp_insert_product", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@product_name", product.product_name);
                command.Parameters.AddWithValue("@price", product.price);
                command.Parameters.AddWithValue("@quantity", product.quantity);
                command.Parameters.AddWithValue("@remarks", product.remarks);

                connection.Open();
                id = command.ExecuteNonQuery();
                connection.Close() ;

                if(id > 0)
                {
                    return true;
                }
                return false;
            }
        }

        #endregion

        #region UpdateProduct

        public bool UpdateProduct(ProductModel product)
        {
            int id = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("sp_update_product", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", product.id);
                command.Parameters.AddWithValue("@product_name", product.product_name);
                command.Parameters.AddWithValue("@price", product.price);
                command.Parameters.AddWithValue("@quantity", product.quantity);
                command.Parameters.AddWithValue("@remarks", product.remarks);

                connection.Open();
                id = command.ExecuteNonQuery();
                connection.Close();

                if (id > 0)
                {
                    return true;
                }
                return false;
            }
        }

        #endregion

        #region DeleteProduct

        public string DeleteProduct(int id)
        {
            string result = string.Empty;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_delete_product";
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.Add("@return_message", SqlDbType.VarChar, 255).Direction = ParameterDirection.Output;

                connection.Open();
                command.ExecuteNonQuery();
                result = command.Parameters["@return_message"].Value.ToString();
                connection.Close();

            }
            return result;

        }
        #endregion
    }
}