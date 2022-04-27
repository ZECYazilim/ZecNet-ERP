using AbcYazilim.OgrenciTakip.Bll.Base;
using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace AbcYazilim.OgrenciTakip.Bll.General
{
    public class IlBll:BaseGenelBll<Il>,IBaseGenelBll,IBaseCommonBll
    {
        public IlBll():base(KartTuru.Il) { }
        public IlBll(Control ctrl):base(ctrl,KartTuru.Il) { }    
        
    }

}
