using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductsAPI.Services;

namespace ProductsAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {

        private ILogger _logger;
        private IProductsService _service;

        
        public ProductsController(ILogger<ProductsController> logger, IProductsService service)
        {
            _logger = logger;
            _service = service;
            
        }

        [HttpGet("/api/products")]
        public ActionResult<APIResponse> GetProducts()
        {
            APIResponse apiResponse = new APIResponse();
            try
            {
                apiResponse.results = _service.GetProducts();
                apiResponse.success = true;
                return apiResponse;
            }
            catch (Exception ex)
            {
                apiResponse.success = false;
                apiResponse.messages = new string[1]{ ex.Message };
                return apiResponse;
            }
        }

        [HttpPost("/api/products")]
        public ActionResult<APIResponse> AddProduct(Product product)
        {

            APIResponse apiResponse = new APIResponse();
            try
            {
                apiResponse.results =
            _service.AddProduct(product);
                apiResponse.success = true;
                return apiResponse;
            }
            catch (Exception ex)
            {
                apiResponse.success = false;
                apiResponse.messages = new string[1] { ex.Message };
                return apiResponse;
            }
        }

        [HttpPut("/api/products/{id}")]
        public ActionResult<APIResponse> UpdateProduct(int id, Product product)
        {
            APIResponse apiResponse = new APIResponse();
            try
            {
                apiResponse.results =
            _service.UpdateProduct(id, product);
                apiResponse.success = true;
                return apiResponse;
            }
            catch (Exception ex)
            {
                apiResponse.success = false;
                apiResponse.messages = new string[1] { ex.Message };
                return apiResponse;
            }
        }

        [HttpDelete("/api/products/{id}")]
        public ActionResult<APIResponse> DeleteProduct(int id)
        {
            APIResponse apiResponse = new APIResponse();
            try
            {
                apiResponse.results =
            _service.DeleteProduct(id);
                apiResponse.success = true;
                return apiResponse;
            }
            catch (Exception ex)
            {
                apiResponse.success = false;
                apiResponse.messages = new string[1] { ex.Message };
                return apiResponse;
            }
        }
    }
}
