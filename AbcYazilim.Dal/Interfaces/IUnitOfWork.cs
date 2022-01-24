using System;

namespace AbcYazilim.Dal.Interfaces
{
    public interface IUnitOfWork<T>:IDisposable where T : class
    {
        IRepository<T> Rep { get; }
        bool Save(); //Save fonksiyonu sonucunda DB üzerine yapılan işlemlerin sonucu karşılanacak.
        
    }
}
