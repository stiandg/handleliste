namespace Handleliste.Models
{
    public class Item
    {
        public Item()
        {
            InShoppingCart = false;
        }

        public Item(string name) : this()
        {
            Name = name;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public bool InShoppingCart { get; set; }
    }
}