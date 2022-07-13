
namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.MakbuzForms
{
    partial class BelgeSecimListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BelgeSecimListForm));
            this.longNavigator = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Navigators.LongNavigator();
            this.grid = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl();
            this.tablo = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridView();
            this.bndSecim = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colOgrenciNo = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colAdi = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colSoyadi = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colSinifAdi = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colOgrenciSubeAdi = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colPortfoyNo = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colBelgeSubeAdi = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colOdemeTuruAdi = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colBankaHesapAdi = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colTakipNo = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colGirisTarihi = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.repositoryTarih = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colVade = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colHesabaGecisTarihi = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colTutar = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.repositoryDecimal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colTahsil = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colIade = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colKalan = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colBelgeDurumu = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colAciklama = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colSonIslemTarihi = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colSonIslemYeri = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.bndBelgeDetayBilgileri = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colBankaAdi = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colBankaSubeAdi = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colBelgeNo = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colHesapNo = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colAsilBorclu = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colCiranta = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDecimal)).BeginInit();
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
            // btnGonder
            // 
            this.btnGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.Image")));
            this.btnGonder.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.LargeImage")));
            // 
            // btnYeniMakbuz
            // 
            this.btnYeniMakbuz.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYeniMakbuz.ImageOptions.Image")));
            this.btnYeniMakbuz.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnYeniMakbuz.ImageOptions.LargeImage")));
            // 
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 531);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(998, 24);
            this.longNavigator.TabIndex = 2;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 109);
            this.grid.MainView = this.tablo;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryTarih,
            this.repositoryDecimal});
            this.grid.Size = new System.Drawing.Size(998, 422);
            this.grid.TabIndex = 6;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tablo});
            // 
            // tablo
            // 
            this.tablo.Appearance.BandPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tablo.Appearance.BandPanel.ForeColor = System.Drawing.Color.DarkBlue;
            this.tablo.Appearance.BandPanel.Options.UseFont = true;
            this.tablo.Appearance.BandPanel.Options.UseForeColor = true;
            this.tablo.Appearance.BandPanel.Options.UseTextOptions = true;
            this.tablo.Appearance.BandPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tablo.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tablo.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.FooterPanel.Options.UseFont = true;
            this.tablo.Appearance.FooterPanel.Options.UseForeColor = true;
            this.tablo.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.tablo.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.tablo.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tablo.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.ViewCaption.Options.UseForeColor = true;
            this.tablo.BandPanelRowHeight = 20;
            this.tablo.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.bndSecim,
            this.gridBand1,
            this.gridBand2,
            this.bndBelgeDetayBilgileri});
            this.tablo.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colOgrenciNo,
            this.colAdi,
            this.colSoyadi,
            this.colSinifAdi,
            this.colOgrenciSubeAdi,
            this.colBelgeSubeAdi,
            this.colOdemeTuruAdi,
            this.colBankaHesapAdi,
            this.colTakipNo,
            this.colPortfoyNo,
            this.colGirisTarihi,
            this.colVade,
            this.colHesabaGecisTarihi,
            this.colTutar,
            this.colTahsil,
            this.colIade,
            this.colKalan,
            this.colSonIslemTarihi,
            this.colSonIslemYeri,
            this.colBankaAdi,
            this.colBankaSubeAdi,
            this.colBelgeNo,
            this.colHesapNo,
            this.colAsilBorclu,
            this.colCiranta,
            this.colBelgeDurumu,
            this.colAciklama});
            this.tablo.GridControl = this.grid;
            this.tablo.Name = "tablo";
            this.tablo.OptionsMenu.EnableColumnMenu = false;
            this.tablo.OptionsMenu.EnableFooterMenu = false;
            this.tablo.OptionsMenu.EnableGroupPanelMenu = false;
            this.tablo.OptionsNavigation.EnterMoveNextColumn = true;
            this.tablo.OptionsPrint.AutoWidth = false;
            this.tablo.OptionsPrint.PrintFooter = false;
            this.tablo.OptionsPrint.PrintGroupFooter = false;
            this.tablo.OptionsView.ColumnAutoWidth = false;
            this.tablo.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.tablo.OptionsView.RowAutoHeight = true;
            this.tablo.OptionsView.ShowAutoFilterRow = true;
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.StatusBarAciklama = null;
            this.tablo.StatusBarKisaYol = null;
            this.tablo.StatusBarKisaYolAciklama = null;
            this.tablo.ViewCaption = "Makbuz Hareketleri";
            // 
            // bndSecim
            // 
            this.bndSecim.Caption = "Seç";
            this.bndSecim.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.bndSecim.Name = "bndSecim";
            this.bndSecim.Visible = false;
            this.bndSecim.VisibleIndex = -1;
            this.bndSecim.Width = 35;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Öğrenci Bilgileri";
            this.gridBand1.Columns.Add(this.colOgrenciNo);
            this.gridBand1.Columns.Add(this.colAdi);
            this.gridBand1.Columns.Add(this.colSoyadi);
            this.gridBand1.Columns.Add(this.colSinifAdi);
            this.gridBand1.Columns.Add(this.colOgrenciSubeAdi);
            this.gridBand1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 557;
            // 
            // colOgrenciNo
            // 
            this.colOgrenciNo.AppearanceCell.Options.UseTextOptions = true;
            this.colOgrenciNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOgrenciNo.Caption = "Öğrenci No";
            this.colOgrenciNo.FieldName = "OgrenciNo";
            this.colOgrenciNo.Name = "colOgrenciNo";
            this.colOgrenciNo.OptionsColumn.AllowEdit = false;
            this.colOgrenciNo.StatusBarAciklama = null;
            this.colOgrenciNo.StatusBarKisaYol = null;
            this.colOgrenciNo.StatusBarKisaYolAciklama = null;
            this.colOgrenciNo.Visible = true;
            this.colOgrenciNo.Width = 83;
            // 
            // colAdi
            // 
            this.colAdi.Caption = "Adı";
            this.colAdi.FieldName = "Adi";
            this.colAdi.Name = "colAdi";
            this.colAdi.OptionsColumn.AllowEdit = false;
            this.colAdi.StatusBarAciklama = null;
            this.colAdi.StatusBarKisaYol = null;
            this.colAdi.StatusBarKisaYolAciklama = null;
            this.colAdi.Visible = true;
            this.colAdi.Width = 93;
            // 
            // colSoyadi
            // 
            this.colSoyadi.Caption = "Soyadı";
            this.colSoyadi.FieldName = "Soyadi";
            this.colSoyadi.Name = "colSoyadi";
            this.colSoyadi.OptionsColumn.AllowEdit = false;
            this.colSoyadi.StatusBarAciklama = null;
            this.colSoyadi.StatusBarKisaYol = null;
            this.colSoyadi.StatusBarKisaYolAciklama = null;
            this.colSoyadi.Visible = true;
            this.colSoyadi.Width = 93;
            // 
            // colSinifAdi
            // 
            this.colSinifAdi.Caption = "Sınıf";
            this.colSinifAdi.FieldName = "SinifAdi";
            this.colSinifAdi.Name = "colSinifAdi";
            this.colSinifAdi.OptionsColumn.AllowEdit = false;
            this.colSinifAdi.StatusBarAciklama = null;
            this.colSinifAdi.StatusBarKisaYol = null;
            this.colSinifAdi.StatusBarKisaYolAciklama = null;
            this.colSinifAdi.Visible = true;
            this.colSinifAdi.Width = 93;
            // 
            // colOgrenciSubeAdi
            // 
            this.colOgrenciSubeAdi.Caption = "Şube Adı";
            this.colOgrenciSubeAdi.CustomizationCaption = "Öğrenci Şube Adı";
            this.colOgrenciSubeAdi.FieldName = "OgrenciSubeAdi";
            this.colOgrenciSubeAdi.Name = "colOgrenciSubeAdi";
            this.colOgrenciSubeAdi.OptionsColumn.AllowEdit = false;
            this.colOgrenciSubeAdi.StatusBarAciklama = null;
            this.colOgrenciSubeAdi.StatusBarKisaYol = null;
            this.colOgrenciSubeAdi.StatusBarKisaYolAciklama = null;
            this.colOgrenciSubeAdi.Visible = true;
            this.colOgrenciSubeAdi.Width = 195;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Belge Genel Bilgiler";
            this.gridBand2.Columns.Add(this.colPortfoyNo);
            this.gridBand2.Columns.Add(this.colBelgeSubeAdi);
            this.gridBand2.Columns.Add(this.colOdemeTuruAdi);
            this.gridBand2.Columns.Add(this.colBankaHesapAdi);
            this.gridBand2.Columns.Add(this.colTakipNo);
            this.gridBand2.Columns.Add(this.colGirisTarihi);
            this.gridBand2.Columns.Add(this.colVade);
            this.gridBand2.Columns.Add(this.colHesabaGecisTarihi);
            this.gridBand2.Columns.Add(this.colTutar);
            this.gridBand2.Columns.Add(this.colTahsil);
            this.gridBand2.Columns.Add(this.colIade);
            this.gridBand2.Columns.Add(this.colKalan);
            this.gridBand2.Columns.Add(this.colBelgeDurumu);
            this.gridBand2.Columns.Add(this.colAciklama);
            this.gridBand2.Columns.Add(this.colSonIslemTarihi);
            this.gridBand2.Columns.Add(this.colSonIslemYeri);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 2200;
            // 
            // colPortfoyNo
            // 
            this.colPortfoyNo.Caption = "Portföy No";
            this.colPortfoyNo.FieldName = "OdemeBilgileriId";
            this.colPortfoyNo.Name = "colPortfoyNo";
            this.colPortfoyNo.OptionsColumn.AllowEdit = false;
            this.colPortfoyNo.StatusBarAciklama = null;
            this.colPortfoyNo.StatusBarKisaYol = null;
            this.colPortfoyNo.StatusBarKisaYolAciklama = null;
            this.colPortfoyNo.Visible = true;
            this.colPortfoyNo.Width = 100;
            // 
            // colBelgeSubeAdi
            // 
            this.colBelgeSubeAdi.Caption = "Şube Adı";
            this.colBelgeSubeAdi.CustomizationCaption = "Belge Şube Adı";
            this.colBelgeSubeAdi.FieldName = "BelgeSubeAdi";
            this.colBelgeSubeAdi.Name = "colBelgeSubeAdi";
            this.colBelgeSubeAdi.OptionsColumn.AllowEdit = false;
            this.colBelgeSubeAdi.StatusBarAciklama = null;
            this.colBelgeSubeAdi.StatusBarKisaYol = null;
            this.colBelgeSubeAdi.StatusBarKisaYolAciklama = null;
            this.colBelgeSubeAdi.Visible = true;
            this.colBelgeSubeAdi.Width = 200;
            // 
            // colOdemeTuruAdi
            // 
            this.colOdemeTuruAdi.Caption = "Ödeme Türü";
            this.colOdemeTuruAdi.FieldName = "OdemeTuruAdi";
            this.colOdemeTuruAdi.Name = "colOdemeTuruAdi";
            this.colOdemeTuruAdi.OptionsColumn.AllowEdit = false;
            this.colOdemeTuruAdi.StatusBarAciklama = null;
            this.colOdemeTuruAdi.StatusBarKisaYol = null;
            this.colOdemeTuruAdi.StatusBarKisaYolAciklama = null;
            this.colOdemeTuruAdi.Visible = true;
            this.colOdemeTuruAdi.Width = 100;
            // 
            // colBankaHesapAdi
            // 
            this.colBankaHesapAdi.Caption = "Hesap Adı";
            this.colBankaHesapAdi.CustomizationCaption = "Banka Hesap Adı";
            this.colBankaHesapAdi.FieldName = "BankaHesapAdi";
            this.colBankaHesapAdi.Name = "colBankaHesapAdi";
            this.colBankaHesapAdi.OptionsColumn.AllowEdit = false;
            this.colBankaHesapAdi.StatusBarAciklama = null;
            this.colBankaHesapAdi.StatusBarKisaYol = null;
            this.colBankaHesapAdi.StatusBarKisaYolAciklama = null;
            this.colBankaHesapAdi.Visible = true;
            this.colBankaHesapAdi.Width = 200;
            // 
            // colTakipNo
            // 
            this.colTakipNo.Caption = "Takip No";
            this.colTakipNo.FieldName = "TakipNo";
            this.colTakipNo.Name = "colTakipNo";
            this.colTakipNo.OptionsColumn.AllowEdit = false;
            this.colTakipNo.StatusBarAciklama = null;
            this.colTakipNo.StatusBarKisaYol = null;
            this.colTakipNo.StatusBarKisaYolAciklama = null;
            this.colTakipNo.Visible = true;
            this.colTakipNo.Width = 100;
            // 
            // colGirisTarihi
            // 
            this.colGirisTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colGirisTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGirisTarihi.Caption = "Giriş Tarihi";
            this.colGirisTarihi.ColumnEdit = this.repositoryTarih;
            this.colGirisTarihi.FieldName = "GirisTarihi";
            this.colGirisTarihi.Name = "colGirisTarihi";
            this.colGirisTarihi.OptionsColumn.AllowEdit = false;
            this.colGirisTarihi.StatusBarAciklama = null;
            this.colGirisTarihi.StatusBarKisaYol = null;
            this.colGirisTarihi.StatusBarKisaYolAciklama = null;
            this.colGirisTarihi.Visible = true;
            this.colGirisTarihi.Width = 100;
            // 
            // repositoryTarih
            // 
            this.repositoryTarih.AutoHeight = false;
            this.repositoryTarih.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryTarih.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryTarih.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.repositoryTarih.Name = "repositoryTarih";
            // 
            // colVade
            // 
            this.colVade.AppearanceCell.Options.UseTextOptions = true;
            this.colVade.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colVade.Caption = "Vade";
            this.colVade.ColumnEdit = this.repositoryTarih;
            this.colVade.FieldName = "Vade";
            this.colVade.Name = "colVade";
            this.colVade.OptionsColumn.AllowEdit = false;
            this.colVade.StatusBarAciklama = null;
            this.colVade.StatusBarKisaYol = null;
            this.colVade.StatusBarKisaYolAciklama = null;
            this.colVade.Visible = true;
            this.colVade.Width = 100;
            // 
            // colHesabaGecisTarihi
            // 
            this.colHesabaGecisTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colHesabaGecisTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHesabaGecisTarihi.Caption = "H.G Geçiş Tarihi";
            this.colHesabaGecisTarihi.ColumnEdit = this.repositoryTarih;
            this.colHesabaGecisTarihi.FieldName = "HesabaGecisTarihi";
            this.colHesabaGecisTarihi.Name = "colHesabaGecisTarihi";
            this.colHesabaGecisTarihi.OptionsColumn.AllowEdit = false;
            this.colHesabaGecisTarihi.StatusBarAciklama = null;
            this.colHesabaGecisTarihi.StatusBarKisaYol = null;
            this.colHesabaGecisTarihi.StatusBarKisaYolAciklama = null;
            this.colHesabaGecisTarihi.Visible = true;
            this.colHesabaGecisTarihi.Width = 100;
            // 
            // colTutar
            // 
            this.colTutar.Caption = "Tutar";
            this.colTutar.ColumnEdit = this.repositoryDecimal;
            this.colTutar.FieldName = "Tutar";
            this.colTutar.Name = "colTutar";
            this.colTutar.OptionsColumn.AllowEdit = false;
            this.colTutar.StatusBarAciklama = null;
            this.colTutar.StatusBarKisaYol = null;
            this.colTutar.StatusBarKisaYolAciklama = null;
            this.colTutar.Visible = true;
            this.colTutar.Width = 100;
            // 
            // repositoryDecimal
            // 
            this.repositoryDecimal.AutoHeight = false;
            this.repositoryDecimal.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryDecimal.DisplayFormat.FormatString = "{0:n2}";
            this.repositoryDecimal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryDecimal.EditFormat.FormatString = "{0:n2}";
            this.repositoryDecimal.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryDecimal.Mask.EditMask = "n2";
            this.repositoryDecimal.Name = "repositoryDecimal";
            // 
            // colTahsil
            // 
            this.colTahsil.Caption = "Tahsil";
            this.colTahsil.ColumnEdit = this.repositoryDecimal;
            this.colTahsil.FieldName = "Tahsil";
            this.colTahsil.Name = "colTahsil";
            this.colTahsil.OptionsColumn.AllowEdit = false;
            this.colTahsil.StatusBarAciklama = null;
            this.colTahsil.StatusBarKisaYol = null;
            this.colTahsil.StatusBarKisaYolAciklama = null;
            this.colTahsil.Visible = true;
            this.colTahsil.Width = 100;
            // 
            // colIade
            // 
            this.colIade.Caption = "İade";
            this.colIade.ColumnEdit = this.repositoryDecimal;
            this.colIade.FieldName = "Iade";
            this.colIade.Name = "colIade";
            this.colIade.OptionsColumn.AllowEdit = false;
            this.colIade.StatusBarAciklama = null;
            this.colIade.StatusBarKisaYol = null;
            this.colIade.StatusBarKisaYolAciklama = null;
            this.colIade.Visible = true;
            this.colIade.Width = 100;
            // 
            // colKalan
            // 
            this.colKalan.Caption = "Kalan";
            this.colKalan.ColumnEdit = this.repositoryDecimal;
            this.colKalan.FieldName = "Kalan";
            this.colKalan.Name = "colKalan";
            this.colKalan.OptionsColumn.AllowEdit = false;
            this.colKalan.StatusBarAciklama = null;
            this.colKalan.StatusBarKisaYol = null;
            this.colKalan.StatusBarKisaYolAciklama = null;
            this.colKalan.Visible = true;
            this.colKalan.Width = 100;
            // 
            // colBelgeDurumu
            // 
            this.colBelgeDurumu.Caption = "Durum";
            this.colBelgeDurumu.FieldName = "BelgeDurumu";
            this.colBelgeDurumu.Name = "colBelgeDurumu";
            this.colBelgeDurumu.OptionsColumn.AllowEdit = false;
            this.colBelgeDurumu.StatusBarAciklama = null;
            this.colBelgeDurumu.StatusBarKisaYol = null;
            this.colBelgeDurumu.StatusBarKisaYolAciklama = null;
            this.colBelgeDurumu.Visible = true;
            this.colBelgeDurumu.Width = 200;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.StatusBarAciklama = null;
            this.colAciklama.StatusBarKisaYol = null;
            this.colAciklama.StatusBarKisaYolAciklama = null;
            this.colAciklama.Visible = true;
            this.colAciklama.Width = 250;
            // 
            // colSonIslemTarihi
            // 
            this.colSonIslemTarihi.Caption = "Son İşlem Tarihi";
            this.colSonIslemTarihi.FieldName = "SonIslemTarihi";
            this.colSonIslemTarihi.Name = "colSonIslemTarihi";
            this.colSonIslemTarihi.OptionsColumn.AllowEdit = false;
            this.colSonIslemTarihi.StatusBarAciklama = null;
            this.colSonIslemTarihi.StatusBarKisaYol = null;
            this.colSonIslemTarihi.StatusBarKisaYolAciklama = null;
            this.colSonIslemTarihi.Visible = true;
            this.colSonIslemTarihi.Width = 150;
            // 
            // colSonIslemYeri
            // 
            this.colSonIslemYeri.Caption = "Son İşlem Yeri";
            this.colSonIslemYeri.FieldName = "SonIslemYeri";
            this.colSonIslemYeri.Name = "colSonIslemYeri";
            this.colSonIslemYeri.OptionsColumn.AllowEdit = false;
            this.colSonIslemYeri.StatusBarAciklama = null;
            this.colSonIslemYeri.StatusBarKisaYol = null;
            this.colSonIslemYeri.StatusBarKisaYolAciklama = null;
            this.colSonIslemYeri.Visible = true;
            this.colSonIslemYeri.Width = 200;
            // 
            // bndBelgeDetayBilgileri
            // 
            this.bndBelgeDetayBilgileri.Caption = "Belge Detay Bilgiler";
            this.bndBelgeDetayBilgileri.Columns.Add(this.colBankaAdi);
            this.bndBelgeDetayBilgileri.Columns.Add(this.colBankaSubeAdi);
            this.bndBelgeDetayBilgileri.Columns.Add(this.colBelgeNo);
            this.bndBelgeDetayBilgileri.Columns.Add(this.colHesapNo);
            this.bndBelgeDetayBilgileri.Columns.Add(this.colAsilBorclu);
            this.bndBelgeDetayBilgileri.Columns.Add(this.colCiranta);
            this.bndBelgeDetayBilgileri.Name = "bndBelgeDetayBilgileri";
            this.bndBelgeDetayBilgileri.VisibleIndex = 2;
            this.bndBelgeDetayBilgileri.Width = 1100;
            // 
            // colBankaAdi
            // 
            this.colBankaAdi.Caption = "Banka Adı";
            this.colBankaAdi.FieldName = "BankaAdi";
            this.colBankaAdi.Name = "colBankaAdi";
            this.colBankaAdi.OptionsColumn.AllowEdit = false;
            this.colBankaAdi.StatusBarAciklama = null;
            this.colBankaAdi.StatusBarKisaYol = null;
            this.colBankaAdi.StatusBarKisaYolAciklama = null;
            this.colBankaAdi.Visible = true;
            this.colBankaAdi.Width = 200;
            // 
            // colBankaSubeAdi
            // 
            this.colBankaSubeAdi.Caption = "Banka Şube";
            this.colBankaSubeAdi.FieldName = "BankaSubeAdi";
            this.colBankaSubeAdi.Name = "colBankaSubeAdi";
            this.colBankaSubeAdi.OptionsColumn.AllowEdit = false;
            this.colBankaSubeAdi.StatusBarAciklama = null;
            this.colBankaSubeAdi.StatusBarKisaYol = null;
            this.colBankaSubeAdi.StatusBarKisaYolAciklama = null;
            this.colBankaSubeAdi.Visible = true;
            this.colBankaSubeAdi.Width = 200;
            // 
            // colBelgeNo
            // 
            this.colBelgeNo.Caption = "Belge No";
            this.colBelgeNo.FieldName = "BelgeNo";
            this.colBelgeNo.Name = "colBelgeNo";
            this.colBelgeNo.OptionsColumn.AllowEdit = false;
            this.colBelgeNo.StatusBarAciklama = null;
            this.colBelgeNo.StatusBarKisaYol = null;
            this.colBelgeNo.StatusBarKisaYolAciklama = null;
            this.colBelgeNo.Visible = true;
            this.colBelgeNo.Width = 150;
            // 
            // colHesapNo
            // 
            this.colHesapNo.Caption = "Hesap No";
            this.colHesapNo.FieldName = "HesapNo";
            this.colHesapNo.Name = "colHesapNo";
            this.colHesapNo.OptionsColumn.AllowEdit = false;
            this.colHesapNo.StatusBarAciklama = null;
            this.colHesapNo.StatusBarKisaYol = null;
            this.colHesapNo.StatusBarKisaYolAciklama = null;
            this.colHesapNo.Visible = true;
            this.colHesapNo.Width = 150;
            // 
            // colAsilBorclu
            // 
            this.colAsilBorclu.Caption = "Asıl Borçlu";
            this.colAsilBorclu.FieldName = "AsilBorclu";
            this.colAsilBorclu.Name = "colAsilBorclu";
            this.colAsilBorclu.OptionsColumn.AllowEdit = false;
            this.colAsilBorclu.StatusBarAciklama = null;
            this.colAsilBorclu.StatusBarKisaYol = null;
            this.colAsilBorclu.StatusBarKisaYolAciklama = null;
            this.colAsilBorclu.Visible = true;
            this.colAsilBorclu.Width = 200;
            // 
            // colCiranta
            // 
            this.colCiranta.Caption = "Ciranta";
            this.colCiranta.FieldName = "Ciranta";
            this.colCiranta.Name = "colCiranta";
            this.colCiranta.OptionsColumn.AllowEdit = false;
            this.colCiranta.StatusBarAciklama = null;
            this.colCiranta.StatusBarKisaYol = null;
            this.colCiranta.StatusBarKisaYolAciklama = null;
            this.colCiranta.Visible = true;
            this.colCiranta.Width = 200;
            // 
            // BelgeSecimListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 579);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.Name = "BelgeSecimListForm";
            this.Text = "Belge Seçim";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDecimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Grid.MyBandedGridControl grid;
        private UserControls.Grid.MyBandedGridView tablo;
        private UserControls.Grid.MyBandedGridColumn colOgrenciNo;
        private UserControls.Grid.MyBandedGridColumn colAdi;
        private UserControls.Grid.MyBandedGridColumn colSoyadi;
        private UserControls.Grid.MyBandedGridColumn colSinifAdi;
        private UserControls.Grid.MyBandedGridColumn colOgrenciSubeAdi;
        private UserControls.Grid.MyBandedGridColumn colPortfoyNo;
        private UserControls.Grid.MyBandedGridColumn colBelgeSubeAdi;
        private UserControls.Grid.MyBandedGridColumn colOdemeTuruAdi;
        private UserControls.Grid.MyBandedGridColumn colBankaHesapAdi;
        private UserControls.Grid.MyBandedGridColumn colTakipNo;
        private UserControls.Grid.MyBandedGridColumn colGirisTarihi;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryTarih;
        private UserControls.Grid.MyBandedGridColumn colVade;
        private UserControls.Grid.MyBandedGridColumn colHesabaGecisTarihi;
        private UserControls.Grid.MyBandedGridColumn colTutar;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryDecimal;
        private UserControls.Grid.MyBandedGridColumn colTahsil;
        private UserControls.Grid.MyBandedGridColumn colIade;
        private UserControls.Grid.MyBandedGridColumn colKalan;
        private UserControls.Grid.MyBandedGridColumn colBelgeDurumu;
        private UserControls.Grid.MyBandedGridColumn colAciklama;
        private UserControls.Grid.MyBandedGridColumn colSonIslemTarihi;
        private UserControls.Grid.MyBandedGridColumn colSonIslemYeri;
        private UserControls.Grid.MyBandedGridColumn colBankaAdi;
        private UserControls.Grid.MyBandedGridColumn colBankaSubeAdi;
        private UserControls.Grid.MyBandedGridColumn colBelgeNo;
        private UserControls.Grid.MyBandedGridColumn colHesapNo;
        private UserControls.Grid.MyBandedGridColumn colAsilBorclu;
        private UserControls.Grid.MyBandedGridColumn colCiranta;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bndSecim;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bndBelgeDetayBilgileri;
    }
}