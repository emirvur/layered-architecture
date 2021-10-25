using LayeredArchitecture.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LayeredArchitecture.Core.Services
{
    public interface ICategoryService : IService<Category>
    {
        Task<Category> GetWithProductsByIdAsync(int categoryId);

        //Category özgü methodlarınız varsa burada tanımlayabilirsiniz.
    }
}
