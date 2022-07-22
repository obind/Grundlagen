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
    /// Interaktionslogik für PinAbfrage.xaml
    /// </summary>
    public partial class PinAbfrage : Window
    {
        //public int geheimzahl = 0;
        public bool right = false;


        private int geheimzahl = 1234;
        private int counter;

        public int Geheimzahl
        {
            get => geheimzahl;
            set => geheimzahl = value;
        }
            
        public PinAbfrage()
        {
            InitializeComponent();

        }



        private void pinabfrage_back_btn_Click(object sender, RoutedEventArgs e)
        {
            Close();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show(); 
   
        }

        private void pinabfrage_enter_btn_Click(object sender, RoutedEventArgs e)
        {
            if (pin_Txt.Text == Geheimzahl.ToString())
            {
                right = true;   
                Hide();
            }
            else
            {
                pin_Txt.Text = "Falsche Pin";
                right = false;
                counter++;

                if (counter == 4)
                {
                    pin_Txt.Clear();
                    MessageBox.Show("Zu viele Fehlversuche");
                    Hide();
                    Welcome welcome = new Welcome();
                    welcome.Show();
                }
            }
        }

        //Buttons
        private void pinabfrage_1_btn_Click(object sender, RoutedEventArgs e)
        {
            pin_Txt.Text += "1";
        }

        private void pinabfrage_2_btn_Click(object sender, RoutedEventArgs e)
        {
            pin_Txt.Text += "2";
        }

        private void pinabfrage_3_btn_Click(object sender, RoutedEventArgs e)
        {
            pin_Txt.Text += "3";
        }

        private void pinabfrage_4_btn_Click(object sender, RoutedEventArgs e)
        {
            pin_Txt.Text += "4";
        }

        private void pinabfrage_5_btn_Click(object sender, RoutedEventArgs e)
        {
            pin_Txt.Text += "5";
        }

        private void pinabfrage_6_btn_Click(object sender, RoutedEventArgs e)
        {
            pin_Txt.Text += "6";
        }
        private void pinabfrage_7_btn_Click(object sender, RoutedEventArgs e)
        {
            pin_Txt.Text += "7";
        }
        private void pinabfrage_8_btn_Click(object sender, RoutedEventArgs e)
        {
            pin_Txt.Text += "8";
        }

        private void pinabfrage_9_btn_Click(object sender, RoutedEventArgs e)
        {
            pin_Txt.Text += "9";
        }

        private void pinabfrage_return_btn_Click(object sender, RoutedEventArgs e)
        {
            pin_Txt.Clear();
        }

        private void pinabfrage_0_btn_Click(object sender, RoutedEventArgs e)
        {
            pin_Txt.Text += "0";
        }
    }
}
