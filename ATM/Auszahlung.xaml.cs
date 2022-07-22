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
    /// Interaktionslogik für Auszahlung.xaml
    /// </summary>
    public partial class Auszahlung : Window
    {
        public Auszahlung()
        {
            InitializeComponent();
        }

        private void auszahlung_back_btn_Click(object sender, RoutedEventArgs e)
        {
            
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("10€ Werden Abgehoben");
            MainWindow mainWindow = new MainWindow();
            mainWindow._kontostand.NewKontostand = 10;
            MessageBox.Show(mainWindow._kontostand.NewKontostand.ToString());
            
        }

        private void abheben_20Euro_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("20€ Werden Abgehoben");
        }

        private void abheben_50Euro_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("50€ Werden Abgehoben");
        }

        private void abheben_andereEuro_Click(object sender, RoutedEventArgs e)
        {
            AndereBetrag andereBetrag = new AndereBetrag();
            andereBetrag.ShowDialog();
            MessageBox.Show(andereBetrag.betrag_input.Text + "€ Werden Ausgezahlt");
        }
    }
}
