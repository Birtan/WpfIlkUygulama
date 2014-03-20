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
using Islemler;

namespace CezarSifleme
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            Islem sifre = new Islem();
            lblSonuc.Content= sifre.Sifrele(txtSifrelenecek.Text,byte.Parse(txtAnahtar.Text));
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Playfair p = new Playfair();
            p.Show();
        }
    }
}
