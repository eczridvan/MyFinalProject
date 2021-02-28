using System;
using System.Collections.Generic;
using System.Text;
using Corem.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
   public interface ICustomerDal:IEntityRepository<Customer>
    {

    }
}
