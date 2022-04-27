using AbcYazilim.OgrenciTakip.Bll.Base;
using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace AbcYazilim.OgrenciTakip.Bll.General
{
    public class FiltreBll: BaseGenelBll<Filtre>, IBaseCommonBll
    {
        public FiltreBll():base(KartTuru.Filtre) { }

        public FiltreBll(Control ctrl):base(ctrl,KartTuru.Filtre) { }
      
    }
}
