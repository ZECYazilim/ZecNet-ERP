using DevExpress.XtraEditors;

using System.ComponentModel;
using System.Drawing;
using DevExpress.Utils;
using AbcYazilim.OgrenciTakip.UI.Win.Interfaces;

namespace AbcYazilim.OgrenciTakip.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MySpinEdit:SpinEdit,IStatusBarAciklama
    {
        public MySpinEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.AllowNullInput = DefaultBoolean.False;
            Properties.EditMask = "d"; //decimal türünde kaydetmesi için
        }
        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarAciklama { get; set; }
    }
}
