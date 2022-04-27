using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using AbcYazilim.OgrenciTakip.Model.Entities.Base.Interfaces;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AbcYazilim.OgrenciTakip.UI.Win.Show
{
    public class ShowListForms<TForm> where TForm:BaseListForm
    {
        public static void ShowListForm(KartTuru kartTuru)
        {
            var frm = (TForm)Activator.CreateInstance(typeof(TForm));
            frm.MdiParent = Form.ActiveForm;
            frm.Yukle();
            frm.Show();

        }
        public static void ShowListForm(KartTuru kartTuru,params object[] prm)
        {
            var frm = (TForm)Activator.CreateInstance(typeof(TForm),prm);
            frm.MdiParent = Form.ActiveForm;
            frm.Yukle();
            frm.Show();
        }
        public static BaseEntity ShowDialogListForm(KartTuru kartTuru,long? seciliGelecekId,params object[] prm)
        {
            //Authorization
            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.SeciliGelecekId = seciliGelecekId;
                frm.Yukle();
                frm.ShowDialog();
                return frm.DialogResult == DialogResult.OK ? frm.SelectedEntity : null;
            }
        }
        public static IEnumerable<IBaseEntity> ShowDialogListForm(KartTuru kartTuru,IList<long> listeDisiTutulacakKayitlar,bool multiSelect,params object[] prm)
        {
            // yetki kontrolü
            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.ListeDisiTutulacakKayitlar = listeDisiTutulacakKayitlar;
                frm.MultiSelect = multiSelect;
                frm.Yukle();
                frm.RowSelect = new Functions.SelectRowFunctions(frm.Tablo);
                if (frm.EklenebilecekEntityVar)
                    frm.ShowDialog();
                return frm.DialogResult == DialogResult.OK ? frm.SelectedEntities : null;
            }
        }
    }
}
