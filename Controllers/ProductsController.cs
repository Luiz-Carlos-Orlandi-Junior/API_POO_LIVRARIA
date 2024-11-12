using Livraria_Projeto.Service.DTOs;
using Livraria_Projeto.Service;
using Microsoft.AspNetCore.Mvc;
using System;



namespace Livraria_Projeto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController
    {

        private readonly ProductsService _productsService;

        public ProductsController(ProductsService productsService)
        {
            _productsService = productsService;
        }

    }
}
