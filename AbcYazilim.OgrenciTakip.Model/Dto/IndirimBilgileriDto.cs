using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.Model.Entities.Base.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbcYazilim.OgrenciTakip.Model.Dto
{
    [NotMapped]
    public class IndirimBilgileriL:IndirimBilgileri,IBaseHareketEntity
    {
        public string IndirimAdi { get; set; }
        public string HizmetAdi { get; set; }
        public string IptalNedeniAdi { get; set; }
        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
}