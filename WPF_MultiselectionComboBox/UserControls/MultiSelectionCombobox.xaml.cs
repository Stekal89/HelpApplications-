﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF_MultiselectionComboBox.Models;

namespace WPF_MultiselectionComboBox.UserControls
{
    /// <summary>
    /// Interaction logic for MultiSelectionCombobox.xaml
    /// </summary>
    public partial class MultiSelectionCombobox : UserControl
    {
        public List<CBXObject> ObjObjectList { get; set; }

        public MultiSelectionCombobox()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Bind List of defined Object to the Dropdown
        /// </summary>
        public void BindObjectToDropDown()
        {
            cbxMain.ItemsSource = ObjObjectList;
        }

        /// <summary>
        /// Bind List of defined Object to the Dropdown
        /// </summary>
        /// <param name="objObjects">List of defined Objects</param>
        public void BindObjectToDropDown(List<CBXObject> objObjects)
        {
            if (null != objObjects)
            {
                ObjObjectList = objObjects;
                cbxMain.ItemsSource = ObjObjectList;
            }
            else
            {
                cbxMain.ItemsSource = ObjObjectList;
            }
        }

        /// <summary>
        /// Handling of Selection gets changed in the ComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxMain_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //BindListBOX();

            //System.Threading.Tasks.Task.Run(() =>
            //{
            //    System.Threading.Thread.Sleep(1000);

            //    this.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Background, new Action(() =>
            //    {
            //        BindListBOX();
            //    }));
            //});
            //System.Diagnostics.Debugger.Break();
        }

        /// <summary>
        /// Handling of Text gets changed in the ComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxMain_TextChanged(object sender, TextChangedEventArgs e)
        {
            //cbxMain.ItemsSource = ObjObjectList;
            BindListBOX();
        }


        private void AllCheckbocx_CheckedAndUnchecked(object sender, RoutedEventArgs e)
        {
            BindListBOX();
        }

        private void BindListBOX()
        {
            string strCbxTest = null;
            //testListbox.Items.Clear();

            for (int i = 0; i < ObjObjectList.Count; i++)
            {
                if (ObjObjectList[i].ObjectStatus == true)
                {
                    //testListbox.Items.Add(ObjObjectList[i].ObjectName);
                    strCbxTest += $"{ObjObjectList[i].ObjectName}, ";
                }
            }

            if (!string.IsNullOrEmpty(strCbxTest))
            {
                strCbxTest = strCbxTest.TrimEnd(' ').TrimEnd(',');
            }
            cbxMain.Text = strCbxTest;
        }

        private void cbxMain_DropDownClosed(object sender, EventArgs e)
        {
            //System.Diagnostics.Debugger.Break();
            //BindListBOX();
            //cbxMain.IsDropDownOpen = true;
        }
    }
}
