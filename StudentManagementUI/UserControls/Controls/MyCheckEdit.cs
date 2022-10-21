﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using StudentManagementUI.Abstract;

namespace StudentManagementUI.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyCheckEdit:CheckEdit,IStatusBarDescription
    {
        public MyCheckEdit()
        {
            Properties.Appearance.BackColor = Color.Transparent;
        }

        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarDescription { get; set; }
    }
}
