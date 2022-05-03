using AbcYazilim.OgrenciTakip.Bll.Functions;
using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Dto;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.PromosyonForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using AbcYazilim.OgrenciTakip.UI.Win.Show;
using AbcYazilim.OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using System.Linq;

namespace AbcYazilim.OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    public partial class PromosyonBilgileriTable : BaseTablo
    {
        public PromosyonBilgileriTable()
        {
            InitializeComponent();
            Bll = new PromosyonBilgileriBll();
            Tablo = tablo;
            EventsLoad();
        }      
        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((PromosyonBilgileriBll)Bll).List(x => x.TahakkukId == OwnerForm.Id).ToBindingList<PromosyonBilgileriL>();
        }
        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;
            ListeDisiTutulacakKayitlar = source.Cast<PromosyonBilgileriL>().Where(x => !x.Delete).Select(x => x.PromosyonId).ToList();
            var entities = ShowListForms<PromosyonListForm>.ShowDialogListForm(KartTuru.Promosyon, ListeDisiTutulacakKayitlar, true, false).EntityListConvert<Promosyon>();
            if (entities == null) return;
            foreach (var entity in entities)
            {
                var row = new PromosyonBilgileriL
                {
                    TahakkukId = OwnerForm.Id,
                    PromosyonId = entity.Id,
                    Kod = entity.Kod,
                    PromosyonAdi = entity.PromosyonAdi,

                    Insert = true
                };
                source.Add(row);
            }
            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            tablo.FocusedColumn = colKod;
            ButtonEnabledDurumu(true);
        }
    }
}