using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using StudentManagementUI.Abstract;

namespace StudentManagementUI.UserControls.Grids
{
    [ToolboxItem(true)]
    public class MyBandedGridControl : GridControl
    {
        protected override BaseView CreateDefaultView()
        {
            var view = (BandedGridView)CreateView("MyBandedGridView");

            view.BandPanelRowHeight = 40;
            view.Appearance.BandPanel.ForeColor = Color.DarkBlue;
            view.Appearance.BandPanel.TextOptions.HAlignment = HorzAlignment.Center;
            view.Appearance.BandPanel.Font = new Font(new FontFamily("Tahoma"), 8.25F, FontStyle.Bold);

            view.Appearance.ViewCaption.ForeColor = Color.Maroon;
            view.Appearance.HeaderPanel.ForeColor = Color.Maroon;
            view.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center;

            view.Appearance.FooterPanel.ForeColor = Color.Maroon;
            view.Appearance.FooterPanel.Font = new Font(new FontFamily("Tahoma"), 8.25F, FontStyle.Bold);

            view.OptionsMenu.EnableColumnMenu = false;
            view.OptionsMenu.EnableFooterMenu = false;
            view.OptionsMenu.EnableGroupPanelMenu = false;

            view.OptionsNavigation.EnterMoveNextColumn = true;

            view.OptionsPrint.AutoWidth = false;
            view.OptionsPrint.PrintFooter = false;
            view.OptionsPrint.PrintGroupFooter = false;

            view.OptionsView.ShowViewCaption = true;
            view.OptionsView.ShowAutoFilterRow = true;
            view.OptionsView.ShowGroupPanel = false;
            view.OptionsView.ColumnAutoWidth = false;
            view.OptionsView.RowAutoHeight = true;
            view.OptionsView.HeaderFilterButtonShowMode = FilterButtonShowMode.Button;

            var idColumn = new MyBandedGridColumn();
            idColumn.Caption = "Id";
            idColumn.FieldName = "Id";
            idColumn.OptionsColumn.AllowEdit = false;
            idColumn.OptionsColumn.ShowInCustomizationForm = false;
            view.Columns.Add(idColumn);

            var privateCode = new MyBandedGridColumn();
            privateCode.Caption = "Private Code";
            privateCode.FieldName = "PrivateCode";
            privateCode.Visible = true;
            privateCode.OptionsColumn.AllowEdit = false;
            privateCode.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
            privateCode.AppearanceCell.Options.UseTextOptions = true;
            view.Columns.Add(privateCode);

            return view;


        }

        protected override void RegisterAvailableViewsCore(InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new MyBandedGridInfoRegistrator());
        }

        private class MyBandedGridInfoRegistrator : BandedGridInfoRegistrator
        {
            public override string ViewName { get; } = "MyBandedGridView";
            public override BaseView CreateView(GridControl grid)
            {
                return new MyBandedGridView(grid);
            }
        }
    }

    public class MyBandedGridView : BandedGridView, IStatusBarShortcut
    {
        public MyBandedGridView() { }
        public MyBandedGridView(GridControl ownerGrid) : base(ownerGrid) { }

        protected override void OnColumnChangedCore(GridColumn column)
        {
            base.OnColumnChangedCore(column);
            if (column.ColumnEdit == null) return;
            if (column.ColumnEdit.GetType() == typeof(RepositoryItemDateEdit))
            {
                column.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
                ((RepositoryItemDateEdit)column.ColumnEdit).Mask.MaskType = MaskType.DateTimeAdvancingCaret;
            }
        }

        protected override GridColumnCollection CreateColumnCollection()
        {
            return new MyGridColumnCollection(this);
        }


        private class MyGridColumnCollection : BandedGridColumnCollection
        {
            public MyGridColumnCollection(ColumnView view) : base(view) { }

            protected override GridColumn CreateColumn()
            {
                var column = new MyBandedGridColumn();
                column.OptionsColumn.AllowEdit = false;
                return column;
            }
        }

        public string StatusBarDescription { get; set; }
        public string StatusBarShortcut { get; set; }
        public string StatusBarShortcutDescription { get; set; }
    }


    public class MyBandedGridColumn : BandedGridColumn, IStatusBarShortcut
    {



        public string StatusBarDescription { get; set; }
        public string StatusBarShortcut { get; set; }
        public string StatusBarShortcutDescription { get; set; }
    }

}
