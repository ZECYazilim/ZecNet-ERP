using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Common.Functions;
using AbcYazilim.OgrenciTakip.Common.Message;
using AbcYazilim.OgrenciTakip.Model.Dto;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using AbcYazilim.OgrenciTakip.UI.Win.GeneralForms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;
using System;
using System.Linq;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.MakbuzForms
{
    public partial class MakbuzEditForm : BaseEditForm
    {
        #region Variables
        protected internal readonly MakbuzTuru MakbuzTuru;
        private readonly MakbuzHesapTuru _hesapTuru; 
        #endregion
        public MakbuzEditForm(params object[] prm)
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new MakbuzBll(myDataLayoutControl);
            kartTuru = KartTuru.Makbuz;
            EventsLoad();

            HideItems = new BarItem[] { btnYeni };
            ShowItems = new BarItem[] { btnYazdir };

            KayitSonrasiFormuKapat = false;

            MakbuzTuru = (MakbuzTuru)prm[0];
            _hesapTuru = (MakbuzHesapTuru)prm[1];
            FarkliSubeIslemi = prm.Length>2&&prm[2].GetType()==typeof(bool);
        }
        protected internal override void Yukle()
        {
            OldEntity = IslemTuru == IslemTuru.EntityInsert ? new MakbuzS() : ((MakbuzBll)Bll).Single(FilterFunctions.filter<Makbuz>(Id));
            AlanIslemleri();
            NesneyiKontrollereBagla();
            TabloYukle();
            MakbuzTuruEnabled();
            if (IslemTuru != IslemTuru.EntityInsert) return;
            Id = IslemTuru.IdOlustur(OldEntity);
            txtMakbuzNo.Text = ((MakbuzBll)Bll).CreateNewCode(x =>x.DonemId==AnaForm.DonemId&& x.SubeId == AnaForm.SubeId);
            txtTarih.DateTime = DateTime.Now.Date;
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (MakbuzS)OldEntity;
            txtMakbuzNo.Text = entity.Kod;
            txtTarih.DateTime = entity.Tarih;
            txtHesapTuru.SelectedItem = _hesapTuru.ToName();

            if (IslemTuru == IslemTuru.EntityInsert)
            {
                switch (_hesapTuru)
                {
                    case MakbuzHesapTuru.Kasa when AnaForm.DefaultCaseId != null:
                        txtHesap.Id = AnaForm.DefaultCaseId;
                        txtHesap.Text = AnaForm.DefaultCaseName;
                        break;
                    case MakbuzHesapTuru.Banka when AnaForm.DefaultBankId != null:
                        txtHesap.Id = AnaForm.DefaultBankId;
                        txtHesap.Text = AnaForm.DefaultBankName;
                        break;
                    case MakbuzHesapTuru.Avukat when AnaForm.DefaultLawyerId != null:
                        txtHesap.Id = AnaForm.DefaultLawyerId;
                        txtHesap.Text = AnaForm.DefaultLawyerName;
                        break;
                    case MakbuzHesapTuru.Transfer when MakbuzTuru==MakbuzTuru.GelenBelgeyiOnaylama:
                        txtHesap.Id = AnaForm.SubeId;
                        txtHesap.Text = AnaForm.SubeAdi;
                        break;
                }
            }
            else
            {
                txtHesap.Id = entity.AvukatHesapId ?? entity.BankaHesapId ?? entity.CariHesapId ?? entity.KasaHesapId ?? entity.SubeHesapId;
                txtHesap.Text = entity.HesapAdi;
            }
        }
        protected override void GuncelNesneOlustur()
        {
            var hesapTuru = txtHesapTuru.Text.GetEnum<MakbuzHesapTuru>();
            CurrentEntity = new Makbuz
            {
                Id = Id,
                Kod = txtMakbuzNo.Text,
                Tarih=txtTarih.DateTime.Date,
                MakbuzTuru=MakbuzTuru,
                HesapTuru=hesapTuru,
                AvukatHesapId=hesapTuru==MakbuzHesapTuru.Avukat?txtHesap.Id:null,
                BankaHesapId=hesapTuru==MakbuzHesapTuru.Banka||hesapTuru==MakbuzHesapTuru.Epos||hesapTuru==MakbuzHesapTuru.Ots||hesapTuru==MakbuzHesapTuru.Pos?txtHesap.Id:null,
                CariHesapId=hesapTuru==MakbuzHesapTuru.Cari||hesapTuru==MakbuzHesapTuru.Mahsup?txtHesap.Id:null,
                KasaHesapId=hesapTuru==MakbuzHesapTuru.Kasa?txtHesap.Id:null,
                SubeHesapId=hesapTuru==MakbuzHesapTuru.Transfer?txtHesap.Id:null,
                HareketSayisi=makbuzHareketleriTable.Tablo.DataRowCount,
                MakbuzToplami=decimal.Parse(makbuzHareketleriTable.colIslemTutari.SummaryText),
                DonemId=AnaForm.DonemId,
                SubeId = AnaForm.SubeId,          
            };
            ButtonEnableSituation();
        }
        protected internal override void ButtonEnableSituation()
        {
            if (!IsLoaded) return;

            if (FarkliSubeIslemi)
                GeneralFunctions.ButtonEnabledSituation(btnYeni, btnKaydet, btnGeriAl, btnSil);
            else
                GeneralFunctions.ButtonEnabledSituation(btnYeni, btnKaydet, btnGeriAl, btnSil, OldEntity, CurrentEntity,makbuzHareketleriTable.TableValueChanged);
        }
        protected override bool EntityInsert()
        {
            GuncelNesneOlustur();
            if (HataliGiris()) return false;

            if (makbuzHareketleriTable.HataliGiris()) return false;
            var result = ((MakbuzBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId) && makbuzHareketleriTable.Kaydet();

            if (result && !KayitSonrasiFormuKapat)
                makbuzHareketleriTable.Yukle();

            return result;
        }
        protected override bool EntityUpdate()
        {
            GuncelNesneOlustur();
            if (HataliGiris()) return false;

            if (makbuzHareketleriTable.HataliGiris()) return false;
            var result = ((MakbuzBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId) && makbuzHareketleriTable.Kaydet();

            if (result && !KayitSonrasiFormuKapat)
                makbuzHareketleriTable.Yukle();
            return result;
        }
        protected override void EntityDelete()
        {
            if (!makbuzHareketleriTable.TopluHareketSil()) return;
            if (!((MakbuzBll)Bll).Delete(OldEntity)) return; //??
            RefreshControl = true;
            Close();
        }
        protected internal bool HataliGiris()
        {
            if (!txtHesap.Visible || txtHesap.Id != null) return false;
            Messages.SecimHataMesaji("Hesap");
            txtHesap.Focus();
            return true;
        }
        private void AlanIslemleri()
        {
            Text = $"{Text} - {MakbuzTuru.ToName()}";
            txtTarih.Properties.MinValue = AnaForm.GunTarihininOncesineMakbuzTarihiGirilebilir ? AnaForm.DonemBaslamaTarihi : DateTime.Now.Date;
            txtTarih.Properties.MaxValue = AnaForm.GunTarihininSonrasinaMakbuzTarihiGirilebilir ? AnaForm.DonemBitisTarihi : DateTime.Now.Date;

            switch (MakbuzTuru)
            {
                case MakbuzTuru.BlokeyeAlma:
                case MakbuzTuru.BlokeCozumu:
                    txtHesapTuru.Properties.Items
                        .AddRange(Enum.GetValues(typeof(MakbuzHesapTuru))
                        .Cast<MakbuzHesapTuru>()
                        .Where(x => x == MakbuzHesapTuru.Epos || x == MakbuzHesapTuru.Ots || x == MakbuzHesapTuru.Pos)
                        .Select(x => x.ToName()).ToList());
                    break;
                case MakbuzTuru.PortfoyeGeriIade:
                case MakbuzTuru.PortfoyeKarsiliksizIade:
                    txtHesapTuru.Properties.Items
                        .AddRange(Enum.GetValues(typeof(MakbuzHesapTuru))
                        .Cast<MakbuzHesapTuru>()
                        .Where(x => x == MakbuzHesapTuru.Avukat || x == MakbuzHesapTuru.Banka || x == MakbuzHesapTuru.Cari)
                        .Select(x => x.ToName()).ToList());
                    break;
                case MakbuzTuru.OdenmisOlarakIsaretleme:
                case MakbuzTuru.KarsiliksizOlarakIsaretleme:
                case MakbuzTuru.MusteriyeGeriIade:
                case MakbuzTuru.TahsiliImkansizHaleGelme:
                    txtHesapTuru.Properties.Items.Add(_hesapTuru.ToName());
                    layoutHesapAdi.Visibility = LayoutVisibility.Never;
                    break;
                default:
                    txtHesapTuru.Properties.Items.Add(_hesapTuru.ToName());
                    break;
            }
        }
        protected internal void MakbuzTuruEnabled()
        {
            switch (MakbuzTuru)
            {
                case MakbuzTuru.BlokeyeAlma:
                case MakbuzTuru.BlokeCozumu:
                case MakbuzTuru.PortfoyeGeriIade:
                case MakbuzTuru.PortfoyeKarsiliksizIade:
                case MakbuzTuru.AvukataGonderme:
                case MakbuzTuru.AvukatYoluylaTahsilEtme:
                case MakbuzTuru.BankayaTahsileGonderme:
                case MakbuzTuru.BankaYoluylaTahsilEtme:
                case MakbuzTuru.BaskaSubeyeGonderme:
                case MakbuzTuru.CiroEtme:
                    txtHesap.Enabled = makbuzHareketleriTable.Tablo.DataRowCount == 0;
                    txtHesapTuru.Enabled = makbuzHareketleriTable.Tablo.DataRowCount == 0;
                    break;
                case MakbuzTuru.GelenBelgeyiOnaylama:
                    txtHesapTuru.Enabled = false;
                    txtHesap.Enabled = false;
                    break;
            }
        }
        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec =new SelectFunctions())
            {
                switch (txtHesapTuru.Text.GetEnum<MakbuzHesapTuru>())
                {
                    case MakbuzHesapTuru.Avukat:
                        sec.Sec(txtHesap, KartTuru.Avukat);
                        break;
                    case MakbuzHesapTuru.Banka:
                        sec.Sec(txtHesap, KartTuru.BankaHesap,BankaHesapTuru.VadesizMevduatHesabi);
                        break;
                    case MakbuzHesapTuru.Cari:
                    case MakbuzHesapTuru.Mahsup:
                        sec.Sec(txtHesap, KartTuru.Cari);
                        break;
                    case MakbuzHesapTuru.Epos:
                        sec.Sec(txtHesap, KartTuru.BankaHesap, BankaHesapTuru.EposBlokeHesabi);
                        break;
                    case MakbuzHesapTuru.Ots:
                        sec.Sec(txtHesap, KartTuru.BankaHesap, BankaHesapTuru.OtsBlokeHesabi);
                        break;
                    case MakbuzHesapTuru.Pos:
                        sec.Sec(txtHesap, KartTuru.BankaHesap, BankaHesapTuru.PosBlokeHesabi);
                        break;
                    case MakbuzHesapTuru.Kasa:
                        sec.Sec(txtHesap, KartTuru.Kasa);
                        break;
                    //case MakbuzHesapTuru.Transfer:
                    //    sec.Sec(txtHesap, KartTuru.Sube);
                    //    break;
                }
            }
        }
        protected override void TabloYukle()
        {
            makbuzHareketleriTable.OwnerForm = this;
            makbuzHareketleriTable.Yukle();
        }
        protected override void Control_SelectedValueChanged(object sender, EventArgs e)
        {
            if (sender != txtHesapTuru) return;
            txtHesap.Id = null;
            txtHesap.Text = null;
            txtHesap.Focus();
        }
        protected override void BaseEditForm_Shown(object sender, EventArgs e)
        {
            if (layoutHesapAdi.Visible && txtHesap.Id == null)
                txtHesap.Focus();
            else
                makbuzHareketleriTable.Tablo.GridControl.Focus();
        }
    }
}