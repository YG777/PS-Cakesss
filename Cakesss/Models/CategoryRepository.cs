using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Cakesss.Models
{
    public class CategoryRepository:ICategoryRepository
    {
        //readonly fiEld for AppDbContext
        private readonly AppDbContext _appDbContext;

        //constructor appDbContext to add val from db to the field
        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
     
        public IEnumerable<Category> Categories => _appDbContext.Categories;
      

    }
}
