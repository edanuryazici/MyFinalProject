using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //sınırlandırdık ki herkes T göndermesin seçili sınıflar yollasın
    public interface IEntityRepository<T> where T:class,IEntity,new() //Product, customer, category sınıfları bu ınterfaceden türeme olduğu
                                                                 //için çok kullanışlı genel bir tanımlama yapmış olduk.
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        
    }
}
