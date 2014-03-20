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
using System.Windows.Shapes;
using Islemler;

namespace CezarSifleme
{
    /// <summary>
    /// Interaction logic for Playfair.xaml
    /// </summary>
    public partial class Playfair:Window
    {
        public Playfair()
        {
            InitializeComponent();
        }

        private void btnSifre_Click(object sender, RoutedEventArgs e)
        {
            Islemler.Playfair play = new Islemler.Playfair();
           txtSifreliMetin.Text= play.PlayfairMatris(txtMetin.Text, txtSifre.Text);
        }
    }
}
