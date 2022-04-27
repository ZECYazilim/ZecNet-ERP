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
    public class IletisimBll:BaseGenelBll<Iletisim>,IBaseGenelBll,IBaseCommonBll
    {
        public IletisimBll() : base(KartTuru.Iletisim) { }
        public IletisimBll(Control ctrl) : base(ctrl,KartTuru.Iletisim) { }


        public override BaseEntity Single(Expression<Func<Iletisim, bool>> filter)
        {
            return BaseSingle(filter, x => new IletisimS
            {
                Id = x.Id,
                Kod = x.Kod,
                TcKimlikNo=x.TcKimlikNo,
                Adi=x.Adi,
                Soyadi=x.Soyadi,
                BabaAdi=x.BabaAdi,
                AnaAdi=x.AnaAdi,
                DogumYeri=x.DogumYeri,
                DogumTarihi=x.DogumTarihi,
                KanGrubu=x.KanGrubu,
                KimlikSeri=x.KimlikSeri,
                KimlikSiraNo=x.KimlikSiraNo,
                KimlikIlId=x.KimlikIlId,
                KimlikIlAdi=x.KimlikIl.IlAdi,
                KimlikIlceId = x.KimlikIlceId,
                KimlikIlceAdi = x.KimlikIlce.IlceAdi,
                KimlikMahalleKoy=x.KimlikMahalleKoy,
                KimlikCiltNo=x.KimlikCiltNo,
                KimlikAileSiraNo=x.KimlikAileSiraNo,
                KimlikBireySiraNo=x.KimlikBireySiraNo,
                KimlikVerildigiYer=x.KimlikVerildigiYer,
                KimlikVerilisNedeni=x.KimlikVerilisNedeni,
                KimlikKayitNo=x.KimlikKayitNo,
                KimlikVerilisTarihi=x.KimlikVerilisTarihi,
                EvTel=x.EvTel,
                IsTel1=x.IsTel1,
                IsTel2=x.IsTel2,
                Dahili1=x.Dahili1,
                Dahili2=x.Dahili2,
                CepTel1=x.CepTel1,
                CepTel2=x.CepTel2,
                Web=x.Web,
                Email=x.Email,
                EvAdres=x.EvAdres,
                EvAdresIlId=x.EvAdresIlId,
                EvAdresIlAdi=x.EvAdresIl.IlAdi,
                EvAdresIlceId = x.EvAdresIlceId,
                EvAdresIlceAdi = x.EvAdresIlce.IlceAdi,
                IsAdres=x.IsAdres,
                IsAdresIlId=x.IsAdresIlId,
                IsAdresIlAdi=x.IsAdresIl.IlAdi,
                IsAdresIlceId = x.IsAdresIlceId,
                IsAdresIlceAdi = x.IsAdresIlce.IlceAdi,
                MeslekId=x.MeslekId,
                MeslekAdi=x.Meslek.MeslekAdi,
                IsyeriId=x.IsyeriId,
                IsyeriAdi=x.Isyeri.IsYeriAdi,
                GorevId=x.GorevId,
                GorevAdi=x.Gorev.GorevAdi,
                KartNo=x.KartNo,
                IbanNo=x.IbanNo,
                OzelKod1Id = x.OzelKod1Id,
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Id = x.OzelKod2Id,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
                Aciklama = x.Aciklama,
                Durum = x.Durum
            });
        }
        public override IEnumerable<BaseEntity> List(Expression<Func<Iletisim, bool>> filter)
        {
            return BaseList(filter, x => new IletisimL
            {
                Id = x.Id,
                Kod = x.Kod,
                TcKimlikNo = x.TcKimlikNo,
                Adi = x.Adi,
                Soyadi = x.Soyadi,
                BabaAdi = x.BabaAdi,
                AnaAdi = x.AnaAdi,
                DogumYeri = x.DogumYeri,
                DogumTarihi = x.DogumTarihi,
                KanGrubu = x.KanGrubu,
                KimlikSeri = x.KimlikSeri,
                KimlikSiraNo = x.KimlikSiraNo,
                KimlikIlAdi = x.KimlikIl.IlAdi,
                KimlikIlceAdi = x.KimlikIlce.IlceAdi,
                KimlikMahalleKoy = x.KimlikMahalleKoy,
                KimlikCiltNo = x.KimlikCiltNo,
                KimlikAileSiraNo = x.KimlikAileSiraNo,
                KimlikBireySiraNo = x.KimlikBireySiraNo,
                KimlikVerildigiYer = x.KimlikVerildigiYer,
                KimlikVerilisNedeni = x.KimlikVerilisNedeni,
                KimlikKayitNo = x.KimlikKayitNo,
                KimlikVerilisTarihi = x.KimlikVerilisTarihi,
                EvTel = x.EvTel,
                IsTel1 = x.IsTel1,
                IsTel2 = x.IsTel2,
                Dahili1 = x.Dahili1,
                Dahili2 = x.Dahili2,
                CepTel1 = x.CepTel1,
                CepTel2 = x.CepTel2,
                Web = x.Web,
                Email = x.Email,
                EvAdres = x.EvAdres,
                EvAdresIlAdi = x.EvAdresIl.IlAdi,
                EvAdresIlceAdi = x.EvAdresIlce.IlceAdi,
                IsAdres = x.IsAdres,
                IsAdresIlAdi = x.IsAdresIl.IlAdi,
                IsAdresIlceAdi = x.IsAdresIlce.IlceAdi,
                MeslekAdi = x.Meslek.MeslekAdi,
                IsyeriAdi = x.Isyeri.IsYeriAdi,
                GorevAdi = x.Gorev.GorevAdi,
                KartNo = x.KartNo,
                IbanNo=x.IbanNo,
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
                Aciklama = x.Aciklama,
            }).OrderBy(x => x.Kod).ToList();
        }
    }
}
