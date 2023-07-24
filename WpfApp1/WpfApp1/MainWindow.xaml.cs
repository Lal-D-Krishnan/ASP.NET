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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Isplaying(false);
        }

        private void Isplaying(bool v)
        {
            BtnPlay1.IsEnabled = v;
            BtnStop.IsEnabled = v;
            BtnForward.IsEnabled = v;
            BtnForward.IsEnabled = v;
            BtnBack.IsEnabled = v;

        }

        private void BtnOpen_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog d = new Microsoft.Win32.OpenFileDialog();

            d.FileName = "cocacola";
            d.DefaultExt = ".mp4";
            d.Filter = "MP4 Files|*.mp4";
            Nullable<bool> result = d.ShowDialog();
            if(result == true)
            {
                Mdemt.Source = new Uri(d.FileName);
            }
            BtnPlay1.IsEnabled = true;
        }

        private void BtnPlay1_Click(object sender, RoutedEventArgs e)
        {
            Isplaying(true);
            if(BtnPlay1.Content.ToString() == "PLAY")
            {
                Mdemt.Play();
                
                BtnPlay1.Content = "PAUSE";
            }
            else
            {
                Mdemt.Pause();
                BtnPlay1.Content = "PLAY";
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Mdemt.Position -= TimeSpan.FromSeconds(3);
        }

        private void BtnForward_Click(object sender, RoutedEventArgs e)
        {
            Mdemt.Position += TimeSpan.FromSeconds(3);
        }

        private void BtnStop_Click(object sender, RoutedEventArgs e)
        {
            Mdemt.Stop();
            BtnPlay1.Content = "PLAY";
            Isplaying(false);
            BtnPlay1.IsEnabled = true;
        }
    }
}
