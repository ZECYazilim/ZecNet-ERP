using AbcYazilim.OgrenciTakip.Bll.Base;
using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace AbcYazilim.OgrenciTakip.Bll.General
{
    public class ServisBll:BaseGenelBll<Servis>,IBaseCommonBll
    {
        public ServisBll() : base(KartTuru.Servis) { }
        public ServisBll(Control ctrl) : base(ctrl,KartTuru.Servis) { }

    }
}
