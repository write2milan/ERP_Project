using ERP_WebDesign_Main.Model_DAL.Interface;
using ERP_WebDesign_Main.Model_Entity_DB;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ERP_WebDesign_Main.Model_DAL.Repository
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {

        ERP_DEMOEntities context = null;
        private DbSet<T> entities = null;

        public GenericRepository(ERP_DEMOEntities context)
        {
            this.context = context;
            entities = context.Set<T>();
        }

        /// <summary>
        /// Get Data From Database
        /// <para>Use it when to retive data through a stored procedure</para>
        /// </summary>
        public IEnumerable<T> ExecuteQuery(string spQuery, object[] parameters)
        {
            using (context = new ERP_DEMOEntities())
            {
                return context.Database.SqlQuery<T>(spQuery, parameters).ToList();
            }
        }

        /// <summary>
        /// Get Single Data From Database
        /// <para>Use it when to retive single data through a stored procedure</para>
        /// </summary>
        public T ExecuteQuerySingle(string spQuery, object[] parameters)
        {
            using (context = new ERP_DEMOEntities())
            {
                return context.Database.SqlQuery<T>(spQuery, parameters).FirstOrDefault();
            }
        }

        /// <summary>
        /// Insert/Update/Delete Data To Database
        /// <para>Use it when to Insert/Update/Delete data through a stored procedure</para>
        /// </summary>
        public int ExecuteCommand(string spQuery, object[] parameters)
        {
            int result = 0;
            try
            {
                using (context = new ERP_DEMOEntities())
                {
                    result = context.Database.SqlQuery<int>(spQuery, parameters).FirstOrDefault();
                }
            }
            catch { }
            return result;
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}