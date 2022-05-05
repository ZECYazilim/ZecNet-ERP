using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.Model.Entities.Base.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbcYazilim.OgrenciTakip.Model.Dto
{
    [NotMapped]
    public class BilgiNotlariL:BilgiNotlari,IBaseHareketEntity
    {
    public bool Insert { get; set; }
    public bool Update { get; set; }
    public bool Delete { get; set; }
    }
}