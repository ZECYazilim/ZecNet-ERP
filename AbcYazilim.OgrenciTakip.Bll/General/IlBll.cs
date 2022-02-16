using AbcYazilim.OgrenciTakip.Bll.Base;
using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Data.Contexts;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace AbcYazilim.OgrenciTakip.Bll.General
{
    public class IlBll:BaseBll<Il,OgrenciTakipContext>,IBaseGenelBll
    {
        public IlBll() { }
        public IlBll(Control ctrl):base(ctrl) { }
        public BaseEntity Single(Expression<Func<Il,bool>> filter)
        {
            return BaseSingle(filter, x =>x);
        }
        public IEnumerable<BaseEntity> List(Expression<Func<Il,bool>> filter)
        {
            return BaseList(filter, x => x).OrderBy(x=>x.Kod).ToList();
        }
        public bool Insert(BaseEntity entity)
        {
            return BaseInsert(entity, x => x.Kod == entity.Kod);
        }
        public bool Update(BaseEntity oldEntity,BaseEntity currentEntity)
        {
            return BaseUpdate(oldEntity, currentEntity, x => x.Kod == currentEntity.Kod);
        }
        public bool Delete(BaseEntity entity)
        {
            return BaseDelete(entity, KartTuru.Il);
        }
        public string CreateNewCode()
        {
            return BaseCreateNewCode(KartTuru.Il, x => x.Kod);
        }
    }
}
