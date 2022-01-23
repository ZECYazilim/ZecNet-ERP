using DevExpress.XtraEditors;
using DevExpress.Utils;
using System.Drawing;
using AbcYazilim.OgrenciTakip.UI.Win.Interfaces;
using System.ComponentModel;

namespace AbcYazilim.OgrenciTakip.UI.Win.UserControls.Controls
{
    public class MyToggleSwitch:ToggleSwitch,IStatusBarAciklama
    {
        [ToolboxItem(true)]
        public MyToggleSwitch()
        {
            Name = "tglDurum";
            Properties.OffText = "Pasif";
            Properties.OnText = "Aktif";
            Properties.AutoHeight = false; //standart 24px
            Properties.AutoWidth = true;
            Properties.GlyphAlignment = HorzAlignment.Far; //Toggle switch konumunu ayarlar
            Properties.Appearance.ForeColor = Color.Maroon;

        }
        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarAciklama { get; set; } = "Kartın Kullanım Durumunu Seçiniz.";
    }
}
