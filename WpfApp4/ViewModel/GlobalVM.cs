using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace WpfApp4.ViewModel
{
    internal class GlobalVM:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string _test="hello";
        public DispatcherTimer _timer;
        static public GlobalVM SingleObject=new GlobalVM();
        private  GlobalVM() {
            _timer=new DispatcherTimer();
            _timer.Interval = TimeSpan.FromSeconds(2);
            _timer.Tick += new EventHandler(GetData);
            _timer.Start();
        }
        public string test
        {
            get{ return _test; }
            set { _test = value; 
            if(this.PropertyChanged != null)
                {
                    this.PropertyChanged.Invoke(this,new PropertyChangedEventArgs("test"));
                }
            }
        }
        public async void GetData(Object sender,EventArgs e)
        {

        }
    }
}
