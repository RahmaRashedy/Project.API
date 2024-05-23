using ClassLibrary1.BL.Dtos.Product;
using ClassLibrary1.DAL.Repositorries.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.DAL.Models;
using ClassLibrary1.DAL.Data;
using ClassLibrary1.DAL.Repositorries;
using System.ComponentModel;
using ClassLibrary1.BL.Manager.Product;

namespace ClassLibrary1.BL.Manager.Product
{
    public class ProductManager : IProductManager
    {
        private readonly IUnitOfWork _unitofwork;
        public ProductManager(IUnitOfWork unitOfWork)
        {
            _unitofwork = unitOfWork;

        }
        public void Add(AddProductDto addProductDto, string url)
        {
            var newproduct = new DAL.Models.Product
            {
                Id = addProductDto.Id,
                Name = addProductDto.Name,
                Category = addProductDto.Category,
                stock = addProductDto.Stock,
                Description = addProductDto.Description,
                Price = addProductDto.Price,
                ImageUrl = url
            };
            _unitofwork.ProductRepository.Add(newproduct);
            _unitofwork.Savechages();
        }

        public void Delete(int id)
        {
            var product = _unitofwork.ProductRepository.GetById(id);
            if (product == null) { return; }
            _unitofwork.ProductRepository.Delete(product);
            _unitofwork.Savechages();
        }

        public void Update(UpdateProductDto updateProductDto, string url)
        {
            var product = _unitofwork.ProductRepository.GetById(updateProductDto.Id);
            if (product == null) { return; }

            product.Price = updateProductDto.Price;
            product.stock = updateProductDto.Quantity;
            product.ImageUrl = url;
            _unitofwork.ProductRepository.Update(product);

            _unitofwork.Savechages();
        }

        public void Update2(UpdateProductDto updateProductDto)
        {
            var product = _unitofwork.ProductRepository.GetById(updateProductDto.Id);
            if (product == null) { return; }
           
            product.Price = updateProductDto.Price;
            product.stock = updateProductDto.Quantity;
            _unitofwork.ProductRepository.Update(product);
            _unitofwork.Savechages();

        }

        public IEnumerable<DetailsProductDto> GetAll()
        {
            var products = _unitofwork.ProductRepository.GetAll();
            return products.Select(p => new DetailsProductDto
            {
                Id = p.Id,
                Name = p.Name,
                Category = p.Category,
                Price = p.Price,
                Quantity = p.stock,
                URL = p.ImageUrl

        });
        }

        public DetailsProductDto? GetById(int id)
        {
            var product = _unitofwork.ProductRepository.GetById(id);
            if (product == null)
            {
                return null;
            }
            return new DetailsProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Category = product.Category,
                Price = product.Price,
                Quantity = product.stock,
                URL = product.ImageUrl

            };
        }

        public IEnumerable<DetailsProductDto> GetProductsByCategoryandName(string category,string name)
        {
            category = category ?? string.Empty;
            name = name ?? string.Empty;

            var products = _unitofwork.ProductRepository.GetByCategoryandName(category, name);

            return products.Select(p => new DetailsProductDto
            {
                Id = p.Id,
                Name = p.Name,
                Category = p.Category,
                Price = p.Price,
                Quantity = p.stock,
            });
        }
     

    
    }
}
