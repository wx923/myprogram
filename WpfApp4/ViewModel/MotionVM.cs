using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HslCommunication.ModBus;
using HslCommunication.Profinet.YASKAWA.Helper;
namespace WpfApp4.ViewModel
{
    internal class MotionVM
    {
        public Timer timer;
        public ModbusTcpNet modbusClient;
        public MotionVM()
        {
            modbusClient = new ModbusTcpNet();
            //定时器
            timer = new Timer(connect, null, 0, 1000);
        }

        private void connect(object state)
        {
            
        }

    }
}
