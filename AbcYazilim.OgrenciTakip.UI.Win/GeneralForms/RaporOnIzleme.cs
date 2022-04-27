using DevExpress.XtraPrinting;

namespace AbcYazilim.OgrenciTakip.UI.Win.GeneralForms
{
    public partial class RaporOnIzleme : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public RaporOnIzleme(params object[] prm)
        {
            InitializeComponent();
            RaporGosterici.PrintingSystem = (PrintingSystem)prm[0];
            Text = $"{Text} ( {prm[1].ToString()} )";
        }
    }
}