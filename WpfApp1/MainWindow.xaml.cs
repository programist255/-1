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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public double Sum = 0;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            if (Combo.SelectedIndex == 0 && One.IsChecked == true)
            {
                Sum = Convert.ToDouble(Width.Text) * 100;
            }
            if (Combo.SelectedIndex == 0 && Two.IsChecked == true)
            {
                Sum = Convert.ToDouble(Width.Text) * 150;
            }

            if (Combo.SelectedIndex == 1 && One.IsChecked == true)
            {
                Sum = Convert.ToDouble(Width.Text) * 160;
            }
            if (Combo.SelectedIndex == 1 && Two.IsChecked == true)
            {
                Sum = Convert.ToDouble(Width.Text) * 200;
            }

            if (Combo.SelectedIndex == 1 && One.IsChecked == true)
            {
                Sum = Convert.ToDouble(Width.Text) * 120;
            }
            if (Combo.SelectedIndex == 1 && Two.IsChecked == true)
            {
                Sum = Convert.ToDouble(Width.Text) * 180;
            }
            if (Wind.IsChecked == true)
            {
                Sum += 50 * Convert.ToDouble(Width.Text);
            }

            Suma.Content = Sum + "$";

        }
    }
}
