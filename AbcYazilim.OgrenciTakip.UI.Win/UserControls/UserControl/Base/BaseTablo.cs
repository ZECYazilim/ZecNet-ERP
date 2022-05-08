using AbcYazilim.OgrenciTakip.Common.Message;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using AbcYazilim.OgrenciTakip.Model.Entities.Base.Interfaces;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using DevExpress.Utils.Extensions;
using DevExpress.XtraGrid.Views.Base;
using AbcYazilim.OgrenciTakip.UI.Win.Interfaces;
using System.Linq;
using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using System.Collections.Generic;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Repository;

namespace AbcYazilim.OgrenciTakip.UI.Win.UserControls.UserControl.Base
{
    public partial class BaseTablo : XtraUserControl
    {
        private bool _isLoaded;
        private bool _tabloSablonKayitEdilecek;
        protected internal GridView Tablo;
        protected internal BaseEditForm OwnerForm;
        protected internal bool TableValueChanged;
        protected BarItem[] ShowItems;
        protected BarItem[] HideItems;
        protected IBaseBll Bll;
        protected IList<long> ListeDisiTutulacakKayitlar;
        public BaseTablo()
        {
            InitializeComponent();
        }
        protected void EventsLoad()
        {
            //Button Events
            foreach (BarItem button in barManager.Items)
                button.ItemClick += Button_ItemClick;

            foreach(GridColumn column in Tablo.Columns)
            {
                if (column.ColumnEdit == null) continue;
                var type = column.ColumnEdit.GetType();

                if(type==typeof(RepositoryItemImageComboBox))
                    ((RepositoryItemImageComboBox)column.ColumnEdit).SelectedValueChanged += ImageComboBox_SelectedValueChanged;
                if(type==typeof(RepositoryItemCheckEdit))
                    ((RepositoryItemCheckEdit)column.ColumnEdit).CheckedChanged += CheckEdit_CheckedChanged;
            }
            //Navigator Events
            insUptNavigator.Navigator.ButtonClick += Navigator_ButtonClick;

            //Table Events
            Tablo.CellValueChanged += Tablo_CellValueChanged;
            Tablo.MouseUp += Tablo_MouseUp;
            Tablo.GotFocus += Tablo_GotFocus;
            Tablo.LostFocus += Tablo_LostFocus;
            Tablo.KeyDown += Tablo_KeyDown;
            Tablo.FocusedColumnChanged += Tablo_FocusedColumnChanged;
            Tablo.ColumnPositionChanged += Tablo_SablonChanged;
            Tablo.ColumnWidthChanged += Tablo_SablonChanged;
            Tablo.EndSorting += Tablo_SablonChanged;
            Tablo.DoubleClick += Tablo_DoubleClick;
            Tablo.FocusedRowObjectChanged += Tablo_FocusedRowObjectChanged;
        }

        protected internal void Yukle()
        {
            _isLoaded = true;
            TableValueChanged = false;
            OwnerForm.ButtonEnableSituation();
            insUptNavigator.Navigator.NavigatableControl = Tablo.GridControl;
            SablonYukle();
            Listele();
            ButonGizleGoster();
            Tablo_LostFocus(Tablo, EventArgs.Empty);
        }
        private void SablonKaydet()
        {
            if (_tabloSablonKayitEdilecek)
                Tablo.TabloSablonKaydet(Tablo.ViewCaption);
        }
        private void SablonYukle()
        {
            Tablo.TabloSablonYukle(Tablo.ViewCaption);

        }
        protected virtual void Listele(){ }
        private void ButonGizleGoster()
        {
            ShowItems?.ForEach(x => x.Visibility = BarItemVisibility.Always);
            HideItems?.ForEach(x => x.Visibility = BarItemVisibility.Never);
        }     
        protected virtual void HareketEkle(){}
        protected virtual void HareketSil()
        {
            if (Tablo.DataRowCount == 0) return;
            if (Messages.SilMesaj("İşlem Satırı") != DialogResult.Yes) return;

            Tablo.GetRow<IBaseHareketEntity>().Delete = true;
            Tablo.RefreshDataSource();
            ButtonEnabledDurumu(true);
        }
        protected void ButtonEnabledDurumu(bool durum) 
        {
            TableValueChanged = durum;
            OwnerForm.ButtonEnableSituation();
        }
        protected internal virtual bool HataliGiris() { return false; }
        protected virtual void OpenEntity() { }
        protected virtual void SutunGizleGoster() { }
        protected virtual void RowCellAllowEdit() { }
        protected internal bool Kaydet()
        {
            insUptNavigator.Navigator.Buttons.DoClick(insUptNavigator.Navigator.Buttons.EndEdit);
            var source = Tablo.DataController.ListSource;

            var insert = source.Cast<IBaseHareketEntity>().Where(x => x.Insert && !x.Delete).Cast<BaseHareketEntity>().ToList();
            var update = source.Cast<IBaseHareketEntity>().Where(x => x.Update && !x.Delete).Cast<BaseHareketEntity>().ToList();
            var delete = source.Cast<IBaseHareketEntity>().Where(x => x.Delete && !x.Insert).Cast<BaseHareketEntity>().ToList();

            if (insert.Any())
                if (!((IBaseHareketGenelBll)Bll).Insert(insert))
                {
                    Messages.HataMesaji($"{Tablo.ViewCaption} Tablosundaki hareketler eklenemedi.");
                    return false;
                }
            if (update.Any())
                if (!((IBaseHareketGenelBll)Bll).Update(update))
                {
                    Messages.HataMesaji($"{Tablo.ViewCaption} Tablosundaki hareketler güncellenemedi.");
                    return false;
                }
            if (delete.Any())
                if (!((IBaseHareketGenelBll)Bll).Delete(delete))
                {
                    Messages.HataMesaji($"{Tablo.ViewCaption} Tablosundaki hareketler silinemedi.");
                    return false;
                }
            ButtonEnabledDurumu(false);
            return true;

        }
        private void Button_ItemClick(object sender, ItemClickEventArgs e) //burası sağ tıklayınca gelen popup menü
        {
            Cursor.Current = Cursors.WaitCursor;
            if (e.Item == btnHareketEkle)
                HareketEkle();
            else if (e.Item == btnHareketSil)
                HareketSil();
            else if (e.Item == btnKartDuzenle)
                OpenEntity();
            Cursor.Current = DefaultCursor;
        }
        protected virtual void ImageComboBox_SelectedValueChanged(object sender, EventArgs e){}
        protected virtual void CheckEdit_CheckedChanged(object sender, EventArgs e){} 
        private void Navigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button == insUptNavigator.Navigator.Buttons.Append)
                HareketEkle();
            else if (e.Button == insUptNavigator.Navigator.Buttons.Remove)
                HareketSil();

            if (e.Button == insUptNavigator.Navigator.Buttons.Append || e.Button == insUptNavigator.Navigator.Buttons.Remove)
                e.Handled = true;
        }
        protected virtual void Tablo_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if (!_isLoaded) return;

            var entity = Tablo.GetRow<IBaseHareketEntity>();
            if (!entity.Insert)
                entity.Update = true;

            ButtonEnabledDurumu(true);
        }
        protected virtual void Tablo_MouseUp(object sender, MouseEventArgs e)
        {
            if (sagMenu == null) return;
            if (e.Button != MouseButtons.Right) return;
            btnHareketSil.Enabled = Tablo.RowCount >0;
            btnKartDuzenle.Enabled = Tablo.RowCount > 0;
            btnIptalEt.Enabled = Tablo.RowCount > 0;
            btnIptalGeriAl.Enabled = Tablo.RowCount > 0;

            e.SagMenuGoster(sagMenu);
        }
        private void Tablo_GotFocus(object sender, EventArgs e)
        {
            OwnerForm.statusBarKisaYol.Visibility = BarItemVisibility.Always;
            OwnerForm.statusBarKisaYolAciklama.Visibility = BarItemVisibility.Always;

            OwnerForm.statusBarAciklama.Caption = ((IStatusBarKisaYol)sender).StatusBarAciklama;
            OwnerForm.statusBarKisaYol.Caption = ((IStatusBarKisaYol)sender).StatusBarKisaYol;
            OwnerForm.statusBarKisaYolAciklama.Caption = ((IStatusBarKisaYol)sender).StatusBarKisaYolAciklama;
        }
        private void Tablo_LostFocus(object sender, EventArgs e)
        {
            OwnerForm.statusBarKisaYol.Visibility = BarItemVisibility.Never;
            OwnerForm.statusBarKisaYolAciklama.Visibility = BarItemVisibility.Never;
        }
        private void Tablo_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    if (Tablo.IsEditorFocused)
                        insUptNavigator.Navigator.Buttons.DoClick(insUptNavigator.Navigator.Buttons.CancelEdit);
                    else
                        OwnerForm.Close();
                    break;
                case Keys.Tab:
                case Keys.Left:
                case Keys.Right:
                case Keys.Up:
                case Keys.Down:
                    insUptNavigator.Navigator.Buttons.DoClick(insUptNavigator.Navigator.Buttons.EndEdit);
                    break;
                case Keys.Insert when e.Shift:
                    HareketEkle();
                    break;
                case Keys.Delete when e.Modifiers == Keys.Shift://e.Shift:
                    HareketSil();
                    break;
                case Keys.F3:
                    OpenEntity();
                    break;
            }
        }
        protected virtual void Tablo_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            if (OwnerForm == null) return;
            OwnerForm.statusBarKisaYol.Visibility = BarItemVisibility.Never;
            OwnerForm.statusBarKisaYolAciklama.Visibility = BarItemVisibility.Never;

            if (!e.FocusedColumn.OptionsColumn.AllowEdit)
                Tablo_GotFocus(sender, null);

            else if(((IStatusBarKisaYol)e.FocusedColumn).StatusBarKisaYol!=null)
            {
                OwnerForm.statusBarKisaYol.Visibility = BarItemVisibility.Always;
                OwnerForm.statusBarKisaYolAciklama.Visibility = BarItemVisibility.Always;

                OwnerForm.statusBarAciklama.Caption = ((IStatusBarKisaYol)e.FocusedColumn).StatusBarAciklama;
                OwnerForm.statusBarKisaYol.Caption = ((IStatusBarKisaYol)e.FocusedColumn).StatusBarKisaYol;
                OwnerForm.statusBarKisaYolAciklama.Caption = ((IStatusBarKisaYol)e.FocusedColumn).StatusBarKisaYolAciklama;
            }
            else if (((IStatusBarKisaYol)e.FocusedColumn).StatusBarAciklama!=null)
                OwnerForm.statusBarAciklama.Caption = ((IStatusBarKisaYol)e.FocusedColumn).StatusBarAciklama;
        }
        private void Tablo_SablonChanged(object sender, EventArgs e)
        {
            _tabloSablonKayitEdilecek = true;
            SablonKaydet();
        }
        private void Tablo_DoubleClick(object sender, EventArgs e)
        {
            OpenEntity();
        }

        private void Tablo_FocusedRowObjectChanged(object sender, FocusedRowObjectChangedEventArgs e)
        {
            SutunGizleGoster();
            RowCellAllowEdit();
        }
    }
}