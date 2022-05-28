using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Dto;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using AbcYazilim.OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using DevExpress.XtraBars;
using System.Linq;

namespace AbcYazilim.OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    public partial class OdemeBilgileriTable : BaseTablo
    {
        public OdemeBilgileriTable()
        {
            InitializeComponent();
            Bll = new OdemeBilgileriBll();
            Tablo = tablo;
            EventsLoad();
            ShowItems = new BarItem[] { btnBelgeHareketleri };
        }
        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((OdemeBilgileriBll)Bll).List(x => x.TahakkukId == OwnerForm.Id).ToBindingList<OdemeBilgileriL>();
        }
        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;
            var dahaOnceGirilenTaksitSayisi = source
                .Cast<OdemeBilgileriL>()
                .Count(x => !x.Delete && x.BelgeDurumu != BelgeDurumu.MusteriyeGeriIade);

        }
    }
}