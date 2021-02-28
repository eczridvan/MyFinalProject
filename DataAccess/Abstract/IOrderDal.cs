using System;
using System.Collections.Generic;
using System.Text;
using Corem.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IOrderDal:IEntityRepository<Order>
    {

    }
}
