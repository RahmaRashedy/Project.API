using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.DAL.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public string Category { get; set; }
        public int stock { get; set; }

        public Product() {}
        public Product(int _id, string _name,string _description  ,decimal _price, string _imageUrl, string _category,
            int _stock)
        {
            Id = _id;
            Name = _name;
            Description = _description;
            Price = _price;
            ImageUrl = _imageUrl;
            Category = _category;
            stock = _stock;
        }
    }
    

}
