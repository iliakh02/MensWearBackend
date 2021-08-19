using MensWearBackend.Domain.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MensWearBackend.Api.Controllers
{
    [ApiController]
    [Route("categories")]
    public class CategoriesController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoriesController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        [HttpGet]
        public JsonResult Index()
        {
            var categories = _categoryRepository.GetAll();
            categories.Insert(0, new Domain.Entities.Category()
            {
                Id = 0,
                Name = "All"
            });

            return new JsonResult(categories);
        }
    }
}
