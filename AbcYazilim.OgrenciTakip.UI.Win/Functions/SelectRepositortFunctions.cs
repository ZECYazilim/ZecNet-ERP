using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Dto;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BankaForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.IptalNedeniForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.OkulForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.YakinlikForms;
using AbcYazilim.OgrenciTakip.UI.Win.Show;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;

namespace AbcYazilim.OgrenciTakip.UI.Win.Functions
{
    public static class SelectRepositortFunctions
    {
        #region Variables
        private static GridView _tablo;
        private static ControlNavigator _navigator;
        private static RepositoryItemButtonEdit _buttonEdit;
        private static GridColumn _idColumn;
        private static GridColumn _nameColumn;
        #endregion

        private static void RemoveEvent()
        {
            if (_buttonEdit == null) return;
            //Buton Eventleri
            _buttonEdit.ButtonClick -= ButtonEdit_ButtonClick;
            _buttonEdit.KeyDown -= ButtonEdit_KeyDown;
            _buttonEdit.DoubleClick -= ButtonEdit_DoubleClick;
            //Tablo Events
            _tablo.KeyDown -= Tablo_KeyDown;
        }
        public static void Sec(this GridColumn nameColumn, GridView tablo, ControlNavigator navigator, RepositoryItemButtonEdit buttonEdit, GridColumn idColumn)
        {
            RemoveEvent();

            _tablo = tablo;
            _navigator = navigator;
            _buttonEdit = buttonEdit;
            _idColumn = idColumn;
            _nameColumn = nameColumn;

            //Buton Eventleri
            _buttonEdit.ButtonClick += ButtonEdit_ButtonClick;
            _buttonEdit.KeyDown += ButtonEdit_KeyDown;
            _buttonEdit.DoubleClick += ButtonEdit_DoubleClick;
            //Tablo Events
            _tablo.KeyDown += Tablo_KeyDown;
        }
        private static void ButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SecimYap();
        }
        private static void ButtonEdit_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete when e.Control && e.Shift:
                    _tablo.SetFocusedRowCellValue(_idColumn, null);
                    _tablo.SetFocusedRowCellValue(_nameColumn, null);
                    _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
                    break;
                case Keys.F4:
                case Keys.Down when e.Alt:
                    SecimYap();
                    break;
            }
        }
        private static void ButtonEdit_DoubleClick(object sender, EventArgs e)
        {
            SecimYap();
        }
        private static void Tablo_KeyDown(object sender, KeyEventArgs e)
        {
            if (_tablo.FocusedColumn.ColumnEdit == null) return;

            var type = _tablo.FocusedColumn.ColumnEdit.GetType();
            if (type != typeof(RepositoryItemButtonEdit)) return;

            switch (e.KeyCode)
            {
                case Keys.Delete when e.Control && e.Shift:
                    _tablo.SetFocusedRowCellValue(_idColumn, null);
                    _tablo.SetFocusedRowCellValue(_nameColumn, null);
                    _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
                    break;
                case Keys.F4:
                case Keys.Down when e.Alt:
                    SecimYap();
                    break;
            }
        }
        private static void SecimYap()
        {
            switch (_buttonEdit.Name)
            {
                case "repositoryYakinlik":
                    {
                        var id = _tablo.GetRowCellId(_idColumn);//.GetRowCellValue(_tablo.FocusedRowHandle, _idColumn);
                        var entity = (Yakinlik)ShowListForms<YakinlikListForm>.ShowDialogListForm(kartTuru: KartTuru.Yakinlik,id);
                        if (entity != null)
                        {
                            _tablo.SetFocusedRowCellValue(_idColumn, entity.Id);
                            _tablo.SetFocusedRowCellValue(_nameColumn, entity.YakinlikAdi);
                            _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
                        }
                    }
                    break;
                case "repositoryBanka":
                    {
                        var id = _tablo.GetRowCellId(_idColumn);//.GetRowCellValue(_tablo.FocusedRowHandle, _idColumn);
                        var entity = (BankaL)ShowListForms<BankaListForm>.ShowDialogListForm(kartTuru: KartTuru.Banka, id);
                        if (entity != null)
                        {
                            _tablo.SetFocusedRowCellValue(_idColumn, entity.Id);
                            _tablo.SetFocusedRowCellValue(_nameColumn, entity.BankaAdi);
                            _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
                        }
                    }
                    break;
                case "repositoryIptalNedeni":
                    {
                        var id = _tablo.GetRowCellId(_idColumn);//.GetRowCellValue(_tablo.FocusedRowHandle, _idColumn);
                        var entity = (IptalNedeni)ShowListForms<IptalNedeniListForm>.ShowDialogListForm(kartTuru: KartTuru.IptalNedeni, id);
                        if (entity != null)
                        {
                            _tablo.SetFocusedRowCellValue(_idColumn, entity.Id);
                            _tablo.SetFocusedRowCellValue(_nameColumn, entity.IptalNedeniAdi);
                            _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
                        }
                    }
                    break;
                case "repositoryGittigiOkul":
                    {
                        var id = _tablo.GetRowCellId(_idColumn);//.GetRowCellValue(_tablo.FocusedRowHandle, _idColumn);
                        var entity = (OkulL)ShowListForms<OkulListForm>.ShowDialogListForm(kartTuru: KartTuru.Okul, id);
                        if (entity != null)
                        {
                            _tablo.SetFocusedRowCellValue(_idColumn, entity.Id);
                            _tablo.SetFocusedRowCellValue(_nameColumn, entity.OkulAdi);
                            _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
                        }
                    }
                    break;
            }
        }
    }
}