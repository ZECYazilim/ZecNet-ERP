using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.IlceForms
{
    public partial class IlceEditForm : BaseEditForm
    {
        #region Variables
        private readonly long _ilId;
        private readonly string _ilAdi; 
        #endregion
        public IlceEditForm(){ }
        public IlceEditForm(params object[] prm)
        {
            InitializeComponent();
            _ilId = (long)prm[0];
            _ilAdi = prm[1].ToString();
            DataLayoutControl = DataLayoutControl1;
            Bll = new IlceBll(DataLayoutControl1);
            kartTuru = KartTuru.Ilce;
            EventsLoad();
        }
        protected internal override void Yukle()
        {
            OldEntity = IslemTuru == IslemTuru.EntityInsert ? new Ilce() : ((IlceBll)Bll).Single(FilterFunctions.filter<Ilce>(Id));
            NesneyiKontrollereBagla();
            Text = Text + $" - ( {_ilAdi} )";
            if (IslemTuru != IslemTuru.EntityInsert) return;
            txtKod.Text = ((IlceBll)Bll).CreateNewCode(x=>x.IlId==_ilId);
            txtIlceAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Ilce)OldEntity;
            txtKod.Text = entity.Kod;
            txtIlceAdi.Text = entity.IlceAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Ilce
            {
                Id = Id,
                Kod = txtKod.Text,
                IlceAdi = txtIlceAdi.Text,
                IlId=_ilId,
                Aciklama=txtAciklama.Text,
                Durum = tglDurum.IsOn
            };
        }
        protected override bool EntityInsert()
        {
            return ((IlceBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.IlId == _ilId);
        }
        protected override bool EntityUpdate()
        {
            return ((IlceBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.IlId == _ilId);
        }
    }
}