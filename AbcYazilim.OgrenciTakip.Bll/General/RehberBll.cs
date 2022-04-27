using AbcYazilim.OgrenciTakip.Bll.Base;
using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace AbcYazilim.OgrenciTakip.Bll.General
{
    public class RehberBll:BaseGenelBll<Rehber>,IBaseCommonBll,IBaseGenelBll
    {
        public RehberBll() : base(KartTuru.Rehber) { }
        public RehberBll(Control ctrl) : base(ctrl, KartTuru.Rehber) { }



        
    }
}
