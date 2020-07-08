using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DesktopClock
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        Timer timer;


        public MainWindow()
        {
            InitializeComponent();

            setDateTime();

            timer = new Timer();
            timer.Interval = 5000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();

        }
        void timer_Tick(object sender, EventArgs e)
        {
            setDateTime();
        }

        private void setDateTime()
        {
            this.lblDate.Content = DateTime.Now.ToString("yyyy/M/d (dddd)");
            this.lblClock.Content = DateTime.Now.ToString("HH:mm");
        }
    }
}
