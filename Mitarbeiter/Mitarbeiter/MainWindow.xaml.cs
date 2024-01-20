using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mitarbeiter
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // 4 Objekte erstellen 
        // jeweils 2 Angestellte und Arbeiter mit und ohne Parameter
        private CAngestellter c_An1 = new CAngestellter();
        private CAngestellter c_An2 = new CAngestellter("Hans", "Peter", 2000.9);

        private CArbeiter c_Ar1 = new CArbeiter();
        private CArbeiter c_Ar2 = new CArbeiter("Udo", "Schmidt", 40.0, 12.50);

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAng1_Click(object sender, RoutedEventArgs e)
        {
            txtVN_Ang1.Text = c_An1.getVorname();
            txtNN_Ang1.Text = c_An1.getNachname();
            txtG_Ang1.Text = c_An1.getBrutto().ToString();
        }

        private void btnAng2_Click(object sender, RoutedEventArgs e)
        {
            txtVN_Ang2.Text = c_An2.getVorname();
            txtNN_Ang2.Text = c_An2.getNachname();
            txtG_Ang2.Text = c_An2.getBrutto().ToString();
        }

        private void btnArb1_Click(object sender, RoutedEventArgs e)
        {
            txtVN_Arb1.Text = c_Ar1.getVorname();
            txtNN_Arb1.Text = c_Ar1.getNachname();
            txtG_Arb1.Text = c_Ar1.getBrutto().ToString();
        }

        private void btnArb2_Click(object sender, RoutedEventArgs e)
        {
            txtVN_Arb2.Text = c_Ar2.getVorname();
            txtNN_Arb2.Text = c_Ar2.getNachname();
            txtG_Arb2.Text = c_Ar2.getBrutto().ToString();
        }



        private void btnSaveAng1_Click(object sender, RoutedEventArgs e)
        {
            // Hier fehlt Daten in das jeweilige Objekt übertragen
            double d_brutto = 0.0;
            bool b_parse = false;

            b_parse = double.TryParse(txtG_Ang1.Text, out d_brutto);

            if (b_parse)
            {
                c_An1.setVorname(txtVN_Ang1.Text);
                c_An1.setNachname(txtNN_Ang1.Text);
                c_An1.setBrutto(d_brutto);

                txtNN_Ang1.Clear();
                txtVN_Ang1.Clear();
                txtG_Ang1.Clear();
            }
            else
            {
                MessageBox.Show("Fehler in der Eingabe", "Fehler", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnSaveAng2_Click(object sender, RoutedEventArgs e)
        {
            // Hier fehlt Daten in das jeweilige Objekt übertragen
            double d_brutto = 0.0;
            bool b_parse = false;

            b_parse = double.TryParse(txtG_Ang2.Text, out d_brutto);

            if (b_parse)
            {
                c_An2.setVorname(txtVN_Ang2.Text);
                c_An2.setNachname(txtNN_Ang2.Text);
                c_An2.setBrutto(d_brutto);

                txtNN_Ang2.Clear();
                txtVN_Ang2.Clear();
                txtG_Ang2.Clear();
            }
            else
            {
                MessageBox.Show("Fehler in der Eingabe", "Fehler", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnSaveArb1_Click(object sender, RoutedEventArgs e)
        {
            // Hier fehlt Daten in das jeweilige Objekt übertragen
            double d_SL = 0.0;
            double d_SZ = 0.0;
            bool b_parse = false;

            b_parse = double.TryParse(txtSL_Arb1.Text, out d_SL);
            b_parse = double.TryParse(txtSZ_Arb1.Text, out d_SZ);

            if (b_parse)
            { 
                c_Ar1.setVorname(txtVN_Arb1.Text);
                c_Ar1.setNachname(txtNN_Arb1.Text);
                c_Ar1.setStundenlohn(d_SL);
                c_Ar1.setStundenzahl(d_SZ);

                txtNN_Arb1.Clear();
                txtVN_Arb1.Clear();
                txtG_Arb1.Clear();
                txtSL_Arb1.Clear();
                txtSZ_Arb1.Clear();
            }
            else
            {
                MessageBox.Show("Fehler in der Eingabe", "Fehler", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnSaveArb2_Click(object sender, RoutedEventArgs e)
        {
            // Hier fehlt Daten in das jeweilige Objekt übertragen
            double d_SL = 0.0;
            double d_SZ = 0.0;
            bool b_parse = false;

            b_parse = double.TryParse(txtSL_Arb2.Text, out d_SL);
            b_parse = double.TryParse(txtSZ_Arb2.Text, out d_SZ);

            if (b_parse)
            {
                c_Ar2.setVorname(txtVN_Arb2.Text);
                c_Ar2.setNachname(txtNN_Arb2.Text);
                c_Ar2.setStundenlohn(d_SL);
                c_Ar2.setStundenzahl(d_SZ);

                txtNN_Arb2.Clear();
                txtVN_Arb2.Clear();
                txtG_Arb2.Clear();
                txtSL_Arb2.Clear();
                txtSZ_Arb2.Clear();
            }
            else
            {
                MessageBox.Show("Fehler in der Eingabe", "Fehler", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
