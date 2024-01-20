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

namespace Ampelprojekt_IFS12
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Ampel_Steuerung Ampel = new Ampel_Steuerung(500, 10);

        public MainWindow()
        {
            InitializeComponent();
            // Konstruktor
        }

        private void btnEin_Click(object sender, RoutedEventArgs e)
        {
            //
            Ampel.einschalten();
        }

        private void btnUm_Click(object sender, RoutedEventArgs e)
        {
            //
            Ampel.umschalten();
        }

        private void btnAus_Click(object sender, RoutedEventArgs e)
        {
            //
            Ampel.ausschalten();
        }

        private void btnEnde_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
