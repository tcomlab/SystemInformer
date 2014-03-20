using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SystemInformer
{
    /// <summary>
    /// Interaction logic for Informer.xaml
    /// </summary>
    public partial class Informer : Window
    {
        Timer tm = new Timer();

        public Informer(int timeShowSec)
        {
            InitializeComponent();
            var W = SystemParameters.PrimaryScreenWidth;
            var H = SystemParameters.PrimaryScreenHeight;
            Left = W - 350;
            Top = H - 200;
            tm.Elapsed += TimeTick;
            tm.Interval = 1000*timeShowSec;
            tm.Start();
        }

        private void TimeTick(object sender, ElapsedEventArgs e)
        {
            Dispatcher.Invoke(Close);
        }

        private void UIElement_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }
    }
}
