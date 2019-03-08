using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myPos.Models;

namespace myPos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopController : ControllerBase
    {
        public static List<myProducts> myProduct=new List<myProducts>
        {
            new myProducts{
                Id=Guid.NewGuid().ToString(),
                Name="คาปูชิโน่",
                Price=39,
                Img="Google.com"
            },
            new myProducts{
                Id=Guid.NewGuid().ToString(),
                Name="โกโก้เย็น",
                Price=39,
                Img="Google.com"
            },
            new myProducts{
                Id=Guid.NewGuid().ToString(),
                Name="ชาเย็น",
                Price=49,
                Img=""
            },
            new myProducts{
                Id=Guid.NewGuid().ToString(),
                Name="ชาเขียวปั่น",
                Price=59,
                Img="Google.com"
            },
            new myProducts{
                Id=Guid.NewGuid().ToString(),
                Name="ชานมเย็น",
                Price=39,
                Img="Google.com"
            },

        };
        [HttpGet]
         public List<myProducts> GetAllProducts()
        {
            return myProduct;

        }
        [HttpGet("{id}")]
        public myProducts GetProduct(String id){
            return  myProduct.Find(it =>it.Id==id);
        }
        [HttpPost]
        public void CreateProduct([FromBody]myProducts newProduct){
            newProduct.Id=Guid.NewGuid().ToString();
            myProduct.Add(newProduct);
        }


        
    }
}
