﻿namespace StudentManagementUI.Forms.BaseForms
{
    partial class BaseListForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseListForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnNew = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnSelect = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnFilter = new DevExpress.XtraBars.BarButtonItem();
            this.btnColumns = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
            this.btnSend = new DevExpress.XtraBars.BarSubItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.barNew = new DevExpress.XtraBars.BarStaticItem();
            this.barNewDescription = new DevExpress.XtraBars.BarStaticItem();
            this.barDelete = new DevExpress.XtraBars.BarStaticItem();
            this.barDeleteDescription = new DevExpress.XtraBars.BarStaticItem();
            this.barSelect = new DevExpress.XtraBars.BarStaticItem();
            this.barSelectDescription = new DevExpress.XtraBars.BarStaticItem();
            this.barEdit = new DevExpress.XtraBars.BarStaticItem();
            this.barEditDescription = new DevExpress.XtraBars.BarStaticItem();
            this.barRefresh = new DevExpress.XtraBars.BarStaticItem();
            this.barRefreshDescription = new DevExpress.XtraBars.BarStaticItem();
            this.barFilter = new DevExpress.XtraBars.BarStaticItem();
            this.barFilterDescription = new DevExpress.XtraBars.BarStaticItem();
            this.barColumns = new DevExpress.XtraBars.BarStaticItem();
            this.barColumnsDescription = new DevExpress.XtraBars.BarStaticItem();
            this.barPrint = new DevExpress.XtraBars.BarStaticItem();
            this.barPrintDescription = new DevExpress.XtraBars.BarStaticItem();
            this.barSend = new DevExpress.XtraBars.BarStaticItem();
            this.barSendDescription = new DevExpress.XtraBars.BarStaticItem();
            this.barExit = new DevExpress.XtraBars.BarStaticItem();
            this.barExitDescription = new DevExpress.XtraBars.BarStaticItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.DrawGroupCaptions = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.DrawGroupsBorderMode = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnNew,
            this.btnDelete,
            this.btnSelect,
            this.btnRefresh,
            this.btnFilter,
            this.btnColumns,
            this.btnPrint,
            this.btnSend,
            this.btnExit,
            this.btnEdit,
            this.barNew,
            this.barNewDescription,
            this.barDelete,
            this.barDeleteDescription,
            this.barSelect,
            this.barSelectDescription,
            this.barEdit,
            this.barEditDescription,
            this.barRefresh,
            this.barRefreshDescription,
            this.barFilter,
            this.barFilterDescription,
            this.barColumns,
            this.barColumnsDescription,
            this.barPrint,
            this.barPrintDescription,
            this.barSend,
            this.barSendDescription,
            this.barExit,
            this.barExitDescription});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 32;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbon.ShowQatLocationSelector = false;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(1527, 102);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            this.ribbon.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // btnNew
            // 
            this.btnNew.Caption = "New";
            this.btnNew.Id = 1;
            this.btnNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.ImageOptions.Image")));
            this.btnNew.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNew.ImageOptions.LargeImage")));
            this.btnNew.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Insert);
            this.btnNew.Name = "btnNew";
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Delete";
            this.btnDelete.Id = 2;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.LargeImage")));
            this.btnDelete.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Delete);
            this.btnDelete.Name = "btnDelete";
            // 
            // btnSelect
            // 
            this.btnSelect.Caption = "Select";
            this.btnSelect.Id = 3;
            this.btnSelect.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSelect.ImageOptions.Image")));
            this.btnSelect.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSelect.ImageOptions.LargeImage")));
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.ShortcutKeyDisplayString = "Enter";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Refresh";
            this.btnRefresh.Id = 4;
            this.btnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.Image")));
            this.btnRefresh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.LargeImage")));
            this.btnRefresh.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.btnRefresh.Name = "btnRefresh";
            // 
            // btnFilter
            // 
            this.btnFilter.Caption = "Filter";
            this.btnFilter.Id = 5;
            this.btnFilter.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFilter.ImageOptions.Image")));
            this.btnFilter.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnFilter.ImageOptions.LargeImage")));
            this.btnFilter.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F8);
            this.btnFilter.Name = "btnFilter";
            // 
            // btnColumns
            // 
            this.btnColumns.Caption = "Columns";
            this.btnColumns.Id = 6;
            this.btnColumns.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnColumns.ImageOptions.Image")));
            this.btnColumns.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnColumns.ImageOptions.LargeImage")));
            this.btnColumns.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O));
            this.btnColumns.Name = "btnColumns";
            // 
            // btnPrint
            // 
            this.btnPrint.Caption = "Print";
            this.btnPrint.Id = 7;
            this.btnPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.ImageOptions.Image")));
            this.btnPrint.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPrint.ImageOptions.LargeImage")));
            this.btnPrint.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P));
            this.btnPrint.Name = "btnPrint";
            // 
            // btnSend
            // 
            this.btnSend.Caption = "Send";
            this.btnSend.Id = 8;
            this.btnSend.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSend.ImageOptions.Image")));
            this.btnSend.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSend.ImageOptions.LargeImage")));
            this.btnSend.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F12);
            this.btnSend.Name = "btnSend";
            // 
            // btnExit
            // 
            this.btnExit.Caption = "Exit";
            this.btnExit.Id = 9;
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.LargeImage")));
            this.btnExit.Name = "btnExit";
            this.btnExit.ShortcutKeyDisplayString = "Esc";
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "Edit";
            this.btnEdit.Id = 10;
            this.btnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.Image")));
            this.btnEdit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.LargeImage")));
            this.btnEdit.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F3);
            this.btnEdit.Name = "btnEdit";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNew);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDelete);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSelect);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnRefresh);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnFilter);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnColumns);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnPrint);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSend);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnExit);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.barNew);
            this.ribbonStatusBar.ItemLinks.Add(this.barNewDescription);
            this.ribbonStatusBar.ItemLinks.Add(this.barDelete, true);
            this.ribbonStatusBar.ItemLinks.Add(this.barDeleteDescription);
            this.ribbonStatusBar.ItemLinks.Add(this.barSelect, true);
            this.ribbonStatusBar.ItemLinks.Add(this.barSelectDescription);
            this.ribbonStatusBar.ItemLinks.Add(this.barEdit, true);
            this.ribbonStatusBar.ItemLinks.Add(this.barEditDescription);
            this.ribbonStatusBar.ItemLinks.Add(this.barRefresh, true);
            this.ribbonStatusBar.ItemLinks.Add(this.barRefreshDescription);
            this.ribbonStatusBar.ItemLinks.Add(this.barFilter, true);
            this.ribbonStatusBar.ItemLinks.Add(this.barFilterDescription);
            this.ribbonStatusBar.ItemLinks.Add(this.barColumns, true);
            this.ribbonStatusBar.ItemLinks.Add(this.barColumnsDescription);
            this.ribbonStatusBar.ItemLinks.Add(this.barPrint, true);
            this.ribbonStatusBar.ItemLinks.Add(this.barPrintDescription);
            this.ribbonStatusBar.ItemLinks.Add(this.barSend, true);
            this.ribbonStatusBar.ItemLinks.Add(this.barSendDescription);
            this.ribbonStatusBar.ItemLinks.Add(this.barExit, true);
            this.ribbonStatusBar.ItemLinks.Add(this.barExitDescription);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 437);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1527, 31);
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "DevExpress Style";
            // 
            // barNew
            // 
            this.barNew.Caption = "Insert :";
            this.barNew.Id = 11;
            this.barNew.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.barNew.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DarkBlue;
            this.barNew.ItemAppearance.Normal.Options.UseFont = true;
            this.barNew.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barNew.Name = "barNew";
            // 
            // barNewDescription
            // 
            this.barNewDescription.Caption = "New";
            this.barNewDescription.Id = 12;
            this.barNewDescription.Name = "barNewDescription";
            // 
            // barDelete
            // 
            this.barDelete.Caption = "Delete :";
            this.barDelete.Id = 13;
            this.barDelete.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.barDelete.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DarkBlue;
            this.barDelete.ItemAppearance.Normal.Options.UseFont = true;
            this.barDelete.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barDelete.Name = "barDelete";
            // 
            // barDeleteDescription
            // 
            this.barDeleteDescription.Caption = "Remove";
            this.barDeleteDescription.Id = 14;
            this.barDeleteDescription.Name = "barDeleteDescription";
            // 
            // barSelect
            // 
            this.barSelect.Caption = "Enter :";
            this.barSelect.Id = 15;
            this.barSelect.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.barSelect.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DarkBlue;
            this.barSelect.ItemAppearance.Normal.Options.UseFont = true;
            this.barSelect.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barSelect.Name = "barSelect";
            // 
            // barSelectDescription
            // 
            this.barSelectDescription.Caption = "Select";
            this.barSelectDescription.Id = 17;
            this.barSelectDescription.Name = "barSelectDescription";
            // 
            // barEdit
            // 
            this.barEdit.Caption = "F3 :";
            this.barEdit.Id = 18;
            this.barEdit.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.barEdit.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DarkBlue;
            this.barEdit.ItemAppearance.Normal.Options.UseFont = true;
            this.barEdit.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barEdit.Name = "barEdit";
            // 
            // barEditDescription
            // 
            this.barEditDescription.Caption = "Edit";
            this.barEditDescription.Id = 19;
            this.barEditDescription.Name = "barEditDescription";
            // 
            // barRefresh
            // 
            this.barRefresh.Caption = "F5 :";
            this.barRefresh.Id = 20;
            this.barRefresh.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.barRefresh.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DarkBlue;
            this.barRefresh.ItemAppearance.Normal.Options.UseFont = true;
            this.barRefresh.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barRefresh.Name = "barRefresh";
            // 
            // barRefreshDescription
            // 
            this.barRefreshDescription.Caption = "Refresh";
            this.barRefreshDescription.Id = 21;
            this.barRefreshDescription.Name = "barRefreshDescription";
            // 
            // barFilter
            // 
            this.barFilter.Caption = "F8 :";
            this.barFilter.Id = 22;
            this.barFilter.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.barFilter.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DarkBlue;
            this.barFilter.ItemAppearance.Normal.Options.UseFont = true;
            this.barFilter.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barFilter.Name = "barFilter";
            // 
            // barFilterDescription
            // 
            this.barFilterDescription.Caption = "Filter";
            this.barFilterDescription.Id = 23;
            this.barFilterDescription.Name = "barFilterDescription";
            // 
            // barColumns
            // 
            this.barColumns.Caption = "Ctrl+O :";
            this.barColumns.Id = 24;
            this.barColumns.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.barColumns.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DarkBlue;
            this.barColumns.ItemAppearance.Normal.Options.UseFont = true;
            this.barColumns.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barColumns.Name = "barColumns";
            // 
            // barColumnsDescription
            // 
            this.barColumnsDescription.Caption = "Columns";
            this.barColumnsDescription.Id = 25;
            this.barColumnsDescription.Name = "barColumnsDescription";
            // 
            // barPrint
            // 
            this.barPrint.Caption = "Ctrl+P :";
            this.barPrint.Id = 26;
            this.barPrint.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.barPrint.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DarkBlue;
            this.barPrint.ItemAppearance.Normal.Options.UseFont = true;
            this.barPrint.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barPrint.Name = "barPrint";
            // 
            // barPrintDescription
            // 
            this.barPrintDescription.Caption = "Print";
            this.barPrintDescription.Id = 27;
            this.barPrintDescription.Name = "barPrintDescription";
            // 
            // barSend
            // 
            this.barSend.Caption = "F12 :";
            this.barSend.Id = 28;
            this.barSend.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.barSend.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DarkBlue;
            this.barSend.ItemAppearance.Normal.Options.UseFont = true;
            this.barSend.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barSend.Name = "barSend";
            // 
            // barSendDescription
            // 
            this.barSendDescription.Caption = "Send";
            this.barSendDescription.Id = 29;
            this.barSendDescription.Name = "barSendDescription";
            // 
            // barExit
            // 
            this.barExit.Caption = "Esc :";
            this.barExit.Id = 30;
            this.barExit.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.barExit.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DarkBlue;
            this.barExit.ItemAppearance.Normal.Options.UseFont = true;
            this.barExit.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barExit.Name = "barExit";
            // 
            // barExitDescription
            // 
            this.barExitDescription.Caption = "Exit";
            this.barExitDescription.Id = 31;
            this.barExitDescription.Name = "barExitDescription";
            // 
            // BaseListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1527, 468);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IconOptions.ShowIcon = false;
            this.MinimizeBox = false;
            this.Name = "BaseListForm";
            this.Ribbon = this.ribbon;
            this.ShowInTaskbar = false;
            this.StatusBar = this.ribbonStatusBar;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnNew;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnSelect;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnFilter;
        private DevExpress.XtraBars.BarButtonItem btnColumns;
        private DevExpress.XtraBars.BarButtonItem btnPrint;
        protected DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.BarSubItem btnSend;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
        private DevExpress.XtraBars.BarStaticItem barNew;
        private DevExpress.XtraBars.BarStaticItem barNewDescription;
        private DevExpress.XtraBars.BarStaticItem barDelete;
        private DevExpress.XtraBars.BarStaticItem barDeleteDescription;
        private DevExpress.XtraBars.BarStaticItem barSelect;
        private DevExpress.XtraBars.BarStaticItem barSelectDescription;
        private DevExpress.XtraBars.BarStaticItem barEdit;
        private DevExpress.XtraBars.BarStaticItem barEditDescription;
        private DevExpress.XtraBars.BarStaticItem barRefresh;
        private DevExpress.XtraBars.BarStaticItem barRefreshDescription;
        private DevExpress.XtraBars.BarStaticItem barFilter;
        private DevExpress.XtraBars.BarStaticItem barFilterDescription;
        private DevExpress.XtraBars.BarStaticItem barColumns;
        private DevExpress.XtraBars.BarStaticItem barColumnsDescription;
        private DevExpress.XtraBars.BarStaticItem barPrint;
        private DevExpress.XtraBars.BarStaticItem barPrintDescription;
        private DevExpress.XtraBars.BarStaticItem barSend;
        private DevExpress.XtraBars.BarStaticItem barSendDescription;
        private DevExpress.XtraBars.BarStaticItem barExit;
        private DevExpress.XtraBars.BarStaticItem barExitDescription;
    }
}