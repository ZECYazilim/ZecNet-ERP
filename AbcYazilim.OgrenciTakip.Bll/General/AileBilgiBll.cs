using AbcYazilim.OgrenciTakip.Bll.Base;
using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace AbcYazilim.OgrenciTakip.Bll.General
{
    public class AileBilgiBll:BaseGenelBll<AileBilgi>,IBaseGenelBll,IBaseCommonBll
    {
        public AileBilgiBll() : base(KartTuru.AileBilgi) { }
        public AileBilgiBll(Control ctrl):base(ctrl,KartTuru.AileBilgi){}

    }
}
