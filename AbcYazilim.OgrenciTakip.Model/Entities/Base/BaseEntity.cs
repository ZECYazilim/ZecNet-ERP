using AbcYazilim.OgrenciTakip.Model.Entities.Base.Interfaces;

namespace AbcYazilim.OgrenciTakip.Model.Entities.Base
{
    public class BaseEntity:IBaseEntity
    {
        public long Id { get; set; }
        public string Kod { get; set; }
    }
}
