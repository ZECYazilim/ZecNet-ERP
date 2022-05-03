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
    public class SinavBilgileriBll : BaseHareketBll<SinavBilgileri, OgrenciTakipContext>, IBaseHareketSelectBll<SinavBilgileri>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<SinavBilgileri, bool>> filter)
        {
            return List(filter, x => new SinavBilgileriL
            {
                Id = x.Id,
                TahakkukId = x.TahakkukId,
                Tarih=x.Tarih,
                SinavAdi=x.SinavAdi,
                PuanTuru=x.PuanTuru,
                Puan=x.Puan,
                Sira=x.Sira,
                Yuzde=x.Yuzde
            }).ToList();
        }
    }
}