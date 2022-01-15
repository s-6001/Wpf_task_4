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

namespace Wpf_task_4
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            resSum.Text =Convert.ToString(Convert.ToDouble(sum.Text) * Convert.ToDouble(rate.Text)); //переводим доллары в рубли
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            resSum2.Text = Convert.ToString(Convert.ToDouble(sum2.Text) * Convert.ToDouble(rate2.Text)); //переводим евро в рубли
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            resSum3.Text = Convert.ToString(Convert.ToDouble(sum3.Text) * Convert.ToDouble(rate3.Text)); //переводим гривны в рубли
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            resSum4.Text = Convert.ToString(Convert.ToDouble(sum4.Text) * Convert.ToDouble(rate4.Text)); //переводим драма в рубли
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            inchToMeter.Text = Convert.ToString(Convert.ToDouble(inch.Text) / 39.37); //переводим дюймы в метры
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
           footToMeter.Text = Convert.ToString(Convert.ToDouble(foot.Text) / 3.281); //переводим футы в метры
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            mileToMeter.Text = Convert.ToString(Convert.ToDouble(mile.Text) / 0.0006214); //переводим мили в метры
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            verstToMeter.Text = Convert.ToString(Convert.ToDouble(verst.Text) / 0.0009374); //переводим версты в метры
        }
    }
}