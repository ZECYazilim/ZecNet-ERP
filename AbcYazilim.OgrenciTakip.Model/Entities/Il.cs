using AbcYazilim.OgrenciTakip.Model.Entities.Base;

namespace AbcYazilim.OgrenciTakip.Model.Entities
{
    //[Table("Tablo adı ")] kullanılabilir.
    public class Il:BaseEntityDurum
    {
        public string IlAdi { get; set; }
        public string Aciklama { get; set; }
    }
}
