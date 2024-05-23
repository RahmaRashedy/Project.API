using ClassLibrary1.DAL.Models;
using ClassLibrary1.DAL.Repositorries.Generic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.DAL.Data.Context;
using ClassLibrary1.DAL.Data;

namespace ClassLibrary1.DAL.Repositorries.ProductRepositorries
{
    public class ProductRepository : GenericRepositorries<Product>, IProductRepository
    {
        protected readonly ProjectContext _context;
        public ProductRepository(ProjectContext context) : base(context)
        {
            _context = context;
        }
        public IEnumerable<Product> GetByCategoryandName(string category, string name)
        {
            var query = _context.Products.AsQueryable();
            if (!string.IsNullOrEmpty(category))
            {
                query = query.Where(p => p.Category == category);
            }
            else
            {
                return query;
            }
            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(p => p.Name.Contains(name));
            }
            else
            {
                return query;
            }
            return query.ToList();
        }
     

        public decimal GetPriceById(int id)
        {
            var productprice = _context.Products.FirstOrDefault(p => p.Id == id);
            if (productprice == null)
            {
                return 0;
            }
            return productprice.Price;
        }
    }
}
