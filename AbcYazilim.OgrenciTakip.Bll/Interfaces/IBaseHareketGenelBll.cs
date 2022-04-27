using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using System.Collections.Generic;

namespace AbcYazilim.OgrenciTakip.Bll.Interfaces
{
    public interface IBaseHareketGenelBll
    {
        bool Insert(IList<BaseHareketEntity> entities);
        bool Update(IList<BaseHareketEntity> entitites);
        bool Delete(IList<BaseHareketEntity> entitites);
    }
}