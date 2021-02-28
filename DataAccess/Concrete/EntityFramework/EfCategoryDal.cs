using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Corem.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal:EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal 
    {
      
    }
}
