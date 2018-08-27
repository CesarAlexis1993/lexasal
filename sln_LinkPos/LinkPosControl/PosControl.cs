using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using LinkPosModelo;

namespace LinkPosControl
{
    public class PosControl
    {
        private ContextPosData context;

        public PosControl()
        {
            context = new ContextPosData();
        }

        public void Create(object entidad)
        {
            using (var dbcxtransact = context.Database.BeginTransaction())
            {
                try
                {
                    if (entidad != null)
                    {
                        context.Entry(entidad).State = EntityState.Added;
                        context.SaveChanges();
                        dbcxtransact.Commit();
                    }
                }
                catch (Exception e)
                {
                    dbcxtransact.Rollback();
                }
            }

        }

        public List<T> GetAll<T>() where T : class
        {
            //using (var dbcxtransact = context.Database.BeginTransaction())
            //{
            //    try
            //    {
            //        if (entidad != null)
            //        {
            //            context.Entry(entidad).State = EntityState.Modified;
            //            context.SaveChanges();
            //            dbcxtransact.Commit();
            //        }
            //    }
            //    catch (Exception e)
            //    {
            //        dbcxtransact.Rollback();
            //    }
            //}
            return null;
        }

        public T Get<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            T entidad = null;
            {
                entidad = context.Set<T>().FirstOrDefault(predicate);
            }
            return entidad;
        }

        public void Update(object entidad)
        {
            using (var dbcxtransact = context.Database.BeginTransaction())
            {
                try
                {
                    if (entidad != null)
                    {
                        context.Entry(entidad).State = EntityState.Modified;
                        context.SaveChanges();
                        dbcxtransact.Commit();
                    }
                }
                catch (Exception e)
                {
                    dbcxtransact.Rollback();
                }
            }

        }

        public void Delete(object entidad)
        {
            using (var dbcxtransact = context.Database.BeginTransaction())
            {
                try
                {
                    if (entidad != null)
                    {
                        context.Entry(entidad).State = EntityState.Deleted;
                        context.SaveChanges();
                        dbcxtransact.Commit();
                    }
                }
                catch (Exception e)
                {
                    dbcxtransact.Rollback();
                }
            }

        }
    }
}
