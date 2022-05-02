using AbcYazilim.OgrenciTakip.Bll.Base;
using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Dto;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace AbcYazilim.OgrenciTakip.Bll.General
{
    public class TahakkukBll:BaseGenelBll<Tahakkuk>,IBaseCommonBll
    {
        public TahakkukBll():base(KartTuru.Tahakkuk){ }
        public TahakkukBll(Control ctrl):base(ctrl,KartTuru.Tahakkuk){ }
        public override BaseEntity Single(Expression<Func<Tahakkuk, bool>> filter)
        {
            return BaseSingle(filter, x => new TahakkukS
            {
                Id = x.Id,
                Kod = x.Kod,
                OgrenciId=x.OgrenciId,
                TcKimlikNo=x.Ogrenci.TcKimlikNo,
                Adi=x.Ogrenci.Adi,
                Soyadi=x.Ogrenci.Soyadi,
                BabaAdi=x.Ogrenci.BabaAdi,
                AnaAdi=x.Ogrenci.AnaAdi,
                OkulNo=x.OkulNo,
                KayitTarihi=x.KayitTarihi,
                KayitSekli=x.KayitSekli,
                KayitDurumu=x.KayitDurumu,
                SinifId=x.SinifId,
                SinifAdi=x.Sinif.SinifAdi,
                GeldigiOkulId=x.GeldigiOkulId,
                GeldigiOkulAdi=x.GeldigiOkul.OkulAdi,
                KontenjanId=x.KontenjanId,
                KontenjanAdi=x.Kontenjan.KontenjanAdi,
                YabanciDilId=x.YabanciDilId,
                YabanciDilAdi=x.YabanciDil.DilAdi,
                RehberId=x.RehberId,
                RehberAdi=x.Rehber.AdiSoyadi,
                TesvikId=x.TesvikId,
                TesvikAdi=x.Tesvik.TesvikAdi,
                SonrakiDonemKayitDurumu=x.SonrakiDonemKayitDurumu,
                SonrakiDonemKayitDurumuAciklama=x.SonrakiDonemKayitDurumuAciklama,
                OzelKod1Id = x.OzelKod1Id,
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Id = x.OzelKod2Id,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
                OzelKod3Id = x.OzelKod3Id,
                OzelKod3Adi = x.OzelKod3.OzelKodAdi,
                OzelKod4Id = x.OzelKod4Id,
                OzelKod4Adi = x.OzelKod4.OzelKodAdi,
                OzelKod5Id = x.OzelKod5Id,
                OzelKod5Adi = x.OzelKod5.OzelKodAdi,               
                DonemId = x.DonemId,
                SubeId = x.SubeId,
                Durum = x.Durum
            });
        }
        public BaseEntity SingleSummary(Expression<Func<Tahakkuk, bool>> filter)
        {
            return BaseSingle(filter, x => x);
        }
        public override IEnumerable<BaseEntity> List(Expression<Func<Tahakkuk, bool>> filter)
        {
            return BaseList(filter, x => new TahakkukL
            {
                Id = x.Id,
                Kod = x.Kod,
                OgrenciId = x.OgrenciId,
                TcKimlikNo = x.Ogrenci.TcKimlikNo,
                Adi = x.Ogrenci.Adi,
                Soyadi = x.Ogrenci.Soyadi,
                BabaAdi = x.Ogrenci.BabaAdi,
                AnaAdi = x.Ogrenci.AnaAdi,
                OkulNo = x.OkulNo,
                KayitTarihi = x.KayitTarihi,
                KayitSekli = x.KayitSekli,
                KayitDurumu = x.KayitDurumu,
                SinifAdi = x.Sinif.SinifAdi,
                GeldigiOkulAdi = x.GeldigiOkul.OkulAdi,
                KontenjanAdi = x.Kontenjan.KontenjanAdi,
                YabanciDilAdi = x.YabanciDil.DilAdi,
                RehberAdi = x.Rehber.AdiSoyadi,
                TesvikAdi = x.Tesvik.TesvikAdi,
                SonrakiDonemKayitDurumu = x.SonrakiDonemKayitDurumu,
                SonrakiDonemKayitDurumuAciklama = x.SonrakiDonemKayitDurumuAciklama,
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
                OzelKod3Adi = x.OzelKod3.OzelKodAdi,
                OzelKod4Adi = x.OzelKod4.OzelKodAdi,
                OzelKod5Adi = x.OzelKod5.OzelKodAdi,
                SubeAdi=x.Sube.SubeAdi,
                Durum = x.Durum                           
            }).OrderBy(x => x.Kod).ToList();
        }
    }
}