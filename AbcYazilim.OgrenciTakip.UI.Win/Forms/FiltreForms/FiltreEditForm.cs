using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using DevExpress.XtraBars;
using DevExpress.XtraGrid;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.FiltreForms
{
    public partial class FiltreEditForm : BaseEditForm
    {
        #region Variables
        private readonly KartTuru _filtreKartTuru;
        private readonly GridControl _filtreGrid;
        #endregion
        public FiltreEditForm(params object[] prm)
        {
            InitializeComponent();

            _filtreKartTuru = (KartTuru)prm[0];
            _filtreGrid = (GridControl)prm[1];

            HideItems = new BarItem[] { btnYeni, btnGeriAl };
            ShowItems = new BarItem[] { btnFarkliKaydet, btnUygula };

            DataLayoutControl = myDataLayoutControl;
            Bll = new FiltreBll(myDataLayoutControl);
            kartTuru = KartTuru.Filtre;
            EventsLoad();
        }
        protected internal override void Yukle()
        {
            txtFiltreMetni.SourceControl = _filtreGrid;
            while (true)
            {
                if (IslemTuru == IslemTuru.EntityInsert)
                {
                    OldEntity = new Filtre();
                    Id = IslemTuru.IdOlustur(OldEntity);
                    txtKod.Text = ((FiltreBll)Bll).CreateNewCode(x => x.KartTuru == _filtreKartTuru);
                }
                else
                {
                    OldEntity = ((FiltreBll)Bll).Single(FilterFunctions.filter<Filtre>(Id));
                    if (OldEntity == null)
                    {
                        IslemTuru = IslemTuru.EntityInsert;
                        continue;
                    }                        
                    NesneyiKontrollereBagla();
                }
                break;
            }
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Filtre)OldEntity;

            txtKod.Text = entity.Kod;
            txtFiltreAdi.Text = entity.FiltreAdi;
            txtFiltreMetni.FilterString = entity.FiltreMetni;
        }
        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Filtre 
            {
                Id=Id,
                Kod=txtKod.Text,
                FiltreAdi=txtFiltreAdi.Text,
                FiltreMetni=txtFiltreMetni.FilterString,
                KartTuru=_filtreKartTuru
            };
            ButtonEnableSituation();
        }
        protected override bool EntityInsert()
        {
            return ((FiltreBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.KartTuru == _filtreKartTuru);
        }
        protected override bool EntityUpdate()
        {
            return ((FiltreBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.KartTuru == _filtreKartTuru);
        }
        protected override void FiltreUygula()
        {
            txtFiltreMetni.Select();
            txtFiltreMetni.ApplyFilter();
        }
        protected internal override void ButtonEnableSituation()
        {
            if (!IsLoaded) return;
            GeneralFunctions.ButtonEnabledSituation(btnKaydet,btnFarkliKaydet,btnSil,IslemTuru,OldEntity,CurrentEntity);
        }
    }
}