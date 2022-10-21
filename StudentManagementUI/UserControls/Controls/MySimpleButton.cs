using System;
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
    public class MySimpleButton:SimpleButton,IStatusBarDescription
    {
        public MySimpleButton()
        {
            ForeColor = Color.Maroon;
            
        }
        
        
        public string StatusBarDescription { get; set; }
    }
}
