using System;
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
    public class MyButtonEdit : ButtonEdit, IStatusBarShortcut
    {
        public MyButtonEdit()
        {
            Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
        }

        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarDescription { get; set; }
        public string StatusBarShortcut { get; set; } = "F4 :";
        public string StatusBarShortcutDescription { get; set; }

        public int _id { get; set; }
        [Browsable(false)]
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                var oldValue = _id;
                var newValue = value;
                if (oldValue == newValue) return;
                _id = value;
                if (IdChanged != null)
                    IdChanged(this, new IdChangedEventArgs(oldValue, newValue));
            }

        }


        public event EventHandler<IdChangedEventArgs> IdChanged;


    }

    public class IdChangedEventArgs : EventArgs
    {
        public int OldValue { get; }
        public int NewValue { get; }

        public IdChangedEventArgs(int oldValue, int newValue)
        {
            OldValue = oldValue;
            NewValue = newValue;
        }
    }
}
