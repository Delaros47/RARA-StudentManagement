using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagementUI.Forms.SchoolForms;

namespace StudentManagementUI.Forms.MainForms
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
            EventsLoad();
        }

        private void EventsLoad()
        {
            foreach (var item in ribbon.Items)
            {
                switch (item)
                {
                    case BarButtonItem button:
                        button.ItemClick += Button_ItemClick;
                        break;
                }
            }
        }

        private void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item==btnSchools)
            {
                SchoolListForm schoolListForm = new SchoolListForm();
                schoolListForm.MdiParent = ActiveForm;
                schoolListForm.Show();
            }
        }
    }
}