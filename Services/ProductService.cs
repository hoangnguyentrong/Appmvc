using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppMvc.Models;

namespace AppMvc.Services
{
  public class ProductService : List<ProductModel>
  {
    public ProductService()
    {
      this.AddRange(new ProductModel[]{
        new ProductModel() {Id = 1, Name = "Iphone", Price = 10000 },
        new ProductModel() {Id = 2, Name = "Iphone1", Price = 20000 },
        new ProductModel() {Id = 3, Name = "Iphone2", Price = 30000 },
        new ProductModel() {Id = 4, Name = "Iphone3", Price = 40000 }
      });
    }
  }
}