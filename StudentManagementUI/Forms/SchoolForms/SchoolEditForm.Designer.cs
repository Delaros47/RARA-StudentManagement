namespace StudentManagementUI.Forms.SchoolForms
{
    partial class SchoolEditForm
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
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition4 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition5 = new DevExpress.XtraLayout.RowDefinition();
            this.myDataLayoutControl1 = new StudentManagementUI.UserControls.Controls.MyDataLayoutControl();
            this.myMemoEdit1 = new StudentManagementUI.UserControls.Controls.MyMemoEdit();
            this.myToggleSwitch1 = new StudentManagementUI.UserControls.Controls.MyToggleSwitch();
            this.myButtonEdit2 = new StudentManagementUI.UserControls.Controls.MyButtonEdit();
            this.myButtonEdit1 = new StudentManagementUI.UserControls.Controls.MyButtonEdit();
            this.myTextEdit1 = new StudentManagementUI.UserControls.Controls.MyTextEdit();
            this.myPrivateCodeTextEdit1 = new StudentManagementUI.UserControls.Controls.MyPrivateCodeTextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).BeginInit();
            this.myDataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myMemoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myToggleSwitch1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myButtonEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myButtonEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTextEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPrivateCodeTextEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            // 
            // 
            // 
            this.ribbon.SearchEditItem.AccessibleName = "Search Item";
            this.ribbon.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.ribbon.SearchEditItem.EditWidth = 150;
            this.ribbon.SearchEditItem.Id = -5000;
            this.ribbon.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ribbon.Size = new System.Drawing.Size(340, 102);
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // myDataLayoutControl1
            // 
            this.myDataLayoutControl1.Controls.Add(this.myMemoEdit1);
            this.myDataLayoutControl1.Controls.Add(this.myToggleSwitch1);
            this.myDataLayoutControl1.Controls.Add(this.myButtonEdit2);
            this.myDataLayoutControl1.Controls.Add(this.myButtonEdit1);
            this.myDataLayoutControl1.Controls.Add(this.myTextEdit1);
            this.myDataLayoutControl1.Controls.Add(this.myPrivateCodeTextEdit1);
            this.myDataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataLayoutControl1.Location = new System.Drawing.Point(0, 102);
            this.myDataLayoutControl1.Name = "myDataLayoutControl1";
            this.myDataLayoutControl1.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl1.Root = this.Root;
            this.myDataLayoutControl1.Size = new System.Drawing.Size(340, 164);
            this.myDataLayoutControl1.TabIndex = 2;
            this.myDataLayoutControl1.Text = "myDataLayoutControl1";
            // 
            // myMemoEdit1
            // 
            this.myMemoEdit1.EnterMoveNextControl = true;
            this.myMemoEdit1.Location = new System.Drawing.Point(84, 108);
            this.myMemoEdit1.MenuManager = this.ribbon;
            this.myMemoEdit1.Name = "myMemoEdit1";
            this.myMemoEdit1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.myMemoEdit1.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.myMemoEdit1.Properties.MaxLength = 500;
            this.myMemoEdit1.Size = new System.Drawing.Size(244, 44);
            this.myMemoEdit1.StatusBarDescription = "Enter the description";
            this.myMemoEdit1.StyleController = this.myDataLayoutControl1;
            this.myMemoEdit1.TabIndex = 9;
            // 
            // myToggleSwitch1
            // 
            this.myToggleSwitch1.EditValue = true;
            this.myToggleSwitch1.EnterMoveNextControl = true;
            this.myToggleSwitch1.Location = new System.Drawing.Point(222, 12);
            this.myToggleSwitch1.MenuManager = this.ribbon;
            this.myToggleSwitch1.Name = "myToggleSwitch1";
            this.myToggleSwitch1.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.myToggleSwitch1.Properties.Appearance.Options.UseForeColor = true;
            this.myToggleSwitch1.Properties.AutoHeight = false;
            this.myToggleSwitch1.Properties.AutoWidth = true;
            this.myToggleSwitch1.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.myToggleSwitch1.Properties.OffText = "Passive";
            this.myToggleSwitch1.Properties.OnText = "Active";
            this.myToggleSwitch1.Size = new System.Drawing.Size(109, 20);
            this.myToggleSwitch1.StatusBarDescription = "Choose the state of record";
            this.myToggleSwitch1.StyleController = this.myDataLayoutControl1;
            this.myToggleSwitch1.TabIndex = 8;
            // 
            // myButtonEdit2
            // 
            this.myButtonEdit2._id = 0;
            this.myButtonEdit2.EnterMoveNextControl = true;
            this.myButtonEdit2.Id = 0;
            this.myButtonEdit2.Location = new System.Drawing.Point(84, 84);
            this.myButtonEdit2.MenuManager = this.ribbon;
            this.myButtonEdit2.Name = "myButtonEdit2";
            this.myButtonEdit2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.myButtonEdit2.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.myButtonEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.myButtonEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.myButtonEdit2.Size = new System.Drawing.Size(124, 20);
            this.myButtonEdit2.StatusBarDescription = null;
            this.myButtonEdit2.StatusBarShortcut = "F4 :";
            this.myButtonEdit2.StatusBarShortcutDescription = null;
            this.myButtonEdit2.StyleController = this.myDataLayoutControl1;
            this.myButtonEdit2.TabIndex = 7;
            // 
            // myButtonEdit1
            // 
            this.myButtonEdit1._id = 0;
            this.myButtonEdit1.EnterMoveNextControl = true;
            this.myButtonEdit1.Id = 0;
            this.myButtonEdit1.Location = new System.Drawing.Point(84, 60);
            this.myButtonEdit1.MenuManager = this.ribbon;
            this.myButtonEdit1.Name = "myButtonEdit1";
            this.myButtonEdit1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.myButtonEdit1.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.myButtonEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.myButtonEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.myButtonEdit1.Size = new System.Drawing.Size(124, 20);
            this.myButtonEdit1.StatusBarDescription = null;
            this.myButtonEdit1.StatusBarShortcut = "F4 :";
            this.myButtonEdit1.StatusBarShortcutDescription = null;
            this.myButtonEdit1.StyleController = this.myDataLayoutControl1;
            this.myButtonEdit1.TabIndex = 6;
            // 
            // myTextEdit1
            // 
            this.myTextEdit1.EnterMoveNextControl = true;
            this.myTextEdit1.Location = new System.Drawing.Point(84, 36);
            this.myTextEdit1.MenuManager = this.ribbon;
            this.myTextEdit1.Name = "myTextEdit1";
            this.myTextEdit1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.myTextEdit1.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.myTextEdit1.Properties.MaxLength = 50;
            this.myTextEdit1.Size = new System.Drawing.Size(244, 20);
            this.myTextEdit1.StatusBarDescription = null;
            this.myTextEdit1.StyleController = this.myDataLayoutControl1;
            this.myTextEdit1.TabIndex = 5;
            // 
            // myPrivateCodeTextEdit1
            // 
            this.myPrivateCodeTextEdit1.EnterMoveNextControl = true;
            this.myPrivateCodeTextEdit1.Location = new System.Drawing.Point(84, 12);
            this.myPrivateCodeTextEdit1.MenuManager = this.ribbon;
            this.myPrivateCodeTextEdit1.Name = "myPrivateCodeTextEdit1";
            this.myPrivateCodeTextEdit1.Properties.Appearance.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.myPrivateCodeTextEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.myPrivateCodeTextEdit1.Properties.Appearance.Options.UseTextOptions = true;
            this.myPrivateCodeTextEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.myPrivateCodeTextEdit1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.myPrivateCodeTextEdit1.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.myPrivateCodeTextEdit1.Properties.MaxLength = 30;
            this.myPrivateCodeTextEdit1.Size = new System.Drawing.Size(124, 20);
            this.myPrivateCodeTextEdit1.StatusBarDescription = "Enter the Private Code";
            this.myPrivateCodeTextEdit1.StyleController = this.myDataLayoutControl1;
            this.myPrivateCodeTextEdit1.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.Root.Name = "Root";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition1.Width = 200D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition2.Width = 100D;
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition3.Width = 110D;
            this.Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2,
            columnDefinition3});
            rowDefinition1.Height = 24D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition2.Height = 24D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition3.Height = 24D;
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition4.Height = 24D;
            rowDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition5.Height = 24D;
            rowDefinition5.SizeType = System.Windows.Forms.SizeType.Percent;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3,
            rowDefinition4,
            rowDefinition5});
            this.Root.Size = new System.Drawing.Size(340, 164);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.myPrivateCodeTextEdit1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem1.Text = "Private Code";
            this.layoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(62, 13);
            this.layoutControlItem1.TextToControlDistance = 10;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.myTextEdit1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.ColumnSpan = 3;
            this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(320, 24);
            this.layoutControlItem2.Text = "School Name";
            this.layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(62, 13);
            this.layoutControlItem2.TextToControlDistance = 10;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem3.Control = this.myButtonEdit1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem3.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem3.Text = "City Name";
            this.layoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(62, 13);
            this.layoutControlItem3.TextToControlDistance = 10;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem4.Control = this.myButtonEdit2;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 3;
            this.layoutControlItem4.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem4.Text = "Distict Name";
            this.layoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(62, 13);
            this.layoutControlItem4.TextToControlDistance = 10;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem5.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem5.Control = this.myToggleSwitch1;
            this.layoutControlItem5.Location = new System.Drawing.Point(210, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.OptionsTableLayoutItem.ColumnIndex = 2;
            this.layoutControlItem5.Size = new System.Drawing.Size(110, 24);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem6.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem6.Control = this.myMemoEdit1;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.OptionsTableLayoutItem.ColumnSpan = 3;
            this.layoutControlItem6.OptionsTableLayoutItem.RowIndex = 4;
            this.layoutControlItem6.Size = new System.Drawing.Size(320, 48);
            this.layoutControlItem6.Text = "Description";
            this.layoutControlItem6.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(62, 13);
            this.layoutControlItem6.TextToControlDistance = 10;
            // 
            // SchoolEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 299);
            this.Controls.Add(this.myDataLayoutControl1);
            this.IconOptions.ShowIcon = false;
            this.Name = "SchoolEditForm";
            this.Text = "School Edit";
            this.Controls.SetChildIndex(this.ribbon, 0);
            this.Controls.SetChildIndex(this.myDataLayoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).EndInit();
            this.myDataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myMemoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myToggleSwitch1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myButtonEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myButtonEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTextEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPrivateCodeTextEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Controls.MyDataLayoutControl myDataLayoutControl1;
        private UserControls.Controls.MyMemoEdit myMemoEdit1;
        private UserControls.Controls.MyToggleSwitch myToggleSwitch1;
        private UserControls.Controls.MyButtonEdit myButtonEdit2;
        private UserControls.Controls.MyButtonEdit myButtonEdit1;
        private UserControls.Controls.MyTextEdit myTextEdit1;
        private UserControls.Controls.MyPrivateCodeTextEdit myPrivateCodeTextEdit1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}