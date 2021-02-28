using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Corem.Entities;


namespace Corem.DataAccess
{
   public interface IEntityRepository<T> where T:class, IEntity,new()
    {
        //generic constraint
        //class referans tip
        //IEntity, IEntity olabilir veya IEntity implemente eden bir nesne olabilir
        //new() newlenebilir olmalı

        List<T> GetAll(Expression<Func<T,bool>> filter = null); //filtrele me linq kullanıyoruz bu yapı onu sağlıyor. delegeler.
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
