using MensWearBackend.Domain.Abstract;
using MensWearBackend.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
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
        public ProductsController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        public JsonResult Index(int pageSize, int page = 1)
        {
            var categories = _categoryRepository.GetAll();
            var products = _productRepository.GetAll();
            var productsPerPage = products.Skip((page - 1) * pageSize).Take(pageSize);
            return new JsonResult(new { 
                products = productsPerPage,
                currentPage = page, 
                pageSize = pageSize,
                totalItems = products.Count
            });
        }
    }
}
