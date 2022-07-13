using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Common.Message;
using AbcYazilim.OgrenciTakip.Model.Dto;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using AbcYazilim.OgrenciTakip.UI.Win.GeneralForms;
using AbcYazilim.OgrenciTakip.UI.Win.Show;
using DevExpress.XtraBars;
using System.Linq;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.MakbuzForms
{
    public partial class BelgeHareketleriListForm : BaseListForm
    {
        private readonly int _odemeBilgileriId;

        public BelgeHareketleriListForm(params object[] prm)
        {
            InitializeComponent();
            HideItems = new BarItem[] { btnYeni, btnSil, btnSec, barInsertAciklama, barInsert, barDelete, barDeleteAciklama, barEnter, barEnterAciklama };
            _odemeBilgileriId = (int)prm[0];
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            kartTuru = KartTuru.BelgeHareketleri;
            Navigator = longNavigator.Navigator;
            Navigator.TextStringFormat = "Belge Hareketleri ( {0} / {1})";

        }
        protected override void Listele()
        {
            using (var bll= new BelgeHareketleriBll())
            {
                var list = bll.List(x => x.OdemeBilgileriId == _odemeBilgileriId).Cast<BelgeHareketleriL>().ToList();
                if (!list.Any())
                {
                    Messages.UyariMesaji("Seçmiş Olduğunuz Ödeme Belgesine Ait Hareket Bulunmamaktadır.");
                    Close();
                    return;
                }
                var entity = list[0];

                txtNo.Text = entity.OgrenciNo;
                txtAdi.Text = entity.Adi;
                txtSoyadi.Text = entity.Soyadi;
                txtSinifAdi.Text = entity.SinifAdi;
                txtSubeAdi.Text = entity.OgrenciSubeAdi;
                txtPortfoyNo.EditValue = entity.OdemeBilgileriId;
                txtOdemeTuru.Text = entity.OdemeTuruAdi;
                txtGirisTarihi.EditValue = entity.GirisTarihi;
                txtVade.DateTime = entity.Vade;
                txtHesabaGecisTarihi.DateTime = entity.HesabaGecisTarihi;
                txtTutar.Value = entity.Tutar;
                txtAsilBorclu.Text = entity.AsilBorclu;
                txtCiranta.Text = entity.Ciranta;
                txtBankaAdi.Text = entity.BankaAdi;
                txtBankaSubeAdi.Text = entity.BankaSubeAdi;
                txtHesapNo.Text = entity.HesapNo;
                txtBelgeNo.Text = entity.BelgeNo;

                grid.DataSource = list;
            }
        }
        protected override void ShowEditForm(long id)
        {
            var entity = tablo.GetRow<BelgeHareketleriL>();
            if (entity == null) return;

            if (entity.SubeId != AnaForm.SubeId)
                ShowEditForms<MakbuzEditForm>.ShowDialogEditForm(KartTuru.Makbuz, id, entity.MakbuzTuru, entity.HesapTuru, true);
            else
            {
                var result = ShowEditForms<MakbuzEditForm>.ShowDialogEditForm(KartTuru.Makbuz, id, entity.MakbuzTuru, entity.HesapTuru);
                ShowEditFormDefault(result);
            }
        }
    }
}