using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductsAPI.Services;

namespace ProductsAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriesController : ControllerBase
    {

        private ILogger _logger;
        private ICategoriesService _service;

        
        public CategoriesController(ILogger<CategoriesController> logger, ICategoriesService service)
        {
            _logger = logger;
            _service = service;
            
        }

        [HttpGet("/api/categories")]
        public ActionResult<APIResponse> GetCategories()
        {
            APIResponse apiResponse = new APIResponse();
            try
            {
                apiResponse.results = _service.GetCategories();
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

        [HttpPost("/api/categories")]
        public ActionResult<APIResponse> AddCategory(Category category)
        {

            APIResponse apiResponse = new APIResponse();
            try
            {
                apiResponse.results =
            _service.AddCategory(category);
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

        [HttpPut("/api/categories/{id}")]
        public ActionResult<APIResponse> UpdateCategory(int id, Category category)
        {
            APIResponse apiResponse = new APIResponse();
            try
            {
                apiResponse.results =
            _service.UpdateCategory(id, category);
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

        [HttpDelete("/api/categories/{id}")]
        public ActionResult<APIResponse> DeleteCategory(int id)
        {
            APIResponse apiResponse = new APIResponse();
            try
            {
                apiResponse.results =
            _service.DeleteCategory(id);
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
