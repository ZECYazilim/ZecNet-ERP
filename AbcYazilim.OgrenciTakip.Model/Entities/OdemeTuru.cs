using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Attributes;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbcYazilim.OgrenciTakip.Model.Entities
{
    public class OdemeTuru:BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }
        [Required, StringLength(50), ZorunluAlan("Ödeme Türü Adı", "txtOdemeTuruAdi")]
        public string OdemeTuruAdi { get; set; }
        public OdemeTipi OdemeTipi { get; set; } = OdemeTipi.Pos;
        [StringLength(500)]
        public string Aciklama { get; set; }
    }
}
