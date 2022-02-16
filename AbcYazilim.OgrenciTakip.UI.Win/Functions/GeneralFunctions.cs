using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Common.Message;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using AbcYazilim.OgrenciTakip.UI.Win.UserControls.Controls;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using System;
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
        public static T GetRow<T>(this GridView tablo,bool mesajVer=true)
        {
            if (tablo.FocusedRowHandle > -1) return (T)tablo.GetRow(tablo.FocusedRowHandle);
            if (mesajVer)
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
        public static void ButtonEnabledSituation<T>(BarButtonItem btnNew,BarButtonItem btnSave,BarButtonItem btnUndo,BarButtonItem btnDelete,T oldEntity,T CurrentEntity)
        {
            var dataReplaceLocation = GetDataReplaceLocation(oldEntity, CurrentEntity);
            var buttonEnabledSituation = dataReplaceLocation == DataReplaceLocation.Alan;

            btnSave.Enabled = buttonEnabledSituation;
            btnUndo.Enabled = buttonEnabledSituation;
            btnNew.Enabled = !buttonEnabledSituation;
            btnDelete.Enabled = !buttonEnabledSituation;
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
    }
}
