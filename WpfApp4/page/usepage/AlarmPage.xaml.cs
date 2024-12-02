using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
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
    /// Page8.xaml 的交互逻辑
    /// </summary>

    public partial class MonitoringAlarmPage : Page
    {
        public MonitoringAlarmPage()
        {
            Console.WriteLine("123123");
            InitializeComponent();
            this.DataContext = new AlermVm();
            Console.WriteLine("123123");
        }
    }

    public class MyConvert : IValueConverter
    {
        public MyConvert()
        {

        }
        public object Convert(object value, Type target, object parameter, CultureInfo cluture)
        {
            if (value is bool)
            {
                return (bool)value ? Brushes.Green : Brushes.Red;
            }
            return Brushes.Red;
        }
        public object ConvertBack(object value, Type target, object parameter, CultureInfo cluture)
        {
            throw new NotImplementedException();
        }
    }
}
