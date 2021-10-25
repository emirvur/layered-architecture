using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LayeredArchitecture.Core.Models;
using LayeredArchitecture.Core.Repositories;
using LayeredArchitecture.Core.Services;
using LayeredArchitecture.Core.UnitOfWorks;
using LayeredArchitecture.Service.Services;
namespace LayeredArchitecture.Service.Services
{
    public class ProductService : Service<Product>, IProductService
    {
        public ProductService(IUnitOfWork unitOfWork, IRepository<Product> repository) : base(unitOfWork, repository)
        {
        }

        public async Task<Product> GetWithCategoryByIdAsync(int productId)
        {
            return await _unitOfWork.Products.GetWithCategoryByIdAsync(productId);
        }
    }
}
