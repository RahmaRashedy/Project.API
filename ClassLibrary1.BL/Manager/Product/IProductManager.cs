using ClassLibrary1.BL.Dtos.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.BL.Manager.Product
{
    public interface IProductManager
    {
        IEnumerable<DetailsProductDto> GetAll();
        DetailsProductDto? GetById(int id);

        IEnumerable<DetailsProductDto> GetProductsByCategoryandName(string cateogry,string name);

        void Add(AddProductDto addProductDto, string url);
        void Delete(int id);

        void Update(UpdateProductDto updateProductDto, string url);
        void Update2(UpdateProductDto updateProductDto);
    }
}
