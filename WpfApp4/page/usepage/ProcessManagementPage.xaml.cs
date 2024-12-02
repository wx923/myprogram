using System;
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
using System.Windows.Threading;
using System.Collections.ObjectModel;
using static WpfApp4.page.usepage.ProcessMonitoringPage;
using static MaterialDesignThemes.Wpf.Theme;

namespace WpfApp4.page.usepage
{
    /// <summary>
    /// Page6.xaml 的交互逻辑
    /// </summary>
    public partial class ProcessManagementPage : Page
    {
        public ObservableCollection<SensorData> DataCollection { get; set; }
        public ProcessManagementPage()
        {
            InitializeComponent();
            InitializeComponent();
            DataCollection = new ObservableCollection<SensorData>();
            myDataGrid.ItemsSource = DataCollection;

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(2);
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            DataCollection.Add(new SensorData
            {
                Time = DateTime.Now.ToString("HH:mm:ss"),
                Temperature = $"{new Random().Next(20, 30)}°C",
                Humidity = $"{new Random().Next(40, 70)}%"
            });
        }
        public class SensorData
        {
            public string Time { get; set; }
            public string Temperature { get; set; }
            public string Humidity { get; set; }
        }
    }
}
