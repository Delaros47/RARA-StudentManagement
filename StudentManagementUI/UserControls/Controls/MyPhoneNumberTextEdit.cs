﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Utils;
using DevExpress.XtraEditors.Mask;

namespace StudentManagementUI.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyPhoneNumberTextEdit:MyTextEdit
    {
        public MyPhoneNumberTextEdit()
        {
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            Properties.Mask.MaskType = MaskType.Regular;
            Properties.Mask.EditMask = @"(0\d?\d?\d?) \d?\d?\d? \d?\d? \d?\d?";
            Properties.Mask.AutoComplete = AutoCompleteType.None;
            StatusBarDescription = "Enter the Phone Number";
        }
    }
}
