using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Common.Message;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using AbcYazilim.OgrenciTakip.Model.Entities.Base.Interfaces;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.UserControls.Controls;
using AbcYazilim.OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AbcYazilim.OgrenciTakip.UI.Win.Functions
{
    public static class GeneralFunctions
    {
        public static long GetRowId(this GridView tablo)
        {
            if (tablo.FocusedRowHandle > -1) return (long)tablo.GetFocusedRowCellValue("Id");
            Messages.KartSecmemeUyariMesaji();
            return -1;
        }
        public static long GetRowCellId(this GridView tablo,GridColumn idColumn)
        {
            var value = tablo.GetRowCellValue(tablo.FocusedRowHandle, idColumn);
            return (long?)value ?? -1;
        }
        public static T GetRow<T>(this GridView tablo,bool mesajVer=true)
        {
            if (tablo.FocusedRowHandle > -1) return (T)tablo.GetRow(tablo.FocusedRowHandle);
            if (mesajVer)
                Messages.KartSecmemeUyariMesaji();
            return default(T);
        }
        public static T GetRow<T>(this GridView tablo, int rowHandle)
        {
            if (tablo.FocusedRowHandle > -1) return (T)tablo.GetRow(rowHandle);
                Messages.KartSecmemeUyariMesaji();
            return default(T);
        }
        private static DataReplaceLocation GetDataReplaceLocation<T>(T oldEntity,T currentEntity)
        {
            foreach (var prop in currentEntity.GetType().GetProperties())
            {
                if (prop.PropertyType.Namespace == "System.Collections.Generic") continue;
                var oldValue = prop.GetValue(oldEntity) ?? string.Empty;
                var currentValue = prop.GetValue(currentEntity) ?? string.Empty;

                if (prop.PropertyType == typeof(byte[]))
                {
                    if (string.IsNullOrEmpty(oldValue.ToString()))
                        oldValue = new byte[] { 0 };
                    if (string.IsNullOrEmpty(currentValue.ToString()))
                        currentValue = new byte[] { 0 };

                    if (((byte[])oldValue).Length != ((byte[])currentValue).Length)
                    {
                        return DataReplaceLocation.Alan;
                    }
                }
                else if (!currentValue.Equals(oldValue))
                {
                    return DataReplaceLocation.Alan;
                }
            }
            return DataReplaceLocation.VeriDegisimDurumu; //false
        }
        public static void ButtonEnabledSituation<T>(BarButtonItem btnKaydet, BarButtonItem btnFarkliKaydet, BarButtonItem btnSil, IslemTuru islemTuru, T oldEntity, T CurrentEntity)
        {
            var dataReplaceLocation = GetDataReplaceLocation(oldEntity, CurrentEntity);
            var buttonEnabledSituation = dataReplaceLocation == DataReplaceLocation.Alan;

            btnKaydet.Enabled = buttonEnabledSituation;
            btnFarkliKaydet.Enabled = islemTuru != IslemTuru.EntityInsert;
            btnSil.Enabled = !buttonEnabledSituation;
        }
        public static void ButtonEnabledSituation<T>(BarButtonItem btnNew, BarButtonItem btnSave, BarButtonItem btnUndo, BarButtonItem btnDelete, T oldEntity, T CurrentEntity, bool tableValueChanged)
        {
            var dataReplaceLocation = tableValueChanged?DataReplaceLocation.Tablo:GetDataReplaceLocation(oldEntity, CurrentEntity);
            var buttonEnabledSituation = dataReplaceLocation == DataReplaceLocation.Alan || dataReplaceLocation==DataReplaceLocation.Tablo;


            btnSave.Enabled = buttonEnabledSituation;
            btnUndo.Enabled = buttonEnabledSituation;
            btnNew.Enabled = !buttonEnabledSituation;
            btnDelete.Enabled = !buttonEnabledSituation;
        }
        public static void ButtonEnabledSituation<T>(BarButtonItem btnNew,BarButtonItem btnSave,BarButtonItem btnUndo,BarButtonItem btnDelete,T oldEntity,T CurrentEntity)
        {
            var dataReplaceLocation = GetDataReplaceLocation(oldEntity, CurrentEntity);
            var buttonEnabledSituation = dataReplaceLocation == DataReplaceLocation.Alan;

            btnSave.Enabled = buttonEnabledSituation;
            btnUndo.Enabled = buttonEnabledSituation;
            btnNew.Enabled = !buttonEnabledSituation;
            btnDelete.Enabled = !buttonEnabledSituation;
        }
        public static void ButtonEnabledSituation(BarButtonItem btnNew, BarButtonItem btnSave, BarButtonItem btnUndo, BarButtonItem btnDelete)
        {
            btnSave.Enabled = false;
            btnUndo.Enabled = false;
            btnNew.Enabled = false;
            btnDelete.Enabled = false;
        }
        public static long IdOlustur(this IslemTuru islemTuru,BaseEntity selectedEntity)
        {
            string AddZero(string obj)
            {
                if (obj.Length == 1)
                    return "0" + obj;
                return obj;
            }
            string ThreeDigitNum(string obj)
            {
                switch (obj.Length)
                {
                    case 1:
                        return "00" + obj;
                    case 2:
                        return "0" + obj;
                }
                return obj;
            }
            string IdCreator()
            {
                var yil = AddZero(DateTime.Now.Date.Year.ToString());
                var ay= AddZero(DateTime.Now.Date.Month.ToString());
                var gun= AddZero(DateTime.Now.Date.Day.ToString());
                var saat= AddZero(DateTime.Now.Hour.ToString());
                var dakika= AddZero(DateTime.Now.Minute.ToString());
                var saniye= AddZero(DateTime.Now.Second.ToString());
                var milisaniye= ThreeDigitNum(DateTime.Now.Millisecond.ToString());
                var random= AddZero(new Random().Next(0,99).ToString());
                return yil + ay + gun + saat + dakika + saniye + milisaniye + random;
            }
            return islemTuru == IslemTuru.EntityUpdate ? selectedEntity.Id : long.Parse(IdCreator());
        }
        public static void ControlEnabledChange(this MyButtonEdit baseEdit ,Control prmEdit)
        {
            switch (prmEdit)
            {
                case MyButtonEdit edt:
                    edt.Enabled = baseEdit.Id.HasValue&&baseEdit.Id>0;
                    edt.Id = null;
                    edt.EditValue = null;
                    break;
            }
        }
        public static void RowFocus(this GridView tablo,string aranacakKolon,object aranacakDeger)
        {
            var rowHandle = 0;

            for (int i = 0; i < tablo.RowCount; i++)
            {
                var bulunanDeger = tablo.GetRowCellValue(i, aranacakKolon);
                if (aranacakDeger.Equals(bulunanDeger))
                    rowHandle = i;
            }
            tablo.FocusedRowHandle = rowHandle;
        }
        public static void RowFocus(this GridView tablo,int rowhandle)
        {
            if (rowhandle <= 0) return;
            if (rowhandle == tablo.RowCount - 1)
                tablo.FocusedRowHandle = rowhandle;
            else
                tablo.FocusedRowHandle = rowhandle - 1;
        }
        public static void SagMenuGoster(this MouseEventArgs e,PopupMenu sagMenu)
        {
            if (e.Button != MouseButtons.Right) return;
            sagMenu.ShowPopup(Control.MousePosition);
        }
        public static List<string> YazicilariListele()
        {
            return PrinterSettings.InstalledPrinters.Cast<string>().ToList();
        }
        public static string DefaultPrtiner()
        {
            var settings = new PrinterSettings();
            return settings.PrinterName;
        }
        public static void ShowPopupMenu(this MouseEventArgs e,PopupMenu popupMenu)
        {
            if (e.Button != MouseButtons.Right) return;
            popupMenu.ShowPopup(Control.MousePosition);
        }
        public static byte[] ResimYukle()
        {
            var dialog = new OpenFileDialog
            {
                Title = "Resim Seçiniz.(ZEC Technology)",
                Filter = "Resim Dosyaları (*.bmp, *.gif, *.jpg, *.png)|*.bmp; *.gif; *.jpg; *.png|Bmp Dosyaları|*.bmp|Gif Dosyaları|*.gif|Jpg Dosyaları|*.jpg|Png Dosyaları|*.png",
                InitialDirectory = @"C:\"
            };
            byte[] Resim()
            {
                using (var stream = new MemoryStream())
                {
                    Image.FromFile(dialog.FileName).Save(stream, ImageFormat.Png);
                    return stream.ToArray();
                }
            }
            return dialog.ShowDialog() != DialogResult.OK ? null : Resim();
        }
        public static void RefreshDataSource(this GridView tablo)
        {
            var source = tablo.DataController.ListSource.Cast<IBaseHareketEntity>().ToList();
            if (!source.Any(x => x.Delete)) return;
            var rowHandle = tablo.FocusedRowHandle;

            tablo.CustomRowFilter += Tablo_CustomRowFilter;
            tablo.RefreshData();
            tablo.CustomRowFilter -= Tablo_CustomRowFilter;
            tablo.RowFocus(rowHandle);
            void Tablo_CustomRowFilter(object sender, RowFilterEventArgs e)
            {
                var entity = source[e.ListSourceRow];
                if(entity==null) return;
                if (!entity.Delete) return;
                e.Visible = false;
                e.Handled = true;
            }
        }
        public static BindingList<T> ToBindingList<T>(this IEnumerable<BaseHareketEntity> list)
        {
            return new BindingList<T>((IList<T>)list);
        }
        public static BaseTablo AddTable(this BaseTablo tablo,BaseEditForm frm)
        {
            tablo.Dock = DockStyle.Fill;
            tablo.OwnerForm = frm;
            return tablo;
        }
        public static void LayoutControlInsert(this LayoutGroup group,Control control,int columnIndex,int rowIndex,int columnSpan,int rowSpan)
        {
            var item = new LayoutControlItem
            {
                Control = control,
                Parent=group
            };
            item.OptionsTableLayoutItem.ColumnIndex = columnIndex;
            item.OptionsTableLayoutItem.RowIndex = rowIndex;
            item.OptionsTableLayoutItem.ColumnSpan = columnSpan;
            item.OptionsTableLayoutItem.RowSpan = rowSpan;
        }
        public static void RowCellEnabled(this GridView tablo)
        {
            var rowHandle = tablo.FocusedRowHandle;

            tablo.FocusedRowHandle = 0;
            tablo.ClearSelection();

            tablo.FocusedRowHandle = rowHandle;
        }

    }
}
