using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Common.Functions;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.HizmetTuruForms
{
    public partial class HizmetTuruEditForm : BaseEditForm
    {
        public HizmetTuruEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new HizmetTuruBll(myDataLayoutControl);
            txtHizmetTipi.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<HizmetTipi>());
            kartTuru = KartTuru.HizmetTuru;
            EventsLoad();
        }
        protected internal override void Yukle()
        {
            OldEntity = IslemTuru == IslemTuru.EntityInsert ? new HizmetTuru() : ((HizmetTuruBll)Bll).Single(FilterFunctions.filter<HizmetTuru>(Id));
            NesneyiKontrollereBagla();
            if (IslemTuru != IslemTuru.EntityInsert) return;
            Id = IslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((HizmetTuruBll)Bll).CreateNewCode();
            txtHizmetTuruAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (HizmetTuru)OldEntity;
            txtKod.Text = entity.Kod;
            txtHizmetTuruAdi.Text = entity.HizmetTuruAdi;
            txtHizmetTipi.SelectedItem = entity.HizmetTipi.ToName();
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new HizmetTuru
            {
                Id = Id,
                Kod = txtKod.Text,
                HizmetTuruAdi = txtHizmetTuruAdi.Text,
                HizmetTipi=txtHizmetTipi.Text.GetEnum<HizmetTipi>(),
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };
            ButtonEnableSituation();
        }
    }
}