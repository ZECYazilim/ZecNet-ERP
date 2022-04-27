using AbcYazilim.OgrenciTakip.Bll.Base;
using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Data.Contexts;
using AbcYazilim.OgrenciTakip.Model.Dto;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace AbcYazilim.OgrenciTakip.Bll.General
{
    public class IndiriminUygulanacagiHizmetBilgileriBll:BaseHareketBll<IndiriminUygulanacagiHizmetBilgileri,OgrenciTakipContext>,IBaseHareketSelectBll<IndiriminUygulanacagiHizmetBilgileri>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<IndiriminUygulanacagiHizmetBilgileri, bool>> filter)
        {
            return List(filter, x => new IndiriminUygulanacagiHizmetBilgileriL 
            {
                Id=x.Id,
                IndirimId=x.IndirimId,
                HizmetId=x.HizmetId,
                HizmetAdi=x.Hizmet.HizmetAdi,
                IndirimTutari=x.IndirimTutari,
                IndirimOrani=x.IndirimOrani,
                SubeId=x.SubeId,
                DonemId=x.DonemId
            }).ToList();
        }
    }
}
