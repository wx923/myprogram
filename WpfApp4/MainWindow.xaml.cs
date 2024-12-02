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
using WpfApp4.page.usepage;
using WpfApp4.page.tube;

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {   
        //定时器对象
        private DispatcherTimer _timer;
        //用于按钮状态切换
        private Button LastButtonUI;

        public MainWindow()
        {
            InitializeComponent();
            // 默认导航到 HomePage
            MainFrame.Navigate(new HomePage());
            LastButtonUI = BtnHome;
            LastButtonUI.Style = (Style)FindResource("TopNavigationSelectedButtonStyle");
            // 初始化时间显示
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromSeconds(1);
            _timer.Tick += Timer_Tick;
            _timer.Start();
        }

        //用于时间更新
        private void Timer_Tick(object sender, EventArgs e)
        {
            // 更新时间显示
            TimeTextBlock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        //使用页面路由跳转
    private void NavigateToParameterSettingPage(object sender, RoutedEventArgs e)
    {
            MainFrame.Navigate(new ParameterSettingPage());
            LastButtonUI.Style = (Style)FindResource("TopNavigationButtonStyle");
            LastButtonUI = BtnParameterSetting;
            BtnParameterSetting.Style = (Style)FindResource("TopNavigationSelectedButtonStyle");
    }

    private void NavigateToMotionControlPage(object sender, RoutedEventArgs e)
    {
        MainFrame.Navigate(new MotionControlPage());
            LastButtonUI.Style = (Style)FindResource("TopNavigationButtonStyle");
            LastButtonUI = BtnMotionControl;
            BtnMotionControl.Style = (Style)FindResource("TopNavigationSelectedButtonStyle");
        }

    private void NavigateToControlInterfacePage(object sender, RoutedEventArgs e)
    {
        MainFrame.Navigate(new ControlInterfacePage());
            LastButtonUI.Style = (Style)FindResource("TopNavigationButtonStyle");
            LastButtonUI = BtnControlInterface;
            BtnControlInterface.Style = (Style)FindResource("TopNavigationSelectedButtonStyle");
    }

    private void NavigateToGlobalMonitoringPage(object sender, RoutedEventArgs e)
    {
        MainFrame.Navigate(new GlobalMonitoringPage());
            LastButtonUI.Style = (Style)FindResource("TopNavigationButtonStyle");
            LastButtonUI = BtnGlobalMonitoring;
            BtnGlobalMonitoring.Style = (Style)FindResource("TopNavigationSelectedButtonStyle");
        }

    private void NavigateToProcessMonitoringPage(object sender, RoutedEventArgs e)
    {
        MainFrame.Navigate(new ProcessMonitoringPage());
            LastButtonUI.Style = (Style)FindResource("TopNavigationButtonStyle");
            LastButtonUI = BtnProcessMonitoring;
            BtnProcessMonitoring.Style = (Style)FindResource("TopNavigationSelectedButtonStyle");
        }
        private void NavigateToProcessManagementPage(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ProcessManagementPage());
            LastButtonUI.Style = (Style)FindResource("TopNavigationButtonStyle");
            LastButtonUI = BtnProcessManagement;
            BtnProcessManagement.Style = (Style)FindResource("TopNavigationSelectedButtonStyle");
        }
        private void NavigateToMonitoringAlarmPage(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new MonitoringAlarmPage());
            LastButtonUI.Style = (Style)FindResource("TopNavigationButtonStyle");
            LastButtonUI = BtnMonitoringAlarm;
            BtnMonitoringAlarm.Style = (Style)FindResource("TopNavigationSelectedButtonStyle");
        }
        //炉管页面跳转
        private void NavigateToHomePage(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new HomePage());
            LastButtonUI.Style = (Style)FindResource("TopNavigationButtonStyle");
            LastButtonUI = BtnHome;
            BtnHome.Style = (Style)FindResource("TopNavigationSelectedButtonStyle");
        }
        private void NavigateToFurnaceTube1Page(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new FurnaceTube1Page());
            LastButtonUI.Style = (Style)FindResource("TopNavigationButtonStyle");
            LastButtonUI = BtnFurnaceTube1;
            BtnFurnaceTube1.Style = (Style)FindResource("TopNavigationSelectedButtonStyle");
        }
        private void NavigateToFurnaceTube2Page(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new FurnaceTube2Page());
            LastButtonUI.Style = (Style)FindResource("TopNavigationButtonStyle");
            LastButtonUI = BtnFurnaceTube2;
            BtnFurnaceTube2.Style = (Style)FindResource("TopNavigationSelectedButtonStyle");
        }
        private void NavigateToFurnaceTube3Page(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new FurnaceTube3Page());
            LastButtonUI.Style = (Style)FindResource("TopNavigationButtonStyle");
            LastButtonUI = BtnFurnaceTube3;
            BtnFurnaceTube3.Style = (Style)FindResource("TopNavigationSelectedButtonStyle");
        }
        private void NavigateToFurnaceTube4Page(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new FurnaceTube4Page());
            LastButtonUI.Style = (Style)FindResource("TopNavigationButtonStyle");
            LastButtonUI = BtnFurnaceTube4;
            BtnFurnaceTube4.Style = (Style)FindResource("TopNavigationSelectedButtonStyle");
        }

        private void NavigateToFurnaceTube5Page(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new FurnaceTube5Page());
            LastButtonUI.Style = (Style)FindResource("TopNavigationButtonStyle");
            LastButtonUI = BtnFurnaceTube5;
            BtnFurnaceTube5.Style = (Style)FindResource("TopNavigationSelectedButtonStyle");
        }

        private void NavigateToFurnaceTube6Page(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new FurnaceTube6Page());
            LastButtonUI.Style = (Style)FindResource("TopNavigationButtonStyle");
            LastButtonUI = BtnFurnaceTube6;
            BtnFurnaceTube6.Style = (Style)FindResource("TopNavigationSelectedButtonStyle");
        }

        private void NavigateToProcessReservationPage(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ProcessReservationPage());
            LastButtonUI.Style = (Style)FindResource("TopNavigationButtonStyle");
            LastButtonUI = BtnProcessReservation;
            BtnProcessReservation.Style = (Style)FindResource("TopNavigationSelectedButtonStyle");
        }
    }
}