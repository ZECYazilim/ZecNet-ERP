using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace AbcYazilim.OgrenciTakip.Model.Entities
{
    public class EposBilgileri : BaseHareketEntity
    {
        public long TahakkukId { get; set; }
        [Required,StringLength(30)]
        public string Adi { get; set; }
        [Required, StringLength(30)]
        public string Soyadi { get; set; }
        public long BankaId { get; set; }
        public EposKartTuru EposKartTuru { get; set; } = EposKartTuru.Visa;
        [Required, StringLength(50)]
        public string KartNo { get; set; }
        [Required, StringLength(50)]
        public string SonKullanmaTarihi { get; set; } //ay yıl date(x)
        [Required, StringLength(50)]
        public string GuvenlikKodu { get; set; }
        public Banka Banka { get; set; }

    }
}