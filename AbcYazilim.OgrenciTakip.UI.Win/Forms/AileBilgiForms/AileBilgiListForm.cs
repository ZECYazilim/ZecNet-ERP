using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Common.Message;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Show;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.AileBilgiForms
{
    public partial class AileBilgiListForm : BaseListForm
    {
        #region Variables
        private readonly Expression<Func<AileBilgi, bool>> _filter;
        #endregion
        public AileBilgiListForm()
        {
            InitializeComponent();
            Bll = new AileBilgiBll();
            _filter = x => x.Durum == AktifKartlariGoster;
        }
        public AileBilgiListForm(params object[] prm):this()
        {
            _filter = x => !ListeDisiTutulacakKayitlar.Contains(x.Id)&&x.Durum==AktifKartlariGoster;
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            kartTuru = KartTuru.AileBilgi;
            FormShow = new ShowEditForms<AileBilgiEditForm>();
            Navigator = longNavigator.Navigator;

        }
        protected override void Listele()
        {
            var list = ((AileBilgiBll)Bll).List(_filter);
            Tablo.GridControl.DataSource = list;

            if (!MultiSelect) return;
            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartBulunamadiMesaj("Kart");
        }
    }
}