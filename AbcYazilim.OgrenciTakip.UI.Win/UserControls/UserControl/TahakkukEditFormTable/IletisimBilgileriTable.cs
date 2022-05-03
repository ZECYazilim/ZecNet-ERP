using AbcYazilim.OgrenciTakip.Bll.Functions;
using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Common.Message;
using AbcYazilim.OgrenciTakip.Model.Dto;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.IletisimForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.YakinlikForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using AbcYazilim.OgrenciTakip.UI.Win.Show;
using AbcYazilim.OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Base;
using System;
using System.Linq;

namespace AbcYazilim.OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    public partial class IletisimBilgileriTable : BaseTablo
    {
        public IletisimBilgileriTable()
        {
            InitializeComponent();
            Bll = new IletisimBilgileriBll();
            Tablo = tablo;
            EventsLoad();
            ShowItems =new BarItem[]{btnKartDuzenle};
            repositoryAdres.Items.AddEnum < AdresTuru >();
        }
        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((IletisimBilgileriBll)Bll).List(x => x.TahakkukId == OwnerForm.Id).ToBindingList<IletisimBilgileriL>();
        }
        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;
            ListeDisiTutulacakKayitlar = source.Cast<IletisimBilgileriL>().Where(x => !x.Delete).Select(x => x.IletisimId).ToList();
            var entities = ShowListForms<IletisimListForm>.ShowDialogListForm(KartTuru.Iletisim, ListeDisiTutulacakKayitlar, true, false).EntityListConvert<IletisimL>();
            if (entities == null) return;
            foreach (var entity in entities)
            {
                var row = new IletisimBilgileriL
                {
                    TahakkukId = OwnerForm.Id,
                    IletisimId=entity.Id,
                    TcKimlikNo=entity.TcKimlikNo,
                    Adi=entity.Adi,
                    Soyadi=entity.Soyadi,
                    EvTel=entity.EvTel,
                    IsTel1=entity.IsTel1,
                    IsTel2=entity.IsTel2,
                    CepTel1=entity.CepTel1,
                    CepTel2=entity.CepTel2,
                    EvAdres=entity.EvAdres,
                    EvAdresIlAdi=entity.EvAdresIlAdi,
                    EvAdresIlceAdi=entity.EvAdresIlceAdi,
                    IsAdres=entity.IsAdres,
                    IsAdresIlAdi=entity.IsAdresIlAdi,
                    IsAdresIlceAdi=entity.IsAdresIlceAdi,
                    MeslekAdi=entity.MeslekAdi,
                    IsyeriAdi=entity.IsyeriAdi,
                    GorevAdi=entity.GorevAdi,                  
                    Insert = true
                };

                if (source.Count == 0)
                {
                    row.Veli = true;
                    row.FaturaAdresi = AdresTuru.EvAdresi;
                }
                var yakinlik = (Yakinlik)ShowListForms<YakinlikListForm>.ShowDialogListForm(KartTuru.Yakinlik, -1);
                if (yakinlik == null) return;

                row.YakinlikId = yakinlik.Id;
                row.YakinlikAdi = yakinlik.YakinlikAdi;
                source.Add(row);
            }
            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            tablo.FocusedColumn = colVeli;

            ButtonEnabledDurumu(true);
        }
        protected internal override bool HataliGiris()
        {
            if (!TableValueChanged) return false;
            if (tablo.HasColumnErrors) tablo.ClearColumnErrors();
            for (int i = 0; i < tablo.DataRowCount; i++)
            {
                var entity = tablo.GetRow<IletisimBilgileriL>(i);
                if (entity.YakinlikAdi==null)
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colYakinlikAdi;
                    tablo.SetColumnError(colYakinlikAdi, "Yakınlık Adı Alanına Geçerli Bir Değer Giriniz.");
                }
                if (!tablo.HasColumnErrors) continue;
                Messages.TabloEksikBilgiMesaj($"{tablo.ViewCaption} Tablosu");
                return true;
            }
            return false;

        }
        protected override void OpenEntity()
        {
            var entity = tablo.GetRow<IletisimBilgileriL>();
            if (entity == null) return;
            ShowEditForms<IletisimEditForm>.ShowDialogEditForm(KartTuru.Tahakkuk, entity.IletisimId,null);
        }
        protected override void ImageComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            var source = tablo.DataController.ListSource.Cast<IletisimBilgileriL>().ToList();
            if (source.Count == 0) return;
            var rowHandle = tablo.FocusedRowHandle;
            for (int i = 0; i < tablo.DataRowCount; i++)
            {
                if (i == rowHandle) continue;
                if (source[i].FaturaAdresi == null) continue;
                source[i].FaturaAdresi = null;

                if (!source[i].Insert)
                    source[i].Update = true;
            }
            insUptNavigator.Navigator.Buttons.DoClick(insUptNavigator.Navigator.Buttons.EndEdit);
        }
        protected override void CheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            var source = tablo.DataController.ListSource.Cast<IletisimBilgileriL>().ToList();
            if (source.Count == 0) return;
            var rowHandle = tablo.FocusedRowHandle;
            for (int i = 0; i < tablo.DataRowCount; i++)
            {
                if (i == rowHandle) continue;
                if (!source[i].Veli) continue;
                source[i].Veli = false;

                if (!source[i].Insert)
                    source[i].Update = true;
            }
            insUptNavigator.Navigator.Buttons.DoClick(insUptNavigator.Navigator.Buttons.EndEdit);
        }
        protected override void Tablo_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            base.Tablo_FocusedColumnChanged(sender, e);
            if (e.FocusedColumn == colYakinlikAdi)
                e.FocusedColumn.Sec(Tablo, insUptNavigator.Navigator, repositoryYakinlik, colYakinlikId);
        }
    }
}