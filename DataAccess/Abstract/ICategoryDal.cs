using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Corem.DataAccess;

namespace DataAccess.Abstract
{
    public interface ICategoryDal:IEntityRepository<Category>
    {
        
    }
}
