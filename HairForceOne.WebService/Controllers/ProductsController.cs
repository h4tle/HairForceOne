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
{
    public class ProductsController : ApiController
    {
        public IEnumerable<Product> GetAllProducts()
        {
            string sql = "SELECT * FROM hfo_Product";
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
            {
                return connection.Query<Product>(sql).ToList();
            }
        }

        public IEnumerable<Product> GetAllProducts(string brand)
        {
            string sql = "SELECT * from hfo_Product WHERE Brand LIKE CONCAT('%',@Brand,'%')";

            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
            {
                return connection.Query<Product>(sql, new { Brand = brand }).ToList();
            }
        }

        public IEnumerable<Product> GetAllProductsGender(string gender)
        {
            string sql = "SELECT * from hfo_Product WHERE Gender LIKE CONCAT('%',@Gender,'%')";

            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
            {
                return connection.Query<Product>(sql, new { Gender = gender }).ToList();
            }
        }

        public IEnumerable<Product> GetAllProductsColor(string color)
        {
            string sql = "SELECT * from hfo_Product WHERE Color LIKE CONCAT('%',@Color,'%')";

            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
            {
                return connection.Query<Product>(sql, new { Color = color }).ToList();
            }
        }

        public Product GetProduct(int id)
        {
            string sql = $"select * FROM hfo_Product WHERE ProductId = @ProductId";
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
            {
                return connection.QuerySingleOrDefault<Product>(sql, new { ProductId = id });
            }
        }

        public HttpResponseMessage Post([FromBody] Product p)
        {
            try
            {
                string sql = "INSERT INTO hfo_Product (Brand,Title,Description,Weight,PurchasePrice,RetailPrice,Color,Gender)" +
                             "VALUES (@Brand, @Title, @Description, @Weight, @PurchasePrice, @RetailPrice, @Color, @Gender)";
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
                {
                    var affectedRows = connection.Execute(sql, new
                    {
                        Brand = p.Brand,
                        Title = p.Title,
                        Description = p.Description,
                        Weight = p.Weight,
                        PurchasePrice = p.PurchasePrice,
                        RetailPrice = p.RetailPrice,
                        Color = p.Color,
                        Gender = p.Gender
                    });
                    return Request.CreateResponse(HttpStatusCode.Accepted);
                }
            }
            catch (SqlException e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e);
            }
            
        }

        public int Put(Product p)
        {
            string sql = $"UPDATE hfo_Product SET Brand = @Brand, Title = @Title, Description = @Description, Weight = @Weight, PurchasePrice = @PurchasePrice, RetailPrice = @RetailPrice, Color = @Color, Gender = @Gender WHERE ProductId = @ProductId";
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
            {
                int ProductId = connection.Execute(sql, new
                {
                    ProductId = p.ProductId,
                    Brand = p.Brand,
                    Title = p.Title,
                    Description = p.Description,
                    Weight = p.Weight,
                    PurchasePrice = p.PurchasePrice,
                    RetailPrice = p.RetailPrice,
                    Color = p.Color,
                    Gender = p.Gender
                });
                return ProductId;
            }
        }

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