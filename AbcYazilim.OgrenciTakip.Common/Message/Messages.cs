using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace AbcYazilim.OgrenciTakip.Common.Message
{
    public class Messages
    {
        public static void HataMesaji(string hataMesaji)
        {
            XtraMessageBox.Show(hataMesaji, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static DialogResult EvetSeciliEvetHayir(string mesaj,string baslik)
            => XtraMessageBox.Show(mesaj, baslik, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

        public static DialogResult HayirSeciliEvetHayir(string mesaj, string baslik) 
            => XtraMessageBox.Show(mesaj, baslik, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

        public static DialogResult SilMesaj(string kartAdi)
            => HayirSeciliEvetHayir($"Seçtiğiniz {kartAdi} Silinecektir. Onaylıyor Musunuz?", "Silme Onayı");
    }
}
