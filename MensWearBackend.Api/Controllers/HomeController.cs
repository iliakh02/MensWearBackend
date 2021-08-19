using MensWearBackend.Domain.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MensWearBackend.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Route("[controller]/[action]")]
    public class HomeController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        public HomeController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        [Route("/")]
        [Route("/home")]
        public JsonResult Index()
        {
            return new JsonResult(_productRepository.GetAll().Take(8));
        }
    }
}
