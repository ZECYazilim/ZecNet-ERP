using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities.Base.Interfaces;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Show.Interfaces;
using System;
using System.Windows.Forms;

namespace AbcYazilim.OgrenciTakip.UI.Win.Show
{
    public class ShowEditForms<TForm>:IBaseFormShow where TForm:BaseEditForm //Interface gelecek
    {
        public long ShowDialogEditForm(KartTuru kartTuru,long id)//,params object[] prm)
        {
            //Yetki Kontrolü
            using (var frm=(TForm)Activator.CreateInstance(typeof(TForm)))
            {
                frm.IslemTuru = id > 0 ? IslemTuru.EntityUpdate : IslemTuru.EntityInsert; //inanılmazzz
                frm.Id = id;
                frm.Yukle();
                frm.ShowDialog();
                return frm.RefreshControl ? frm.Id : 0;
            }
        }
        public static long ShowDialogEditForm(KartTuru kartTuru, long id,params object[] prm)
        {
            //Yetki Kontrolü
            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm),prm))
            {
                frm.IslemTuru = id > 0 ? IslemTuru.EntityUpdate : IslemTuru.EntityInsert; //inanılmazzz
                frm.Id = id;
                frm.Yukle();
                frm.ShowDialog();
                return frm.RefreshControl ? frm.Id : 0;
            }
        }
        public static bool ShowDialogEditForm(params object[] prm)
        {
            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.Yukle();

                return frm.DialogResult==DialogResult.OK;
            }
        }
        public static T ShowDialogEditForm<T>(params object[] prm)where T:IBaseEntity
        {
            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.Yukle();
                frm.ShowDialog();
                return (T)frm.ReturnEntity();
            }

        }
    }
}
