﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using StudentManagementUI.Abstract;

namespace StudentManagementUI.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyCheckedComboBoxEdit:CheckedComboBoxEdit,IStatusBarShortcut
    {
        public MyCheckedComboBoxEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
        }

        public override bool EnterMoveNextControl { get; set; } = true;

        public string StatusBarDescription { get; set; }
        public string StatusBarShortcut { get; set; } = "F4 :";
        public string StatusBarShortcutDescription { get; set; }
    }
}
