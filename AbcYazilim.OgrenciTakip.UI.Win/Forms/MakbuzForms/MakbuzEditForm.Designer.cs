
namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.MakbuzForms
{
    partial class MakbuzEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition3 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition4 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
            this.myDataLayoutControl = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Controls.MyDataLayoutControl();
            this.txtHesap = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Controls.MyButtonEdit();
            this.txtHesapTuru = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Controls.MyComboBoxEdit();
            this.txtTarih = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Controls.MyDateEdit();
            this.txtMakbuzNo = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Controls.MyTextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutHesapAdi = new DevExpress.XtraLayout.LayoutControlItem();
            this.makbuzHareketleriTable = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.GenelEditFormTable.MakbuzHareketleriTable();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimPopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).BeginInit();
            this.myDataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapTuru.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMakbuzNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutHesapAdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            // 
            // 
            // 
            this.ribbonControl.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.ribbonControl.SearchEditItem.EditWidth = 150;
            this.ribbonControl.SearchEditItem.Id = -5000;
            this.ribbonControl.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl.Size = new System.Drawing.Size(998, 109);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // myDataLayoutControl
            // 
            this.myDataLayoutControl.Controls.Add(this.makbuzHareketleriTable);
            this.myDataLayoutControl.Controls.Add(this.txtHesap);
            this.myDataLayoutControl.Controls.Add(this.txtHesapTuru);
            this.myDataLayoutControl.Controls.Add(this.txtTarih);
            this.myDataLayoutControl.Controls.Add(this.txtMakbuzNo);
            this.myDataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataLayoutControl.Location = new System.Drawing.Point(0, 109);
            this.myDataLayoutControl.Name = "myDataLayoutControl";
            this.myDataLayoutControl.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl.Root = this.Root;
            this.myDataLayoutControl.Size = new System.Drawing.Size(998, 516);
            this.myDataLayoutControl.TabIndex = 0;
            this.myDataLayoutControl.Text = "myDataLayoutControl1";
            // 
            // txtHesap
            // 
            this.txtHesap.EnterMoveNextControl = true;
            this.txtHesap.Id = null;
            this.txtHesap.Location = new System.Drawing.Point(768, 36);
            this.txtHesap.MenuManager = this.ribbonControl;
            this.txtHesap.Name = "txtHesap";
            this.txtHesap.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtHesap.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtHesap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtHesap.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtHesap.Size = new System.Drawing.Size(218, 20);
            this.txtHesap.StatusBarAciklama = "Hesap Adı Seçiniz.";
            this.txtHesap.StatusBarKisaYol = "F4 :";
            this.txtHesap.StatusBarKisaYolAciklama = "Seçim Yap";
            this.txtHesap.StyleController = this.myDataLayoutControl;
            this.txtHesap.TabIndex = 3;
            // 
            // txtHesapTuru
            // 
            this.txtHesapTuru.EnterMoveNextControl = true;
            this.txtHesapTuru.Location = new System.Drawing.Point(768, 12);
            this.txtHesapTuru.MenuManager = this.ribbonControl;
            this.txtHesapTuru.Name = "txtHesapTuru";
            this.txtHesapTuru.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtHesapTuru.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtHesapTuru.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtHesapTuru.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtHesapTuru.Size = new System.Drawing.Size(118, 20);
            this.txtHesapTuru.StatusBarAciklama = "Hesap Türü Seçiniz.";
            this.txtHesapTuru.StatusBarKisaYol = "F4 :";
            this.txtHesapTuru.StatusBarKisaYolAciklama = "Seçim Yap";
            this.txtHesapTuru.StyleController = this.myDataLayoutControl;
            this.txtHesapTuru.TabIndex = 2;
            // 
            // txtTarih
            // 
            this.txtTarih.EditValue = null;
            this.txtTarih.EnterMoveNextControl = true;
            this.txtTarih.Location = new System.Drawing.Point(70, 36);
            this.txtTarih.MenuManager = this.ribbonControl;
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtTarih.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTarih.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtTarih.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtTarih.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTarih.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtTarih.Size = new System.Drawing.Size(98, 20);
            this.txtTarih.StatusBarAciklama = "Tarih Seçiniz";
            this.txtTarih.StatusBarKisaYol = "F4 :";
            this.txtTarih.StatusBarKisaYolAciklama = "Tarih Seç";
            this.txtTarih.StyleController = this.myDataLayoutControl;
            this.txtTarih.TabIndex = 1;
            // 
            // txtMakbuzNo
            // 
            this.txtMakbuzNo.EnterMoveNextControl = true;
            this.txtMakbuzNo.Location = new System.Drawing.Point(70, 12);
            this.txtMakbuzNo.MenuManager = this.ribbonControl;
            this.txtMakbuzNo.Name = "txtMakbuzNo";
            this.txtMakbuzNo.Properties.Appearance.Options.UseTextOptions = true;
            this.txtMakbuzNo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtMakbuzNo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtMakbuzNo.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtMakbuzNo.Properties.MaxLength = 50;
            this.txtMakbuzNo.Size = new System.Drawing.Size(98, 20);
            this.txtMakbuzNo.StatusBarAciklama = "Makbuz No Giriniz.";
            this.txtMakbuzNo.StyleController = this.myDataLayoutControl;
            this.txtMakbuzNo.TabIndex = 0;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutHesapAdi,
            this.layoutControlItem4});
            this.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.Root.Name = "Root";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition1.Width = 160D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition2.Width = 100D;
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition3.Width = 180D;
            columnDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition4.Width = 100D;
            this.Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2,
            columnDefinition3,
            columnDefinition4});
            rowDefinition1.Height = 24D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition2.Height = 24D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition3.Height = 100D;
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.Percent;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3});
            this.Root.Size = new System.Drawing.Size(998, 516);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.txtMakbuzNo;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(160, 24);
            this.layoutControlItem1.Text = "Makbuz No";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(55, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.txtTarih;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(160, 24);
            this.layoutControlItem2.Text = "Tarih";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(55, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem3.Control = this.txtHesapTuru;
            this.layoutControlItem3.Location = new System.Drawing.Point(698, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.ColumnIndex = 2;
            this.layoutControlItem3.Size = new System.Drawing.Size(180, 24);
            this.layoutControlItem3.Text = "Hesap Türü";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(55, 13);
            // 
            // layoutHesapAdi
            // 
            this.layoutHesapAdi.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutHesapAdi.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutHesapAdi.Control = this.txtHesap;
            this.layoutHesapAdi.Location = new System.Drawing.Point(698, 24);
            this.layoutHesapAdi.Name = "layoutHesapAdi";
            this.layoutHesapAdi.OptionsTableLayoutItem.ColumnIndex = 2;
            this.layoutHesapAdi.OptionsTableLayoutItem.ColumnSpan = 2;
            this.layoutHesapAdi.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutHesapAdi.Size = new System.Drawing.Size(280, 24);
            this.layoutHesapAdi.Text = "Hesap Adı";
            this.layoutHesapAdi.TextSize = new System.Drawing.Size(55, 13);
            // 
            // makbuzHareketleriTable
            // 
            this.makbuzHareketleriTable.Location = new System.Drawing.Point(12, 60);
            this.makbuzHareketleriTable.Name = "makbuzHareketleriTable";
            this.makbuzHareketleriTable.Size = new System.Drawing.Size(974, 444);
            this.makbuzHareketleriTable.TabIndex = 4;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem4.Control = this.makbuzHareketleriTable;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.ColumnSpan = 4;
            this.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem4.Size = new System.Drawing.Size(978, 448);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // MakbuzEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 649);
            this.Controls.Add(this.myDataLayoutControl);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "MakbuzEditForm";
            this.Text = "Makbuz Kartı";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.myDataLayoutControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimPopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).EndInit();
            this.myDataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtHesap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapTuru.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMakbuzNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutHesapAdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Controls.MyDataLayoutControl myDataLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private UserControls.Controls.MyDateEdit txtTarih;
        private UserControls.Controls.MyTextEdit txtMakbuzNo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutHesapAdi;
        protected internal UserControls.Controls.MyComboBoxEdit txtHesapTuru;
        protected internal UserControls.Controls.MyButtonEdit txtHesap;
        private UserControls.GenelEditFormTable.MakbuzHareketleriTable makbuzHareketleriTable;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}