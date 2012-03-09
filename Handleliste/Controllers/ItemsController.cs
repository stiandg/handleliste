using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class ItemsController : ApiController
    {
        private static List<Item> items = new List<Item> { new Item("melk"), new Item("brød") };

        // GET /api/items
        public IEnumerable<Item> Get()
        {
            return items;
        }

        // GET /api/items/5
        public string Get(int id)
        {
            return "melk";
        }

        // POST /api/items
        public void Post(Item newItem)
        {
            items.Add(newItem);
        }

        // PUT /api/items/5
        public void Put(int id, string value)
        {
        }

        // DELETE /api/items/5
        public void Delete(int id)
        {
        }
    }
}