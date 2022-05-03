using AbcYazilim.OgrenciTakip.Model.Entities.Base;

namespace AbcYazilim.OgrenciTakip.Model.Entities
{
    public class EvrakBilgileri: BaseHareketEntity
    {
        public long TahakkukId { get; set; }
        public long EvrakId { get; set; }

        public Evrak Evrak { get; set; }
    }
}