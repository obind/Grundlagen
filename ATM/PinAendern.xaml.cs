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
    /// Interaktionslogik für PinAendern.xaml
    /// </summary>
    public partial class PinAendern : Window
    {
        public PinAendern()
        {
            InitializeComponent();
           

        }



        private void pinaendern_back_btn_Click(object sender, RoutedEventArgs e)
        { 
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();     
        }

        private void pin_aendern_btn_Click(object sender, RoutedEventArgs e)
        {
            if (newPin_txt.Text == newPinRepeat_txt.Text)
            {
                MainWindow mainWindow = new MainWindow();

                mainWindow._pinabfrage.Geheimzahl = Convert.ToInt32(newPin_txt.Text);
                error_lable.Visibility = Visibility.Hidden;
                MessageBox.Show(mainWindow._pinabfrage.Geheimzahl.ToString());
                mainWindow.Show();
                Close();
            }
            else
            {
                error_lable.Visibility = Visibility.Visible;
                return;

            }
            
        }
    }
}
