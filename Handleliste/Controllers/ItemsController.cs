using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Handleliste.Models;
using Raven.Client;
using Raven.Client.Document;

namespace Handleliste.Controllers
{
    public class ItemsController : ApiController
    {
        //private static List<Item> items = new List<Item> { new Item("melk"), new Item("brød") };

        private static readonly IDocumentStore DocumentStore =
            new DocumentStore {ConnectionStringName = "RAVENHQ_CONNECTION_STRING"}.Initialize();

        // GET /api/items
        public IEnumerable<Item> Get()
        {
            using (var session = DocumentStore.OpenSession())
                return session.Query<Item>();
        }

        // GET /api/items/5
        public string Get(int id)
        {
            return "melk";
        }

        // POST /api/items
        public void Post(Item newItem)
        {
            using (var session = DocumentStore.OpenSession())
            {
                session.Store(newItem);
                session.SaveChanges();
            }
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