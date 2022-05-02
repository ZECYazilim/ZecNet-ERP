using AbcYazilim.OgrenciTakip.Model.Attributes;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace AbcYazilim.OgrenciTakip.Model.Entities
{
    public class Sube:BaseEntityDurum
    {
        [Required,StringLength(50),ZorunluAlan("Şube Adı","txtSubeAdi")]
        public string SubeAdi { get; set; }
    }
}
