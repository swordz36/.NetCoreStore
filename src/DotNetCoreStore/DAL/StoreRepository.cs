using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetCoreStore.Models;

namespace DotNetCoreStore.DAL
{
    public class StoreRepository : IStoreRepository
    {
        private StoreContext _context;

        public StoreRepository(StoreContext ctx)
        {
            _context = ctx;
        }

        public IEnumerable<Product> Products => _context.Products;
        public IEnumerable<Category> Categories => _context.Categories;

    }
}
