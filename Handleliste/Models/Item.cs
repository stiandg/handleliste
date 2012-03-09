using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class Item
    {
        public Item() { }

        public Item(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }
}