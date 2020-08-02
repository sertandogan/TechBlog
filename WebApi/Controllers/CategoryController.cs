using Application.Interfaces;
using Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] CategoryViewModel courseViewModel)
        {
            _categoryService.Create(courseViewModel);

            return Ok(courseViewModel);
        }
        [HttpGet]
        public IActionResult GetCategories()
        {
            //_categoryService.Create(new CategoryViewModel() { 
            //Name = "ASP.NET"
            //});

            return Ok(_categoryService.GetCategories());
        }
    }
}
