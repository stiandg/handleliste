using System;
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
        private static readonly IDocumentStore DocumentStore =
            new DocumentStore {ConnectionStringName = "RAVENHQ_CONNECTION_STRING"}.Initialize();

        public IEnumerable<Item> Get()
        {
            using (var session = DocumentStore.OpenSession())
                return session.Query<Item>().OrderByDescending(x => x.Id);
        }
        
        public string Get(int id)
        {
            throw new NotImplementedException();
        }

        public Item Post(Item newItem)
        {
            using (var session = DocumentStore.OpenSession())
            {
                session.Store(newItem);
                session.SaveChanges();
            }

            return newItem;
        }

        public void Put(string id, Item itemWithChanges)
        {
            using (var session = DocumentStore.OpenSession())
            {
                session.Store(itemWithChanges);
                session.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}