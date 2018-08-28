using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using LinkPosModelo;
using Microsoft.Win32;

namespace LinkPosControl
{
    public class DataPos
    {
        private const string AMIGO_REG_KEY = "Software\\Amigo Point Of Sale\\";
        private ContextPosData context;

        public DataPos()
        {
            context = new ContextPosData(ConnString());
        }

        private string ConnString()
        {
            string value = "";

            try
            {
                bool bWindowsSecurity = (RegRead("Database", "SQLServerSecurity") == "0" ? true : false);
                string strServerName = RegRead("Database", "SQLServerName");
                string strUserId = RegRead("Database", "SQLServerUser");
                string strPassword = RegRead("Database", "SQLServerPassword");
                string SQLServerDatabaseName = RegRead("Database", "SQLServerDatabaseName");

                if (bWindowsSecurity)
                {
                    value = "server=" + strServerName + ";Integrated Security=SSPI;Persist Security Info=False" + ";database=" + SQLServerDatabaseName;
                }
                else
                {
                    value = "server=" + strServerName + ";uid=" + strUserId + ";pwd=" + strPassword + ";database=" + SQLServerDatabaseName;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al generar la cadena de conexion.", e);
            }

            return value;

        }

        private string RegRead(string strSubKey, string strValueName)
        {
            RegistryKey regKey, regSubKey;
            string tmpValue = "";
            try
            {
                regKey = Registry.CurrentUser;
                regSubKey = regKey.CreateSubKey(AMIGO_REG_KEY + strSubKey);
                tmpValue = (regSubKey.GetValue(strValueName)).ToString();
            }
            catch (Exception e)
            {
                throw new Exception("Error al leer el registro de AmigoPos (Software\\Amigo Point Of Sale\\).", e);
            }

            return tmpValue;
        }

        public IQueryable<T> GetAll<T>() where T : class
        {
            try
            {
                return context.Set<T>();
            }
            catch (Exception e)
            {
                throw new Exception("Se ha generado un error al intentar obtener las entidades: " + e.Message);
            }
        }

        public IQueryable<T> GetAll<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            try
            {
                return context.Set<T>().Where(predicate);
            }
            catch (Exception e)
            {
                throw new Exception("Se ha generado un error al intentar obtener las entidades: " + e.Message);
            }
        }

        public T Get<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            T entidad = null;

            try
            {
                entidad = context.Set<T>().FirstOrDefault(predicate);
                return entidad;
            }
            catch (Exception e)
            {
                throw new Exception("Se ha generado un error al intentar obtener la entidad: " + e.Message);
            }
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
                    throw new Exception("Se ha generado un error al intentar actualizar la entidad: " + e.Message);
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
                    throw new Exception("Se ha generado un error al intentar eliminar la entidad: " + e.Message);
                }
            }

        }
    }
}
