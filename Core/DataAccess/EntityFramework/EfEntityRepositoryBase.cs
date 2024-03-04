using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.Entities;
using Microsoft.EntityFrameworkCore;


namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity> //TABLOLARI ETKİLEYEN TÜM YAPILAR İÇİN ALTYAPIYA (CORE)
                                                                                        //BİR CLASS AÇTIK
        where TEntity : class, IEntity, new()  //her sınıf ya da yapı eklenemesin doğru yönlendirme adına kısıtladık
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            //Belleği hızlıca temizlemeye yarar kodun daha kaliteli olması için önemlidir
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() //eğer filtre yok ise bütün ürünleri getir.
                    : context.Set<TEntity>().Where(filter).ToList();   // eğer filitre seçilmiş ise filitreyi uygulayarak tüm ürünleri getir.
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
