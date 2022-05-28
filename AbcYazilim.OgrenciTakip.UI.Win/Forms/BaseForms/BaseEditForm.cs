using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using AbcYazilim.OgrenciTakip.Common.Enums;
using DevExpress.XtraBars;
using AbcYazilim.OgrenciTakip.UI.Win.UserControls.Controls;
using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using AbcYazilim.OgrenciTakip.Common.Message;
using AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid;
using AbcYazilim.OgrenciTakip.UI.Win.Interfaces;
using DevExpress.XtraPrinting;
using DevExpress.Utils.Extensions;
using AbcYazilim.OgrenciTakip.Model.Entities.Base.Interfaces;
using DevExpress.XtraBars.Navigation;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms
{
    public partial class BaseEditForm : RibbonForm
    {
        #region Variables
        private bool _formSablonKayitEdilecek;
        protected MyDataLayoutControl DataLayoutControl;
        protected MyDataLayoutControl[] DataLayoutControls;
        protected IBaseBll Bll;
        protected KartTuru kartTuru;
        protected BaseEntity OldEntity;
        protected BaseEntity CurrentEntity;
        protected bool IsLoaded;
        protected bool KayitSonrasiFormuKapat = true;
        protected BarItem[] ShowItems;
        protected BarItem[] HideItems;
        protected internal IslemTuru IslemTuru;
        protected internal long Id;
        protected internal bool RefreshControl;
        protected bool FarkliSubeIslemi;
        #endregion

        public BaseEditForm()
        {
            InitializeComponent();
        }
        protected void EventsLoad()
        {
            //Button events
            foreach (BarItem item in ribbonControl.Items)
                item.ItemClick += Item_ItemClick;

            //Form Events
            LocationChanged += BaseEditForm_LocationChanged;
            SizeChanged += BaseEditForm_SizeChanged;
            Load += BaseEditForm_Load;
            FormClosing += BaseEditForm_FormClosing;
            void ControlEvents(Control control)
            {
                control.KeyDown += Control_KeyDown;
                control.GotFocus += Control_GotFocus;
                control.Leave += Control_Leave;
                control.Enter += Control_Enter;
                switch (control)
                {
                    case FilterControl edt:
                        edt.FilterChanged += Control_EditValueChanged;
                        break;
                    case ComboBoxEdit edt:
                        edt.SelectedValueChanged += Control_SelectedValueChanged;
                        edt.EditValueChanged += Control_EditValueChanged;
                        break;
                    case MyButtonEdit edt:
                        edt.IdChanged += Control_IdChanged;
                        edt.EnabledChange += Control_EnabledChange;
                        edt.ButtonClick += Control_ButtonClick;
                        edt.DoubleClick += Control_DoubleClick;
                        break;
                    case BaseEdit edt:
                        edt.EditValueChanged += Control_EditValueChanged;
                        break;
                    case TabPane tab:
                        tab.SelectedPageChanged += Control_SelectedPageChanged;
                        break;
                }
            }
            if (DataLayoutControls == null)
            {
                if (DataLayoutControl == null) return;
                foreach (Control ctrl in DataLayoutControl.Controls)
                    ControlEvents(ctrl);

            }
            else
                foreach (var layout in DataLayoutControls)
                    foreach (Control ctrl in layout.Controls)
                        ControlEvents(ctrl);
        }
        private void EntityDelete()
        {
            if (!((IBaseCommonBll)Bll).Delete(OldEntity)) return;
            RefreshControl = true;
            Close();
        }
        private void ButonGizleGoster()
        {
            ShowItems?.ForEach(x => x.Visibility = BarItemVisibility.Always);
            HideItems?.ForEach(x => x.Visibility = BarItemVisibility.Never);
        }
        private void GeriAl()
        {
            if (Messages.HayirSeciliEvetHayir("Yapılan Değişiklikler Geri Alınacaktır. Onaylıyor musunuz?", "Geri Al Onay") != DialogResult.Yes) return;
            if (IslemTuru == IslemTuru.EntityUpdate)
                Yukle();
            else
                Close();
        }
        private void SablonYukle()
        {
            Name.FormSablonYukle(this);
        }
        private void FarkliKaydet()
        {
            if (Messages.EvetSeciliEvetHayir("Bu Filtre Referans Alınarak Yeni Bir Filtre Oluşturulacaktır. Onaylıyor Musunuz?", "Kayıt Onayı") != DialogResult.Yes) return;

            IslemTuru = IslemTuru.EntityInsert;
            Yukle();
            if (Kaydet(true))
                Close();
        }
        private void Edt_EditValueChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private bool Kaydet(bool closingE)
        {
            bool KayitIslemi()
            {
                Cursor.Current = Cursors.WaitCursor;
                switch (IslemTuru)
                {
                    case IslemTuru.EntityInsert:
                        if (EntityInsert())
                            return KayitSonrasiIslemler();
                        break;
                    case IslemTuru.EntityUpdate:
                        if (EntityUpdate())
                            return KayitSonrasiIslemler();
                        break;
                }
                bool KayitSonrasiIslemler()
                {
                    OldEntity = CurrentEntity;
                    RefreshControl = true;
                    ButtonEnableSituation();
                    if (KayitSonrasiFormuKapat)
                        Close();
                    else
                        IslemTuru = IslemTuru == IslemTuru.EntityInsert ? IslemTuru.EntityUpdate : IslemTuru;
                    return true;
                }
                return false;
            }
            var result = closingE ? Messages.KapanisMesaj() : Messages.KayitMesaj();
            switch (result)
            {
                case DialogResult.Yes:
                    return KayitIslemi();

                case DialogResult.No:
                    if (closingE)
                        btnKaydet.Enabled = false;
                    return true;
                case DialogResult.Cancel:
                    return false;
            }
            return false;
        }
        protected void SablonKaydet()
        {
            if (_formSablonKayitEdilecek)
                Name.FormSablonKaydet(Left, Top, Width, Height, WindowState);
        }
        protected virtual void FiltreUygula() { }
        protected virtual void TaksitOlustur(){ }
        protected virtual void BaskiOnizleme() { }
        protected virtual void Yazdir() { }     
        protected virtual void SecimYap(object sender) { }              
        protected virtual bool EntityUpdate()
        {
            return ((IBaseGenelBll)Bll).Update(oldEntity: OldEntity, currentEntity: CurrentEntity);
        }
        protected virtual bool EntityInsert()
        {
            return ((IBaseGenelBll)Bll).Insert(CurrentEntity);
        }
        protected virtual void NesneyiKontrollereBagla() { }
        protected virtual void GuncelNesneOlustur() { }
        protected virtual void TabloYukle() { }
        protected internal virtual void Yukle() { }
        protected internal virtual IBaseEntity ReturnEntity() { return null; }

        protected internal virtual void ButtonEnableSituation()
        {
            if (!IsLoaded) return;
            GeneralFunctions.ButtonEnabledSituation(btnYeni, btnKaydet, btnGeriAl, btnSil, OldEntity, CurrentEntity);
        }
        

        protected virtual void Control_SelectedValueChanged(object sender, EventArgs e){ }

        private void Control_Leave(object sender, EventArgs e)
        {
            statusBarKisaYol.Visibility = BarItemVisibility.Never;
            statusBarKisaYolAciklama.Visibility = BarItemVisibility.Never;
        }

        private void Control_GotFocus(object sender, EventArgs e)
        {
            var type = sender.GetType();

            if (type == typeof(MyButtonEdit) || type == typeof(MyGridView) || type == typeof(MyPictureEdit) || type == typeof(MyComboBoxEdit) || type == typeof(MyDateEdit) || type == typeof(MyCalcEdit))
            {
                statusBarKisaYol.Visibility = BarItemVisibility.Always;
                statusBarKisaYolAciklama.Visibility = BarItemVisibility.Always;

                statusBarAciklama.Caption = ((IStatusBarKisaYol)sender).StatusBarAciklama;
                statusBarKisaYol.Caption = ((IStatusBarKisaYol)sender).StatusBarKisaYol;
                statusBarKisaYolAciklama.Caption = ((IStatusBarKisaYol)sender).StatusBarKisaYolAciklama;
            }
            else if (sender is IStatusBarAciklama controller)
                statusBarAciklama.Caption = controller.StatusBarAciklama;
        }

        private void BaseEditForm_SizeChanged(object sender, EventArgs e)
        {
            _formSablonKayitEdilecek = true;
        }

        private void BaseEditForm_LocationChanged(object sender, EventArgs e)
        {
            _formSablonKayitEdilecek = true;
        }

        private void BaseEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SablonKaydet();

            if (btnKaydet.Visibility == BarItemVisibility.Never || !btnKaydet.Enabled) return;
            if (!Kaydet(true))
                e.Cancel = true;
        }
       
        protected virtual void Control_EnabledChange(object sender, EventArgs e)
        { }

        protected virtual void Control_EditValueChanged(object sender, EventArgs e)
        {
            if (!IsLoaded) return;
            GuncelNesneOlustur();
        }

        private void Control_DoubleClick(object sender, EventArgs e)
        {
            SecimYap(sender);
        }

        private void Control_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SecimYap(sender);
        }

        private void Control_IdChanged(object sender, IdChangedEventArgs e)
        {
            if (!IsLoaded) return;
            GuncelNesneOlustur();
        }

        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();

            if (sender is MyButtonEdit edt)
                switch (e.KeyCode)
                {
                    case Keys.Delete when e.Control && e.Shift:
                        edt.Id = null;
                        edt.EditValue = null;
                        break;
                    case Keys.F4:
                    case Keys.Down when e.Modifiers == Keys.Alt:
                        SecimYap(edt);
                        break;
                }
        }
        protected virtual void Control_Enter(object sender, EventArgs e){}

        private void BaseEditForm_Load(object sender, EventArgs e)
        {
            IsLoaded = true;
            GuncelNesneOlustur();
            SablonYukle();
            ButonGizleGoster();
            if (FarkliSubeIslemi)
                Messages.UyariMesaji("İşlem Yapılan Kart Çalışılan Şube Veya Dönemde Olmadığı İçin Yapılan Değişiklikler Kayıt Edilemez.");
        }

        private void Item_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (e.Item == btnYeni)
            {
                //yetki kontrolü
                IslemTuru = IslemTuru.EntityInsert;
                Yukle();
            }

            else if (e.Item == btnKaydet)
                Kaydet(false);

            else if (e.Item == btnFarkliKaydet)
            {
                //Yetki Kontrolü
                FarkliKaydet();
            }

            else if (e.Item == btnGeriAl)
                GeriAl();

            else if (e.Item == btnSil)
            {
                //Yetki kontrolü
                EntityDelete();
            }
            else if (e.Item == btnUygula)
                FiltreUygula();
            else if (e.Item == btnTaksitOlustur)
                TaksitOlustur();

            else if (e.Item == btnYazdir)
                Yazdir();

            else if (e.Item == btnBaskiOnizleme)
                BaskiOnizleme();

            else if (e.Item == btnCikis)
                Close();
            Cursor.Current = DefaultCursor;
        }
        protected virtual void BagliTabloYukle() { }
        protected virtual bool BagliTabloKaydet() { return false; }
        protected virtual bool BagliTabloHataliGirisKontrol() { return false; }
        protected virtual void Control_SelectedPageChanged(object sender, SelectedPageChangedEventArgs e){ }
    }
}