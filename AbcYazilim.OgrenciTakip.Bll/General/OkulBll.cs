using AbcYazilim.OgrenciTakip.Bll.Base;
using AbcYazilim.OgrenciTakip.Data.Contexts;
using AbcYazilim.OgrenciTakip.Model.Dto;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Windows.Forms;
using AbcYazilim.OgrenciTakip.Common.Enums;

namespace AbcYazilim.OgrenciTakip.Bll.General
{
    public class OkulBll : BaseBll<Okul, OgrenciTakipContext>
    {
        protected OkulBll(){}

        protected OkulBll(Control ctrl) : base(ctrl){}
        public BaseEntity Single(Expression<Func<Okul,bool>> filter)
        {
            return BaseSingle(filter, x => new OkulS
            {
                Id=x.Id,
                Kod=x.Kod,
                OkulAdi=x.OkulAdi,
                IlId=x.IlId,
                IlAdi=x.Il.IlAdi,
                IlceId=x.IlceId,
                IlceAdi=x.Ilce.IlceAdi,
                Aciklama=x.Aciklama,
                Durum=x.Durum                           
            });
        }
        public IEnumerable<BaseEntity>List(Expression<Func<Okul,bool>> filter)
        {
            return BaseList(filter, x => new OkulL
            {
                Id=x.Id,
                Kod=x.Kod,
                OkulAdi=x.OkulAdi,
                IlAdi=x.Il.IlAdi,
                IlceAdi=x.Ilce.IlceAdi,
                Aciklama=x.Aciklama
            });
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
            return BaseDelete(entity, KartTuru.Okul);
        }
    }
}
