using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Common.Message;
using AbcYazilim.OgrenciTakip.Model.Dto;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using AbcYazilim.OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using DevExpress.XtraGrid.Views.Base;
using System;

namespace AbcYazilim.OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    public partial class GeriOdemeBilgileriTable : BaseTablo
    {
        public GeriOdemeBilgileriTable()
        {
            InitializeComponent();
            Bll = new GeriOdemeBilgileriBll();
            Tablo = tablo;
            EventsLoad();
            repositoryHesapTuru.Items.AddEnum<GeriOdemeHesapTuru>();
        }
        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((GeriOdemeBilgileriBll)Bll).List(x => x.TahakkukId == OwnerForm.Id).ToBindingList<GeriOdemeBilgileriL>();
        }
        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;

            var row = new GeriOdemeBilgileriL
            {
                TahakkukId = OwnerForm.Id,
                Tarih = DateTime.Now.Date,
                HesapTuru = GeriOdemeHesapTuru.Kasa,
                Tutar = 0,
                Insert = true
            };
            source.Add(row);

            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            tablo.FocusedColumn = colHesapAdi;
            ButtonEnabledDurumu(true);
        }
        protected internal override bool HataliGiris()
        {
            if (!TableValueChanged) return false;
            if (tablo.HasColumnErrors) tablo.ClearColumnErrors();
            for (int i = 0; i < tablo.DataRowCount; i++)
            {
                var entity = tablo.GetRow<GeriOdemeBilgileriL>(i);
                if (entity.HesapId == null)
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colHesapAdi;
                    tablo.SetColumnError(colHesapAdi, "Hesap Seçimi Yapmalısınız.");
                }
                if (entity.Tutar <= 0)
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colTutar;
                    tablo.SetColumnError(colTutar, "Sıfırdan Büyük Bir Değer Giriniz.");
                }

                if (!tablo.HasColumnErrors) continue;
                Messages.TabloEksikBilgiMesaj($"{tablo.ViewCaption} Tablosu");
                return true;
            }
            return false;

        }
        protected override void Tablo_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            base.Tablo_CellValueChanged(sender, e);

            if (e.Column != colHesapId) return;

            var entity = tablo.GetRow<GeriOdemeBilgileriL>();
            entity.BankaHesapId = entity.HesapTuru == GeriOdemeHesapTuru.Banka ? entity.HesapId : null;
            entity.KasaId = entity.HesapTuru == GeriOdemeHesapTuru.Kasa ? entity.HesapId : null;
        }
        protected override void Tablo_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            base.Tablo_FocusedColumnChanged(sender, e);
            if (e.FocusedColumn == colHesapAdi)
                e.FocusedColumn.Sec(Tablo, insUptNavigator.Navigator, repositoryHesap, colHesapId);
        }
        protected override void ImageComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            var entity = tablo.GetRow<GeriOdemeBilgileriL>();

            entity.HesapId = null;
            entity.HesapAdi = null;
            tablo.FocusedColumn = colHesapAdi;
        }
    }
}