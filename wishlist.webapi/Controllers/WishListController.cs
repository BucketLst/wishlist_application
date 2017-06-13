using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using wishlist.dataaccess;

namespace wishlist.webapi.Controllers
{
    [Route("api/[controller]")]
    public class WishListController : Controller
    {
        private WishlistRepository _repository;

        public WishListController(){
            _repository = new WishlistRepository();
        }

        // GET api/values
        [HttpGet]
        [Route("GetAllWishes")]
        public List<WishListModel> GetAllWishes()
        {
            return _repository.SelectAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
