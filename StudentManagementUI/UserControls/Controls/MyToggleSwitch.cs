using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using StudentManagementUI.Abstract;

namespace StudentManagementUI.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyToggleSwitch:ToggleSwitch,IStatusBarDescription
    {
        public MyToggleSwitch()
        {
            Name = "tglState";
            Properties.OnText = "Active";
            Properties.OffText = "Passive";
            Properties.AutoHeight = false;
            Properties.AutoWidth = true;
            IsOn = true;
            Properties.GlyphAlignment = HorzAlignment.Far;
            Properties.Appearance.ForeColor = Color.Maroon;
        }

        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarDescription { get; set; } = "Choose the state of record";
    }
}
