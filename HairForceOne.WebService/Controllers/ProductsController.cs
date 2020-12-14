using Dapper;
using HairForceOne.WebService.Models;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HairForceOne.WebService.Controllers
    //try/catch
    //navne ændres
    // Authorization tags mangler

/// <summary>
/// This class contains all methods for handling products
/// </summary>
{
    public class ProductsController : ApiController
    {
        /// <summary>
        /// This method gets a list of all products
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Product> GetAllProducts()
        {
            string sql = "SELECT * FROM hfo_Product";
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
            {
                return connection.Query<Product>(sql).ToList();
            }
        }

        //Skal måske slettes

        /// <summary>
        /// This method gets a list of all products based on brand parameter
        /// </summary>
        /// <param name="brand"></param>
        /// <returns></returns>
        public IEnumerable<Product> GetProductsByBrand(string brand)
        {
            string sql = "SELECT * from hfo_Product WHERE Brand LIKE CONCAT('%',@Brand,'%')";

            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
            {
                return connection.Query<Product>(sql, new { Brand = brand }).ToList();
            }
        }

        // Skal måske slettes

        /// <summary>
        /// This method gets a list of all products based on gender parameter
        /// </summary>
        /// <param name="gender"></param>
        /// <returns></returns>
        public IEnumerable<Product> GetAllProductsGender(string gender)
        {
            string sql = "SELECT * from hfo_Product WHERE Gender LIKE CONCAT('%',@Gender,'%')";

            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
            {
                return connection.Query<Product>(sql, new { Gender = gender }).ToList();
            }
        }

        /// <summary>
        /// This method gets a product based on specific ProductId
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Product GetProduct(int id)
        {
            string sql = "select * FROM hfo_Product WHERE ProductId = @ProductId";
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
            {
                return connection.QuerySingleOrDefault<Product>(sql, new { ProductId = id });
            }
        }

        /// <summary>
        /// This method posts a new product
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public HttpResponseMessage Post([FromBody] Product product)
        {
            try
            {
                string sql = "INSERT INTO hfo_Product (Brand,Title,Description,Weight,PurchasePrice,RetailPrice,Color,Gender)" +
                             "VALUES (@Brand, @Title, @Description, @Weight, @PurchasePrice, @RetailPrice, @Color, @Gender)";
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
                {
                    var affectedRows = connection.Execute(sql, new
                    {
                        Brand = product.Brand,
                        Title = product.Title,
                        Description = product.Description,
                        Weight = product.Weight,
                        PurchasePrice = product.PurchasePrice,
                        RetailPrice = product.RetailPrice,
                        Color = product.Color,
                        Gender = product.Gender
                    });
                    return Request.CreateResponse(HttpStatusCode.Accepted);
                }
            }
            catch (SqlException e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e);
            }
        }

        /// <summary>
        /// This method edits and updates a product
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public int Put(Product product)
        {
            string sql = $"UPDATE hfo_Product SET Brand = @Brand, Title = @Title, Description = @Description, Weight = @Weight, PurchasePrice = @PurchasePrice, RetailPrice = @RetailPrice, Color = @Color, Gender = @Gender WHERE ProductId = @ProductId";
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
            {
                int ProductId = connection.Execute(sql, new
                {
                    ProductId = product.ProductId,
                    Brand = product.Brand,
                    Title = product.Title,
                    Description = product.Description,
                    Weight = product.Weight,
                    PurchasePrice = product.PurchasePrice,
                    RetailPrice = product.RetailPrice,
                    Color = product.Color,
                    Gender = product.Gender
                });
                return ProductId;
            }
        }

        /// <summary>
        /// This method deletes a product
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            string sql = $"DELETE FROM hfo_Product WHERE ProductId = @ProductId";
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
            {
                connection.Execute(sql, new { ProductId = id });
            }
        }
    }
}