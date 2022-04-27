using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Common.Functions;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.OdemeTuruForms
{
    public partial class OdemeTuruEditForm : BaseEditForm
    {
        public OdemeTuruEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new OdemeTuruBll(myDataLayoutControl);
            txtOdemeTipi.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<OdemeTipi>());
            kartTuru = KartTuru.OdemeTuru;
            EventsLoad();
        }
        protected internal override void Yukle()
        {
            OldEntity=IslemTuru==IslemTuru.EntityInsert?new OdemeTuru():((OdemeTuruBll)Bll).Single(FilterFunctions.filter<OdemeTuru>(Id));
            NesneyiKontrollereBagla();

            if (IslemTuru != IslemTuru.EntityInsert) return;
            Id = IslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((OdemeTuruBll)Bll).CreateNewCode();
            txtOdemeTuruAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (OdemeTuru)OldEntity;

            txtKod.Text = entity.Kod;
            txtOdemeTuruAdi.Text = entity.OdemeTuruAdi;
            txtOdemeTipi.SelectedItem = entity.OdemeTipi.ToName();
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new OdemeTuru 
            {
                Id=Id,
                Kod=txtKod.Text,
                OdemeTuruAdi=txtOdemeTuruAdi.Text,
                OdemeTipi=txtOdemeTipi.Text.GetEnum<OdemeTipi>(),
                Aciklama=txtAciklama.Text,
                Durum=tglDurum.IsOn
            };
            ButtonEnableSituation();
        }
    }
}