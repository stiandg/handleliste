namespace Handleliste.Models
{
    public class Item
    {
        public Item() { }

        public Item(string name)
        {
            this.Name = name;
        }

        public string Id { get; set; }
        public string Name { get; set; }
    }
}