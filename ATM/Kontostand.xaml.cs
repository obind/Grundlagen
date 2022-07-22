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

namespace ATM
{
    /// <summary>
    /// Interaktionslogik für Kontostand.xaml
    /// </summary>
    public partial class Kontostand : Window
    {
        private decimal newKontostand = 0;
        private decimal transaktion = 0;

        public decimal Transaktion
        {
            get { return transaktion; }
            set { transaktion = value; }
        }

        public decimal NewKontostand
        {
            get => newKontostand;
            set => newKontostand = value;
        }
        

        public Kontostand()
        {
            InitializeComponent();
    
        }

        private void done_btn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();

        }
    }
}
