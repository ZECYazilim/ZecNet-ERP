using AbcYazilim.OgrenciTakip.Bll.Functions;
using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Dto;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.EvrakForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using AbcYazilim.OgrenciTakip.UI.Win.Show;
using AbcYazilim.OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using System.Linq;

namespace AbcYazilim.OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    public partial class EvrakBilgileriTable :BaseTablo
    {
        public EvrakBilgileriTable()
        {
            InitializeComponent();
            Bll = new EvrakBilgileriBll();
            Tablo = tablo;
            EventsLoad();
        }
        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((EvrakBilgileriBll)Bll).List(x => x.TahakkukId == OwnerForm.Id).ToBindingList<EvrakBilgileriL>();
        }
        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;
            ListeDisiTutulacakKayitlar = source.Cast<EvrakBilgileriL>().Where(x => !x.Delete).Select(x => x.EvrakId).ToList();
            var entities = ShowListForms<EvrakListForm>.ShowDialogListForm(KartTuru.Evrak, ListeDisiTutulacakKayitlar, true, false).EntityListConvert<Evrak>();
            if (entities == null) return;
            foreach (var entity in entities)
            {
                var row = new EvrakBilgileriL
                {
                    TahakkukId = OwnerForm.Id,
                    EvrakId=entity.Id,
                    Kod=entity.Kod,
                    EvrakAdi=entity.EvrakAdi,

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