using System.Windows;

namespace ATM
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


        public PinAbfrage _pinabfrage = new PinAbfrage();
        public Kontostand _kontostand = new Kontostand();

        private void auszahlung_Click(object sender, RoutedEventArgs e)
        {
            _pinabfrage.ShowDialog();
            Auszahlung auszahlung = new Auszahlung();

            if (_pinabfrage.right == true)
            {
                auszahlung.Show();
                Close();
            }
            else
            {
                auszahlung.Close();
            }
        }

        private void kontostand_btn_Click(object sender, RoutedEventArgs e)
        {

            _pinabfrage.ShowDialog();

            if (_pinabfrage.right == true)
            {
                _kontostand.kontostand_txt.Content = _kontostand.NewKontostand;
                _kontostand.Show();

                Close();
            }
            else
            {
                _kontostand.Close();
            }
        }

        private void pinaendern_btn_Click(object sender, RoutedEventArgs e)
        {
            _pinabfrage.ShowDialog();
            PinAendern pinAendern = new PinAendern();

            if (_pinabfrage.right == true)
            {
                pinAendern.Show();
                Close();
            }
            else
            {
                pinAendern.Close();
            }
        }

        private void cancel_btn_Click(object sender, RoutedEventArgs e)
        {
            Welcome welcome = new Welcome();
            welcome.Show();
            Close();
        }

        private void einzahalung_btn_Click(object sender, RoutedEventArgs e)
        {
            Einzahlung einzahlung = new Einzahlung();
            einzahlung.Show();
        }
    }
}