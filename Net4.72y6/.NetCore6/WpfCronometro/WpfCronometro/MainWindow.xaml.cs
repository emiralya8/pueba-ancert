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
using WpfCronometro.clases;
using WpfCronometro.interfaces;

namespace WpfCronometro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Cronometro cr;
        public MainWindow(ICronometro crono)
        {
            InitializeComponent();
            cr = (Cronometro)crono;
            cr.setLabel(lblCronometro);
        }

        private void btn_start_Click(object sender, RoutedEventArgs e)
        {
            cr.start();
        }

        private void btn_pause_Click(object sender, RoutedEventArgs e)
        {
            cr.pause();
        }

        private void btn_stop_Click(object sender, RoutedEventArgs e)
        {
            cr.stop();
        }
    }
}
