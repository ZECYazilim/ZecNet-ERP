using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Common.Functions;
using AbcYazilim.OgrenciTakip.Model.Dto;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.Model.Entities.Base.Interfaces;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using AbcYazilim.OgrenciTakip.UI.Win.GeneralForms;
using AbcYazilim.OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using AbcYazilim.OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using System;
using System.Linq;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.TahakkukForms
{
    public partial class TahakkukEditForm : BaseEditForm
    {
        private readonly Ogrenci _ogrenci;
        private BaseTablo _kardesBilgileriTable;
        private BaseTablo _aileBilgileriTable;
        public TahakkukEditForm()
        {
            InitializeComponent();
            DataLayoutControls = new[] { DataLayoutGenel, DataLayoutGenelBilgiler } ;
            Bll = new TahakkukBll(DataLayoutGenelBilgiler);
            kartTuru = KartTuru.Tahakkuk;
            EventsLoad();

            HideItems = new BarItem[] { btnYeni };
            ShowItems = new BarItem[] { btnYazdir };
            txtKayitSekli.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<KayitSekli>());
            txtKayitDurumu.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<KayitDurumu>());
            txtSonrakiDonemKayitDurumu.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<SonrakiDonemKayitDurumu>());
           
            txtKayitTarihi.Properties.MinValue = AnaForm.DonemBaslamaTarihi;
            txtKayitTarihi.Properties.MaxValue = AnaForm.DonemBitisTarihi;

            btnYazdir.Caption = "Kayıt Evrakları";
        }
        public TahakkukEditForm(params object[] prm):this()
        {
            if (prm[0] is Ogrenci)
                _ogrenci = (Ogrenci)prm[0];
            else if (prm[0] is bool)
                FarkliSubeIslemi = (bool)prm[0];

        }
        protected internal override void Yukle()
        {
            OldEntity = IslemTuru == IslemTuru.EntityInsert ? new TahakkukS() : ((TahakkukBll)Bll).Single(FilterFunctions.filter<Tahakkuk>(Id));
            NesneyiKontrollereBagla();
            BagliTabloYukle();
            if (IslemTuru != IslemTuru.EntityInsert) return;
            Id = IslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((TahakkukBll)Bll).CreateNewCode(x => x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
        }
        protected override void BagliTabloYukle()
        {
            bool TableValueChanged(BaseTablo tablo)
            {
                return tablo.Tablo.DataController.ListSource.Cast<IBaseHareketEntity>().Any(x => x.Insert || x.Update || x.Delete);
            }

            if (_kardesBilgileriTable != null)
                _kardesBilgileriTable.Yukle();
            else if (_aileBilgileriTable != null)
                _aileBilgileriTable.Yukle();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (TahakkukS)OldEntity;
            txtTcKimlikNo.Text = IslemTuru==IslemTuru.EntityInsert?_ogrenci.TcKimlikNo:entity.TcKimlikNo;
            txtAdi.Text = IslemTuru == IslemTuru.EntityInsert ? _ogrenci.Adi : entity.Adi;
            txtSoyadi.Text = IslemTuru == IslemTuru.EntityInsert ? _ogrenci.Soyadi : entity.Soyadi;
            txtBabaAdi.Text = IslemTuru == IslemTuru.EntityInsert ? _ogrenci.BabaAdi : entity.BabaAdi;
            txtAnaAdi.Text = IslemTuru == IslemTuru.EntityInsert ? _ogrenci.AnaAdi : entity.AnaAdi;
            txtDurum.Text = entity.Durum ? IptalDurumu.DevamEdiyor.ToName() : IptalDurumu.IptalEdildi.ToName();
            txtKod.Text = entity.Kod;
            txtOkulNo.Text = entity.OkulNo;
            txtKayitTarihi.DateTime = entity.KayitTarihi;
            txtKayitSekli.SelectedItem = entity.KayitSekli.ToName();
            txtKayitDurumu.SelectedItem = entity.KayitDurumu.ToName();
            txtSinif.Id = entity.SinifId;
            txtSinif.Text = entity.SinifAdi;
            txtYabanciDil.Id = entity.YabanciDilId;
            txtYabanciDil.Text = entity.YabanciDilAdi;
            txtGeldigiOkul.Id = entity.GeldigiOkulId;
            txtGeldigiOkul.Text = entity.GeldigiOkulAdi;
            txtKontenjan.Id = entity.KontenjanId;
            txtKontenjan.Text = entity.KontenjanAdi;
            txtTesvik.Id = entity.TesvikId;
            txtTesvik.Text = entity.TesvikAdi;
            txtRehber.Id = entity.RehberId;
            txtRehber.Text = entity.RehberAdi;
            txtSonrakiDonemKayitDurumu.SelectedItem = entity.SonrakiDonemKayitDurumu.ToName();
            txtSonrakiDonemKayitDurumuAciklama.Text = entity.SonrakiDonemKayitDurumuAciklama;
            txtOzelKod1.Id = entity.OzelKod1Id;
            txtOzelKod1.Text = entity.OzelKod1Adi;
            txtOzelKod2.Id = entity.OzelKod2Id;
            txtOzelKod2.Text = entity.OzelKod2Adi;
            txtOzelKod3.Id = entity.OzelKod3Id;
            txtOzelKod3.Text = entity.OzelKod3Adi;
            txtOzelKod4.Id = entity.OzelKod4Id;
            txtOzelKod4.Text = entity.OzelKod4Adi;
            txtOzelKod5.Id = entity.OzelKod5Id;
            txtOzelKod5.Text = entity.OzelKod5Adi;
        }
        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Tahakkuk
            {
                Id = Id,
                Kod = txtKod.Text,
                OgrenciId = IslemTuru == IslemTuru.EntityInsert ? _ogrenci.Id : ((TahakkukS)OldEntity).OgrenciId,
                OkulNo = txtOkulNo.Text,
                KayitTarihi = txtKayitTarihi.DateTime.Date,
                KayitSekli = txtKayitSekli.Text.GetEnum<KayitSekli>(),
                KayitDurumu = txtKayitDurumu.Text.GetEnum<KayitDurumu>(),
                SinifId = Convert.ToInt64(txtSinif.Id),
                YabanciDilId = txtYabanciDil.Id,
                GeldigiOkulId = txtGeldigiOkul.Id,
                KontenjanId = txtKontenjan.Id,
                TesvikId = txtTesvik.Id,
                RehberId = txtRehber.Id,
                SonrakiDonemKayitDurumu = txtSonrakiDonemKayitDurumu.Text.GetEnum<SonrakiDonemKayitDurumu>(),
                SonrakiDonemKayitDurumuAciklama = txtSonrakiDonemKayitDurumuAciklama.Text,
                OzelKod1Id = txtOzelKod1.Id,
                OzelKod2Id = txtOzelKod2.Id,
                OzelKod3Id = txtOzelKod3.Id,
                OzelKod4Id = txtOzelKod4.Id,
                OzelKod5Id = txtOzelKod5.Id,
                Durum = txtDurum.Text.GetEnum<IptalDurumu>()==IptalDurumu.DevamEdiyor,
                DonemId = AnaForm.DonemId,
                SubeId = AnaForm.SubeId,
            };
            ButtonEnableSituation();
        }
        protected override bool EntityInsert()
        {
            var result= ((TahakkukBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId)&&BagliTabloKaydet();

            if (result)
                BagliTabloYukle();

            return result;
        }
        protected override bool EntityUpdate()
        {
            var result = ((TahakkukBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId) && BagliTabloKaydet();

            if (result)
                BagliTabloYukle();
            return result;
        }
        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;
            using (var sec = new SelectFunctions())
                if (sender == txtSinif)
                    sec.Sec(txtSinif);
                else if (sender == txtYabanciDil)
                    sec.Sec(txtYabanciDil);
                else if (sender == txtGeldigiOkul)
                    sec.Sec(txtGeldigiOkul);
                else if (sender == txtKontenjan)
                    sec.Sec(txtKontenjan);
                else if (sender == txtTesvik)
                    sec.Sec(txtTesvik);
                else if (sender == txtRehber)
                    sec.Sec(txtRehber);
                else if (sender == txtOzelKod1)
                    sec.Sec(txtOzelKod1, KartTuru.Tahakkuk);
                else if (sender == txtOzelKod2)
                    sec.Sec(txtOzelKod2, KartTuru.Tahakkuk);
                else if (sender == txtOzelKod3)
                    sec.Sec(txtOzelKod3, KartTuru.Tahakkuk);
                else if (sender == txtOzelKod4)
                    sec.Sec(txtOzelKod4, KartTuru.Tahakkuk);
                else if (sender == txtOzelKod5)
                    sec.Sec(txtOzelKod5, KartTuru.Tahakkuk);
        }
        protected internal override void ButtonEnableSituation()
        {
            if (!IsLoaded) return;

            bool TableValueChanged()
            {
                if (_kardesBilgileriTable != null && _kardesBilgileriTable.TableValueChanged) return true;
                if (_aileBilgileriTable != null && _aileBilgileriTable.TableValueChanged) return true;
                return false;
            }

            if (FarkliSubeIslemi)
                GeneralFunctions.ButtonEnabledSituation(btnYeni, btnKaydet, btnGeriAl, btnSil);
            else
                GeneralFunctions.ButtonEnabledSituation(btnYeni, btnKaydet, btnGeriAl, btnSil,OldEntity,CurrentEntity,TableValueChanged());
        }
        protected override bool BagliTabloKaydet()
        {
            if (_kardesBilgileriTable != null && !_kardesBilgileriTable.Kaydet()) return false;
            if (_aileBilgileriTable != null && !_aileBilgileriTable.Kaydet()) return false;
            
            return true;
        }
        protected override void Control_SelectedPageChanged(object sender, SelectedPageChangedEventArgs e)
        {
            if(e.Page==pageGenelBilgiler)
            {
                txtOkulNo.Focus();
                txtOkulNo.SelectAll();
            }
            else if (e.Page == pageKardesBilgiler)
            {
                if (pageKardesBilgiler.Controls.Count == 0)
                {
                    _kardesBilgileriTable = new KardesBilgileriTable().AddTable(this);
                    pageKardesBilgiler.Controls.Add(_kardesBilgileriTable);
                    _kardesBilgileriTable.Yukle();
                }
                _kardesBilgileriTable.Tablo.GridControl.Focus();
            }
            else if (e.Page == pageAileSinavBilgileri)
            {
                if (layoutControlAileSinavBilgileri.Items.Count == 0)
                {
                    _aileBilgileriTable = new AileBilgileriTable().AddTable(this);
                    layoutControlAileSinavBilgileri.LayoutControlInsert(_aileBilgileriTable, 0, 0, 0, 0);
                    _aileBilgileriTable.Yukle();
                }
                _aileBilgileriTable.Tablo.GridControl.Focus();
            }
        }
    }
}