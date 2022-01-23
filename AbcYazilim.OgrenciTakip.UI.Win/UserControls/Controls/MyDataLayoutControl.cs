using DevExpress.XtraDataLayout;
using DevExpress.XtraLayout;
using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraLayout.Utils;
using System.Windows.Forms;

namespace AbcYazilim.OgrenciTakip.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyDataLayoutControl:DataLayoutControl
    {
        public MyDataLayoutControl()
        {
            OptionsFocus.EnableAutoTabOrder = false; //kendi belirlediğimiz index değerine göre sıralama yapılacak.
        }
        protected override LayoutControlImplementor CreateILayoutControlImplementorCore()
        {
            return new MyLayoutControlImplementor(this);
        }
    }

    internal class MyLayoutControlImplementor : LayoutControlImplementor
    {
        public MyLayoutControlImplementor(ILayoutControlOwner controlOwner) : base(controlOwner)
        {

        }
        public override BaseLayoutItem CreateLayoutItem(LayoutGroup parent)
        {
            var item= base.CreateLayoutItem(parent);
            item.AppearanceItemCaption.ForeColor = Color.Maroon;
            return item;
        }
        public override LayoutGroup CreateLayoutGroup(LayoutGroup parent)
        {
            var group= base.CreateLayoutGroup(parent);
            group.LayoutMode = LayoutMode.Table;
            group.OptionsTableLayoutGroup.ColumnDefinitions[0].SizeType = SizeType.Absolute;
            group.OptionsTableLayoutGroup.ColumnDefinitions[0].Width = 200;
            group.OptionsTableLayoutGroup.ColumnDefinitions[1].SizeType = SizeType.Percent;
            group.OptionsTableLayoutGroup.ColumnDefinitions[1].Width =100;
            group.OptionsTableLayoutGroup.ColumnDefinitions.Add(new ColumnDefinition { SizeType = SizeType.Absolute, Width = 99 });

            group.OptionsTableLayoutGroup.RowDefinitions.Clear();
            for (int i = 0; i < 9; i++)
            {
                group.OptionsTableLayoutGroup.RowDefinitions.Add(new RowDefinition
                {
                    SizeType = SizeType.Absolute,
                    Height = 24
                });
                if (i + 1 != 9) continue;
                group.OptionsTableLayoutGroup.RowDefinitions.Add(new RowDefinition
                {
                    SizeType = SizeType.Percent,
                    Height = 100
                });
            }
            return group;
        }
    }
}
