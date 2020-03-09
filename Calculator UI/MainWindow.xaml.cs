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
using Calculator;
namespace Calculator_UI
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
            string szam = sender.ToString().Substring((sender.ToString().Length - 1));
            if (szam == "=" )
            {
                CalculatorCore t = new CalculatorCore();
               object ered =  t.Feldolgoz(kijelzo.Text);
                //t.Feldolgoz()
                kijelzo.Text = ered.ToString();
            } else
            {
                kijelzo.Text = kijelzo.Text + szam;
            }
         //   kijelzo.Text = szam;//sender.ToString();
        }
    }
}
