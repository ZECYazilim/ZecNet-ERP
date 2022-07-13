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
        public static void UyariMesaji(string uyariMesaji)
        {
            XtraMessageBox.Show(uyariMesaji, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static DialogResult EvetSeciliEvetHayir(string mesaj,string baslik)
            => XtraMessageBox.Show(mesaj, baslik, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

        public static DialogResult HayirSeciliEvetHayir(string mesaj, string baslik) 
            => XtraMessageBox.Show(mesaj, baslik, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

        public static DialogResult EvetSeciliEvetHayirIptal(string mesaj, string baslik)
            => XtraMessageBox.Show(mesaj, baslik, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        public static DialogResult SilMesaj(string kartAdi)
            => HayirSeciliEvetHayir($"Seçtiğiniz {kartAdi} Silinecektir. Onaylıyor Musunuz?", "Silme Onayı");

        public static DialogResult KapanisMesaj()
        {
            return EvetSeciliEvetHayirIptal("Yapılan Değişiklikler Kayıt Edilsin Mi?", "Çıkış Onay");
        }
        public static DialogResult KayitMesaj()
        {
            return EvetSeciliEvetHayir("Yapılan Değişiklikler Kayıt Edilsin Mi?", "Kayıt Onayı");
        }

        public static void KartSecmemeUyariMesaji()
        {
            UyariMesaji("Lütfen Bir Kart Seçiniz.");
        }
        public static void MukerrerKayitHataMesaji(string fieldName)
        {
            HataMesaji($"Girmiş Olduğunuz {fieldName} Daha Önce Kullanılmıştır.");
        }
        public static void HataliVeriMesaji(string fieldName)
        {
            HataMesaji($"{fieldName} Alanına Geçerli Bir Değer Girmelisiniz.");
        }
        public static DialogResult TabloExportMessage(string dosyaFormati)
        {
            return EvetSeciliEvetHayir($"İlgili Tablo, {dosyaFormati} olarak dışarı aktarılacaktır. Onaylıyor Musunuz? ", "Export Validation");
        }
        public static void KartBulunamadiMesaj(string kartTuru)
        {
            UyariMesaji($"İşlem Yapılabilecek {kartTuru} Bulunamadı.");
        }
        public static void TabloEksikBilgiMesaj(string tabloAdi)
        {
            UyariMesaji($"{tabloAdi}nda Eksik Bilgi Girişi Var. Lütfen Kontrol Ediniz.");
        }
        public static void IptalHareketSilinemezMesaji()
        {
            HataMesaji("İptal Edilen Hareketler Silinemez.");
        }
        public static DialogResult IptalMesaj(string kartAdi)
        {
             return HayirSeciliEvetHayir($"Seçtiğiniz {kartAdi} İptal Edilecektir. Onaylıyor Musunuz?", "İptal Onayı");
        }
        public static DialogResult IptalGeriAlMesaj(string kartAdi)
        {
            return HayirSeciliEvetHayir($"Seçtiğiniz {kartAdi} Kartına Uygulanan İptal İşlemi Geri Alınacaktır. Onaylıyor Musunuz?", "İptal Gerial Onayı");
        }
        public static void SecimHataMesaji(string alanAdi)
        {
            HataMesaji($"{alanAdi} Seçimi Yapmalısınız");
        }
        public static void OdemeBelgesiSilinemezMesaj(bool checkControl)
        {
            UyariMesaji(checkControl
                ?"Ödeme Belgesinin Daha Sonra İşlem Görmüş Hareketleri Var.Ödeme Belgesi Silinemez."
                : "Ödeme Belgesinin İşlem Görmüş Hareketleri Var.Ödeme Belgesi Silinemez.");
        }
    }
}
