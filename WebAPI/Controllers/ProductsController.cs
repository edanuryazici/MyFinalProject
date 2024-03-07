using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class ProductsController : ControllerBase
    {
        //Loosely coupled - serbest bağlılık: manager değişirse biz bir sorunla karşılaşmayız ve bu yöntemi dependency chain i iyileştirmek için kullandık
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        //AOP: bir metodun önünde sonunda veya hata verdiğinde çalışan kod bloklarının yazılmasıdır. Bu olmasaydı Bussines katmanı çok karışırdı
        [HttpGet("getall")] 
        public IActionResult GetAll()
        {
            /*Dependency chain: bağımlılık zinciri --> Iproductservice bir manager a,
            manager da bir efdal a ihtiyaç duyuyor
            IProductService productService = new ProductManager(new EfProductDal());*/

            var result = _productService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data); //ok http olarak 200 koduna yani işlem başarılı kodunun adı
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")] //2 adet httpget operasyonu olduğu için sistem hangisini işleyeceğini anlamakta zorlandı bu yüzden onlara takma isim verdik.
        public IActionResult GetById(int productid)
        {
            var result = _productService.GetById(productid);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
