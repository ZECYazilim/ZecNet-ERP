using AbcYazilim.OgrenciTakip.Bll.Base;
using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Common.Enums;
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
    public class GeriOdemeBilgileriBll : BaseHareketBll<GeriOdemeBilgileri, OgrenciTakipContext>, IBaseHareketSelectBll<GeriOdemeBilgileri>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<GeriOdemeBilgileri, bool>> filter)
        {
            return List(filter, x => new GeriOdemeBilgileriL
            {
                Id = x.Id,
                TahakkukId = x.TahakkukId,
                Tarih=x.Tarih,
                HesapTuru=x.HesapTuru,
                HesapId=x.HesapTuru==GeriOdemeHesapTuru.Kasa?x.KasaId:x.BankaHesapId,
                HesapAdi=x.HesapTuru==GeriOdemeHesapTuru.Kasa?x.Kasa.KasaAdi:x.BankaHesap.HesapAdi,
                BankaHesapId=x.BankaHesapId,
                KasaId=x.KasaId,
                Tutar=x.Tutar,
                Aciklama = x.Aciklama
            }).ToList();
        }
    }
}