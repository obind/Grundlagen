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

namespace WPF
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(addBtn.Content.ToString() == "+") { 
                addGrid.Visibility = Visibility.Visible;
                addBtn.Content = "-";    
            }
            else if(addBtn.Content.ToString() == "-")
            {
                addGrid.Visibility= Visibility.Collapsed;
                addBtn.Content = "+";
            } 
            
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            string description =  descriptionTxtbox.Text;
            string details = detailsbox.Text;
            string details1 = detailsbox1.Text;
            string date = datepicker.Text;

            if (description == "" || details == "" || date == "")
            {
                MessageBox.Show("Fehlerhafte Eingabe!");
            }
            else
            {
                todosListbox.Items.Add(description +" "+ details +" "+ details1+ " "+ date);
                descriptionTxtbox.Clear();
                detailsbox.Clear();
                detailsbox1.Clear();
                datepicker.Text = "";
            }
            
        }

        private void todosListbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           todostextblock.Text = todosListbox.SelectedItem.ToString();
            idlable.Content = todosListbox.SelectedIndex.ToString();
        }
    }
}
