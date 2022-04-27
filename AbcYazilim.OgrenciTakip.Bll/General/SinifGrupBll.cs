using AbcYazilim.OgrenciTakip.Bll.Base;
using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace AbcYazilim.OgrenciTakip.Bll.General
{
    public class SinifGrupBll:BaseGenelBll<SinifGrup>,IBaseGenelBll,IBaseCommonBll
    {
        public SinifGrupBll():base(KartTuru.SinifGrup) { }

        public SinifGrupBll(Control ctrl):base(ctrl,KartTuru.SinifGrup) { }

    }
}
