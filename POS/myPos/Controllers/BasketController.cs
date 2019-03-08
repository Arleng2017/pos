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
    public class BasketController: ControllerBase
    {
         public static List<myBasket> myBasket=new List<myBasket>
        {
          
            
        };
        [HttpGet]
         public List<myBasket> GetAllItem()
        {
            return myBasket;

        }


       [HttpPost]
        public void addItem([FromBody]myBasket newItem){
             myBasket.Add(newItem);
          
        }
       


        
    }
}
