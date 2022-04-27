using AbcYazilim.OgrenciTakip.Bll.Base;
using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace AbcYazilim.OgrenciTakip.Bll.General
{
    public class IndirimTuruBll:BaseGenelBll<IndirimTuruu>,IBaseGenelBll,IBaseCommonBll
    {
        public IndirimTuruBll():base(KartTuru.IndirimTuru) { }
        public IndirimTuruBll(Control ctrl):base(ctrl,KartTuru.IndirimTuru) { }

    }
}
