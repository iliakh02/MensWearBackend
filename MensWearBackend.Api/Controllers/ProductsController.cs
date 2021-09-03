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
        public JsonResult Index(int pageSize, int page = 1, int categoryId = 0, string searchString = "")
        {
            var products = _productRepository.GetAll();
            if (categoryId != 0)
            {
                products = products.Where(n => n.CategoryId == categoryId).ToList();
            }
            if(!string.IsNullOrEmpty(searchString))
                products = products.Where(n => n.Name.Contains(searchString)).ToList();

            var productsPerPage = products.Skip((page - 1) * pageSize).Take(pageSize);
            return new JsonResult(new { 
                products = productsPerPage,
                currentPage = page, 
                pageSize = pageSize,
                totalItems = products.Count,
                categoryId,
                searchString
            });
        }

        [HttpGet]
        [Route("{id}")]
        public JsonResult Details(int id)
        {
            var product = _productRepository.GetById(id);

            return new JsonResult(product);
        }
    }
}
