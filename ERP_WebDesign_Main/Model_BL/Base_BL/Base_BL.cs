using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP_WebDesign_Main.Model_BL
{
    public abstract class Base_BL<T>
    {
        public abstract object InsertData(T entity);
        public abstract IEnumerable<T> GetAllItems();
        public abstract object UpdateData(string ItemId, T entity);
        public abstract object DeleteData(string ItemId);
        public abstract T DetailsData(string ItemId);
    }
}