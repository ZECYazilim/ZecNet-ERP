using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Show;
using DevExpress.XtraBars;
using DevExpress.XtraGrid;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.FiltreForms
{
    public partial class FiltreListForm : BaseListForm
    {
        #region Variables
        private readonly KartTuru _filtreKartTuru;
        private readonly GridControl _filtreGrid; 
        #endregion
        public FiltreListForm(params object[] prm)
        {
            InitializeComponent();
            Bll = new FiltreBll();
            _filtreKartTuru = (KartTuru)prm[0];
            _filtreGrid = (GridControl)prm[1];

            HideItems = new BarItem[] {btnFiltrele,btnKolonlar,btnYazdir,btnGonder,barFiltrele,barFiltreleAciklama,barKolonlar,barKolonlarAciklama,barYazdir,barYazdirAciklama,barGonder,barGonderAciklama};
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            kartTuru = KartTuru.Filtre;
            Navigator = longNavigator1.Navigator;
        }
        protected override void Listele()
        {
                Tablo.GridControl.DataSource = ((FiltreBll)Bll).List(x=>x.KartTuru==_filtreKartTuru);
        }
        protected override void ShowEditForm(long id)
        {
            var result=ShowEditForms<FiltreEditForm>.ShowDialogEditForm(KartTuru.Filtre, id, _filtreKartTuru, _filtreGrid);
            ShowEditFormDefault(result);   
        }
    }
}