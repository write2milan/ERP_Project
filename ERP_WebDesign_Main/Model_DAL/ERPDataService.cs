using ERP_WebDesign_Main.Model_DAL.Repository;
using ERP_WebDesign_Main.Model_Entity_DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace ERP_WebDesign_Main.Model_DAL
{
    public class ERPDataService<T>: IDisposable where T : class
    {
        private GenericRepository<T> ERPRepository;

        public ERPDataService()
        {
            this.ERPRepository = new GenericRepository<T>(new ERP_DEMOEntities());
        }

        public IEnumerable<T> GetAll(string spQuery, object[] parameters)
        {
            
            return ERPRepository.ExecuteQuery(spQuery, parameters);
        }

        public T GetbyID(string spQuery, object[] parameters)
        {
            
            return ERPRepository.ExecuteQuerySingle(spQuery, parameters);
        }

        public int Insert(string spQuery, object[] parameters)
        {
           
            return ERPRepository.ExecuteCommand(spQuery, parameters);
        }

        public int Update(string spQuery, object[] parameters)
        {
            
            return ERPRepository.ExecuteCommand(spQuery, parameters);
        }

        public int Delete(string spQuery, object[] parameters)
        {
           
            return ERPRepository.ExecuteCommand(spQuery, parameters);
        }
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    ERPRepository.Dispose();
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