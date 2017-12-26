using System;
using System.Collections.Generic;
using System.Text;

namespace AppBiblioteca.Interfaces
{
   public interface IRepository<Object> where Object: class
    {
        List<Object> GetAll();
        Object GetSingle(int id);
        void Update(Object t);
        void Delete(int id);
    }
}
