using Libreria_Es_2;
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

namespace Wpf_Es_2
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double n = double.Parse(TXTNUMERO.Text);
            int n1;
            if (Utilità.VerificaIntero(n))
            {
                LBLRISULTATO.Content = "il numero è intero";
                    n1 = (int)n;
            }
            else
            {
                LBLRISULTATO.Content = "il numero è decimale";
                n1 = Utilità.Arrotonda(n);
            }
            if (Utilità.PariDispari(n1))
            {
                LBLRISULTATO.Content = "il numero è pari";
            }
            else
            {
                LBLRISULTATO.Content = "il numero è dispari";
            }
        }
    }
}
