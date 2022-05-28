using AbcYazilim.OgrenciTakip.Model.Attributes;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace AbcYazilim.OgrenciTakip.Model.Entities
{
    public class Sube:BaseEntityDurum
    {
        [Required,StringLength(50),ZorunluAlan("Şube Adı","txtSubeAdi")]
        public string SubeAdi { get; set; }


        //<<>>
        [StringLength(255)]
        public string Adres { get; set; }
        [ZorunluAlan("İl Adı", "txtAdresIl")]
        public long AdresIlId { get; set; }
        [ZorunluAlan("İlçe Adı", "txtAdresIlce")]
        public long AdresIlceId { get; set; }
        public Il AdresIl { get; set; }
        public Ilce AdresIlce { get; set; }

    }
}
