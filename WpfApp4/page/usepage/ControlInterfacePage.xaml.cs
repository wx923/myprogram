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
using WpfApp4.ViewModel;

namespace WpfApp4.page.usepage
{
    /// <summary>
    /// Page3.xaml 的交互逻辑
    /// </summary>
    public partial class ControlInterfacePage : Page
    {
        public ControlInterfacePage()
        {
            InitializeComponent();
            this.DataContext =GlobalVM.SingleObject;
        }
    }
}
