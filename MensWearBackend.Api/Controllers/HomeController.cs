using MensWearBackend.Domain.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MensWearBackend.Api.Controllers
{
    [ApiController]

    [Route("")]
    [Route("[controller]")]
    [Route("[controller]/[action]")]
    public class HomeController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        public HomeController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<JsonResult> Index()
        {
            return new JsonResult((await _productRepository.GetAllAsync()).Take(10));
        }
    }
}
