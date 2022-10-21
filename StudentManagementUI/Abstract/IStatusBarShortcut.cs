using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementUI.Abstract
{
    public interface IStatusBarShortcut:IStatusBarDescription
    {
        public string StatusBarShortcut { get; set; }
        public string StatusBarShortcutDescription { get; set; }
    }
}
