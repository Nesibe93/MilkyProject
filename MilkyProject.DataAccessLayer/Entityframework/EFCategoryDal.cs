using MilkyProject.DataAccessLayer.Abstract;
using MilkyProject.DataAccessLayer.Context;
using MilkyProject.DataAccessLayer.Repositories;
using MilkyProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyProject.DataAccessLayer.Entityframework
{
    public class EFCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public EFCategoryDal(MilkyContext context) : base(context)
        {
        }

        public int GetCategoryCount()
        {
            var context = new MilkyContext();
            var categoryCount = context.Categories.Count();
            return categoryCount;
        }
    }
}
