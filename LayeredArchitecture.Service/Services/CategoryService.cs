using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LayeredArchitecture.Core.Models;
using LayeredArchitecture.Core.Repositories;
using LayeredArchitecture.Core.Services;
using LayeredArchitecture.Core.UnitOfWorks;
using LayeredArchitecture.Service.Services;

namespace LayeredArchitecture.Service
{
 public class CategoryService : Service<Category>, ICategoryService
    {
        public CategoryService(IUnitOfWork unitOfWork, IRepository<Category> repository) : base(unitOfWork, repository)
        {
        }

        public async Task<Category> GetWithProductsByIdAsync(int categoryId)
        {
            return await _unitOfWork.categories.GetWithProductsByIdAsync(categoryId);
        }
    }
}
