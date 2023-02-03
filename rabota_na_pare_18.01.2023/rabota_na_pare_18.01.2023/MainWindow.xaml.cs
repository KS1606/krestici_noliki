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

namespace rabota_na_pare_18._01._2023
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

        private void vilka_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show((sender as RadioButton).Content.ToString());
        }

        private void cogo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show((cogo.SelectedItem as ComboBox).ToString());
        }
    }
}
