using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Common.Message;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using AbcYazilim.OgrenciTakip.UI.Win.GeneralForms;
using DevExpress.XtraBars;
using System;
using System.Collections;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.TahakkukForms
{
    public partial class TopluOdemePlaniEditForm : BaseEditForm
    {
        private OdemeTipi _odemeTipi;
        private readonly IList _source;
        private readonly long _tahakkukId;
        private readonly decimal _bakiye;
        private readonly DateTime _kayitTarihi;
        private readonly int _dahaOnceGirilenTaksitSayisi;
        private bool _maksimumTaksitSayisinaUlasildi;
        public TopluOdemePlaniEditForm(IList source,long tahakkukId,decimal bakiye,DateTime kayitTarihi,int dahaOnceGirilenTaksitSayisi,bool maksimumTaksitSayisinaUlasildi)
        {
            InitializeComponent();

            _source = source;
            _tahakkukId = tahakkukId;
            _bakiye = bakiye;
            _kayitTarihi = kayitTarihi;
            _dahaOnceGirilenTaksitSayisi = dahaOnceGirilenTaksitSayisi;
            _maksimumTaksitSayisinaUlasildi = maksimumTaksitSayisinaUlasildi;

            DataLayoutControl = myDataLayoutControl;
            EventsLoad();
            ShowItems = new BarItem[] { btnTaksitOlustur};
            HideItems = new BarItem[] {btnYeni,btnGeriAl,btnKaydet,btnFarkliKaydet,btnSil};
        }
        protected internal override void Yukle()
        {
            ControlEnableChange(OdemeTipi.Acik);
            txtIlkTaksitTarihi.DateTime = _kayitTarihi;
            txtIlkTaksitTarihi.Properties.MinValue = _kayitTarihi;
            txtIlkTaksitTarihi.Properties.MaxValue = AnaForm.MaksimumTaksitTarihi;
            txtSabitTaksit.Value = 0;
            txtBakiye.Value = _bakiye;
            txtTaksitSayisi.Properties.MinValue = 1;
            txtTaksitSayisi.Properties.MaxValue = AnaForm.MaksimumTaksitSayisi-_dahaOnceGirilenTaksitSayisi;
            if (AnaForm.MaksimumTaksitSayisi - _dahaOnceGirilenTaksitSayisi > 0) return;
            Messages.HataMesaji("Maksimum Taksit Sayısı Aşılıyor.");
            _maksimumTaksitSayisinaUlasildi = true;
        }
        private void ControlEnableChange(OdemeTipi odemeTipi)
        {
            txtBankaHesap.Enabled = odemeTipi == OdemeTipi.Epos || odemeTipi == OdemeTipi.Ots || odemeTipi == OdemeTipi.Pos;
            txtAsilBorclu.Enabled = odemeTipi == OdemeTipi.Cek || odemeTipi == OdemeTipi.Senet;
            txtCiranta.Enabled = odemeTipi == OdemeTipi.Cek || odemeTipi == OdemeTipi.Senet;
            txtBanka.Enabled = odemeTipi == OdemeTipi.Cek;
            txtBankaSube.Enabled = odemeTipi == OdemeTipi.Cek;
            txtHesapNo.Enabled = odemeTipi == OdemeTipi.Cek;
            txtIlkBelgeNo.Enabled = odemeTipi == OdemeTipi.Cek;
            txtBanka.ControlEnabledChange(txtBankaSube);
        }

        private bool HataliGiris()
        {
            if (txtIlkTaksitTarihi.DateTime.Date.AddMonths((int)txtTaksitSayisi.Value) > AnaForm.MaksimumTaksitTarihi)
            {
                Messages.HataMesaji("Maximum Taksit Tarihi Aşılıyor.");
                return true;
            }
            if (txtOdemeTuru.Id == null)
            {
                Messages.HataMesaji("Ödeme Türü Seçimi Yapmalısınız.");
                txtOdemeTuru.Focus();
                return true;

            }
            if ((_odemeTipi == OdemeTipi.Epos || _odemeTipi == OdemeTipi.Ots || _odemeTipi == OdemeTipi.Pos) && txtBankaHesap.Id == null)
            {
                Messages.SecimHataMesaji("Banka Hesap");
                txtBankaHesap.Focus();
                return true;
            }
            if (txtSabitTaksit.Value == 0 && txtBakiye.Value == 0 || txtSabitTaksit.Value > 0 && txtBakiye.Value > 0)
            {
                Messages.HataMesaji("Sabit Taksit Veya Bakiye Alanlarından Sadece Birinin Değeri Sıfıra Eşit Veya Sıfırdan Büyük Olmalıdır.");
                txtSabitTaksit.Focus();
                return true;
            }
            if ((_odemeTipi == OdemeTipi.Senet || _odemeTipi == OdemeTipi.Cek) && string.IsNullOrEmpty(txtAsilBorclu.Text))
            {
                Messages.HataliVeriMesaji("Asıl Borçlu");
                txtAsilBorclu.Focus();
                return true;
            }
            switch (_odemeTipi)
            {
                case OdemeTipi.Cek when txtBanka.Id==null:
                    Messages.SecimHataMesaji("Banka");
                    txtBanka.Focus();
                    return true;

                case OdemeTipi.Cek when txtBankaSube.Id == null:
                    Messages.SecimHataMesaji("Banka Şube");
                    txtBankaSube.Focus();
                    return true;
                case OdemeTipi.Cek when txtIlkBelgeNo.Value==0:
                    Messages.HataliVeriMesaji("İlk Belge No");
                    txtIlkBelgeNo.Focus();
                    return true;


            }
            return false;
        }
    }
}