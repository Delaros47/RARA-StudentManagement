﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraDataLayout;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;

namespace StudentManagementUI.UserControls.Controls
{
    public class MyDataLayoutControl:DataLayoutControl
    {
        public MyDataLayoutControl()
        {
            OptionsFocus.EnableAutoTabOrder = false;
        }

        protected override LayoutControlImplementor CreateILayoutControlImplementorCore()
        {
            return new MyCreateILayoutControlImplementorCore(this);
        }

        
    }

    internal class MyCreateILayoutControlImplementorCore : LayoutControlImplementor
    {
        public MyCreateILayoutControlImplementorCore(ILayoutControlOwner controlOwner) : base(controlOwner)
        {

        }

        public override BaseLayoutItem CreateLayoutItem(LayoutGroup parent)
        {
            var item = base.CreateLayoutItem(parent);
            item.AppearanceItemCaption.ForeColor = Color.Maroon;
            return item;
        }

        public override LayoutGroup CreateLayoutGroup(LayoutGroup parent)
        {
            var group= base.CreateLayoutGroup(parent);
            group.LayoutMode = LayoutMode.Table;

            group.OptionsTableLayoutGroup.ColumnDefinitions[0].SizeType = SizeType.Absolute;
            group.OptionsTableLayoutGroup.ColumnDefinitions[0].Width = 210;
            group.OptionsTableLayoutGroup.ColumnDefinitions[1].SizeType = SizeType.Percent;
            group.OptionsTableLayoutGroup.ColumnDefinitions[1].Width = 100;
            group.OptionsTableLayoutGroup.ColumnDefinitions.Add(new ColumnDefinition{SizeType = SizeType.Absolute,Width = 110});

            group.OptionsTableLayoutGroup.RowDefinitions.Clear();

            for (int i = 1; i <=10; i++)
            {
                group.OptionsTableLayoutGroup.RowDefinitions.Add(new RowDefinition
                {
                    SizeType = SizeType.Absolute,
                    Height = 24
                });

                if (i+1!=10)
                {
                    continue;
                }
                else
                {
                    group.OptionsTableLayoutGroup.RowDefinitions.Add(new RowDefinition{Height = 24,SizeType = SizeType.Percent});
                    break;
                }

            }

            return group;
        }
    }
}
