using MensWearBackend.Domain.Abstract;
using MensWearBackend.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MensWearBackend.Api.Controllers
{
    [Route("products")]
    public class ProductsController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        public int PageSize { get; } = 4;
        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public JsonResult Index(int page = 1)
        {
            var categories = _categoryRepository.GetAll();
            var productsPerPage = _productRepository.GetAll().Skip((page - 1) * PageSize).Take(PageSize).ToList();
            return Json (new { 
                products = productsPerPage,
                categories, 
                currentPage = page, 
                pageSize = PageSize});
        }
    }
}
