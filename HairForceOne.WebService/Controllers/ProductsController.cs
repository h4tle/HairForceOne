using Dapper;
using HairForceOne.WebService.Model;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HairForceOne.WebService.Controllers
{
    /// <summary>
    /// This class contains the dapper methods that handles the Product instance and SQL connection
    /// </summary>

    [Authorize]
    public class ProductsController : ApiController
    {
        /// <summary>
        /// This method gets the list of Product objects using Dapper
        /// </summary>
        /// <returns>A List of Products</returns>

        [HttpGet]
        public HttpResponseMessage GetAllProducts()
        {
            try
            {
                string sql = "SELECT * FROM hfo_Product";
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
                {
                    List<Product> products = connection.Query<Product>(sql).AsList();
                    return Request.CreateResponse(HttpStatusCode.OK, products);
                }
            }
            catch (SqlException)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    ReasonPhrase = "Produkter kan ikke hentes. Prøv igen senere"
                };
            }
        }

        /// <summary>
        /// This method gets a list of all Products objects based on the Brand parameter
        /// </summary>
        /// <param name="brand"></param>
        /// <returns>A List of Products by Brand</returns>

        [HttpGet]
        public HttpResponseMessage GetProductsByBrand(string brand)
        {
            try
            {
                string sql = "SELECT * from hfo_Product WHERE Brand LIKE CONCAT('%',@Brand,'%')";

                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
                {
                    List<Product> products = connection.Query<Product>(sql, new { Brand = brand }).AsList();
                    return Request.CreateResponse(HttpStatusCode.OK, products);
                }
            }
            catch (SqlException)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    ReasonPhrase = "Produkter kan ikke hentes. Prøv igen senere"
                };
            }
        }

        /// <summary>
        /// This method gets a list of all Product objects based on the Gender parameter
        /// </summary>
        /// <param name="gender"></param>
        /// <returns>A List of Products by Gender</returns>

        [HttpGet]
        public HttpResponseMessage GetAllProductsByGender(string gender)
        {
            try
            {
                string sql = "SELECT * from hfo_Product WHERE Gender LIKE CONCAT('%',@Gender,'%')";

                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
                {
                    List<Product> products = connection.Query<Product>(sql, new { Gender = gender }).AsList();
                    return Request.CreateResponse(HttpStatusCode.OK, products);
                }
            }
            catch (SqlException)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    ReasonPhrase = "Produkter kan ikke hentes. Prøv igen senere"
                };
            }
        }

        /// <summary>
        /// This method gets a specific ProductId from the list of Product objects using Dapper
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A Product object by ProductId</returns>

        [HttpGet]
        public HttpResponseMessage GetProduct(int id)
        {
            try
            {
                string sql = "SELECT * FROM hfo_Product WHERE ProductId = @ProductId";
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
                {
                    Product product = connection.QuerySingleOrDefault<Product>(sql, new { ProductId = id });
                    return Request.CreateResponse(HttpStatusCode.OK, product);
                }
            }
            catch (SqlException)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    ReasonPhrase = "Produkter kan ikke hentes. Prøv igen senere"
                };
            }
        }

        /// <summary>
        /// This method posts a new product object to the Database using Dapper
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>

        [Authorize(Roles = "2,3")]
        [HttpPost]
        public HttpResponseMessage CreateNewProduct([FromBody] Product product)
        {
            try
            {
                string sql = "INSERT INTO hfo_Product (Brand, Title, Description, PurchasePrice, RetailPrice, Gender)" +
                             "VALUES (@Brand, @Title, @Description, @PurchasePrice, @RetailPrice, @Gender)";
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
                {
                    var affectedRows = connection.Execute(sql, new
                    {
                        product.Brand,
                        product.Title,
                        product.Description,
                        product.PurchasePrice,
                        product.RetailPrice,
                        product.Gender
                    });
                    return Request.CreateResponse(HttpStatusCode.Accepted);
                }
            }
            catch (SqlException)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    ReasonPhrase = "Produktet kan ikke oprettes. Prøv igen senere"
                };
            }
        }

        /// <summary>
        /// This method edits and updates a product
        /// This method updates the exsisting Product Object using dapper
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>

        [Authorize(Roles = "2,3")]
        [HttpPut]
        public HttpResponseMessage EditProduct(Product product)
        {
            try
            {
                string sql = "UPDATE hfo_Product SET Brand = @Brand, Title = @Title, Description = @Description, PurchasePrice = @PurchasePrice, RetailPrice = @RetailPrice, Gender = @Gender WHERE ProductId = @ProductId";
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
                {
                    int ProductId = connection.Execute(sql, new
                    {
                        product.ProductId,
                        product.Brand,
                        product.Title,
                        product.Description,
                        product.PurchasePrice,
                        product.RetailPrice,
                        product.Gender
                    });
                    return Request.CreateResponse(HttpStatusCode.OK, ProductId);
                }
            }
            catch (SqlException)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    ReasonPhrase = "Produktet kan ikke opdateres. Prøv igen senere"
                };
            }
        }

        /// <summary>
        /// This method deletes the Product Object from the database, using a specific ProductId
        /// </summary>
        /// <param name="id"></param>

        [Authorize(Roles = "2,3")]
        [HttpDelete]
        public HttpResponseMessage DeleteProduct(int id)
        {
            try
            {
                string sql = "DELETE FROM hfo_Product WHERE ProductId = @ProductId";
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
                {
                    connection.Execute(sql, new { ProductId = id });
                    return Request.CreateResponse(HttpStatusCode.OK);
                }
            }
            catch (SqlException)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    ReasonPhrase = "Produktet kan ikke slettes. Prøv igen senere"
                };
            }
        }
    }
}