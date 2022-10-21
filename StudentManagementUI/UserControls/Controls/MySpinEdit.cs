using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask;
using StudentManagementUI.Abstract;

namespace StudentManagementUI.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MySpinEdit:SpinEdit,IStatusBarShortcut
    {
        public MySpinEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.AllowNullInput = DefaultBoolean.False;
            Properties.Mask.MaskType = MaskType.Numeric;
            Properties.Mask.EditMask = "d";
        }

        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarDescription { get; set; }
        public string StatusBarShortcut { get; set; } = "F4 :";
        public string StatusBarShortcutDescription { get; set; }
    }
}
