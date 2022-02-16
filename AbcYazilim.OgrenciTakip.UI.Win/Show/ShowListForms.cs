using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
