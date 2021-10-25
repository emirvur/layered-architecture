using LayeredArchitecture.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LayeredArchitecture.Core.Services
{
    public interface IProductService : IService<Product>
    {
        Task<Product> GetWithCategoryByIdAsync(int productId);

        //  bool ControlInnerBarcode(Product product);
    }
}
