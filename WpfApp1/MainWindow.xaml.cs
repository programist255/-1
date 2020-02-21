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
            Sum = Convert.ToDouble(Width.Text) * Convert.ToDouble(Height.Text);
            if(Combo.SelectedIndex == 0 && One.IsChecked == true)
            {
                Sum *= 0.25;
            }
            if (Combo.SelectedIndex == 0 && Two.IsChecked == true)
            {
                Sum *= 0.30;
            }

            if (Combo.SelectedIndex == 1 && One.IsChecked == true)
            {
                Sum *= 0.05;
            }
            if (Combo.SelectedIndex == 1 && Two.IsChecked == true)
            {
                Sum *= 0.10;
            }

            if (Combo.SelectedIndex == 1 && One.IsChecked == true)
            {
                Sum *= 0.15;
            }
            if (Combo.SelectedIndex == 1 && Two.IsChecked == true)
            {
                Sum *= 0.20;
            }

            if(Wind.IsChecked == true)
            {
                Sum += 35;
            }
            

            Suma.Content = Sum + " грн.";

        }
    }
}
