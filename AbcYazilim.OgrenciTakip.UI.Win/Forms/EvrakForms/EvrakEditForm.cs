using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using AbcYazilim.OgrenciTakip.UI.Win.GeneralForms;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.EvrakForms
{
    public partial class EvrakEditForm : BaseEditForm
    {
        public EvrakEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new EvrakBll(myDataLayoutControl);
            kartTuru = KartTuru.Evrak;
            EventsLoad();
        }
        protected internal override void Yukle()
        {
            OldEntity = IslemTuru == IslemTuru.EntityInsert ? new Evrak() : ((EvrakBll)Bll).Single(FilterFunctions.filter<Evrak>(Id));
            NesneyiKontrollereBagla();

            if (IslemTuru != IslemTuru.EntityInsert) return;
            Id = IslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((EvrakBll)Bll).CreateNewCode(x =>x.SubeId==AnaForm.SubeId&&x.DonemId==AnaForm.DonemId);
            txtEvrakAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Evrak)OldEntity;
            txtKod.Text = entity.Kod;
            txtEvrakAdi.Text = entity.EvrakAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Evrak
            {
                Id = Id,
                Kod = txtKod.Text,
                EvrakAdi = txtEvrakAdi.Text,
                Aciklama = txtAciklama.Text,
                SubeId = AnaForm.SubeId,
                DonemId = AnaForm.DonemId,
                Durum = tglDurum.IsOn
            };
            ButtonEnableSituation();
        }
        protected override bool EntityInsert()
        {
            return ((EvrakBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId==AnaForm.SubeId&&x.DonemId==AnaForm.DonemId);
        }
        protected override bool EntityUpdate()
        {
            return ((EvrakBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
        }
    }
}