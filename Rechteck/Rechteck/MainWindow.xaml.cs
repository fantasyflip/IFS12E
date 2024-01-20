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

namespace Rechteck
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CRechteck cr_r1 = new CRechteck(2.0, 3.0);
        private CKreis ck_k1 = new CKreis(4.0);

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnEnde_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult mbr_input;
            mbr_input = MessageBox.Show("Wollen Sie wirklich beenden?", "Programm beenden", MessageBoxButton.OKCancel, MessageBoxImage.Question);

            if (mbr_input == MessageBoxResult.OK)
            {
                this.Close();
            }
        }

        private void btnSichern_Click(object sender, RoutedEventArgs e)
        {
            double d_a;
            double d_b;
            bool b_parseA;
            bool b_parseB;
            bool b_setSeiten;

            double d_radius;
            bool b_parseRadius;
            bool b_setRadius;

            if ((txtSeiteA.Text!= "")&&(txtSeiteB.Text!=""))
            {
                b_parseA = double.TryParse(txtSeiteA.Text, out d_a);
                b_parseB = double.TryParse(txtSeiteB.Text, out d_b);

                if ((b_parseA == false) || (b_parseB == false))
                {
                    MessageBox.Show("Die Seitenlängen dürfen nur aus Zahlen bestehen", "Fehler Eingabe", MessageBoxButton.OK, MessageBoxImage.Error);

                    lblAction.Content = "Fehler: Falsche Eingabe der Seitenlängen...\n" + lblAction.Content;
                }
                else
                {
                    b_setSeiten = cr_r1.setSeitenlaengen(d_a, d_b);

                    if (b_setSeiten)
                    {
                        lblAction.Content = "Info: Seitenlängen wurden gespeichert...\n" + lblAction.Content;
                        txtSeiteA.Clear();
                        txtSeiteB.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Die Seitenlängen müssen größer als 0 sein!", "Fehler Eingabe", MessageBoxButton.OK, MessageBoxImage.Error);

                        lblAction.Content = "Fehler: Eingegebene Seitenlänge kleiner oder gleich 0...\n" + lblAction.Content;
                    }
                }
            }

            if (txtRadius.Text!="")
            {
                b_parseRadius = double.TryParse(txtRadius.Text, out d_radius);

                if (b_parseRadius)
                {
                    b_setRadius = ck_k1.setRadius(d_radius);

                    if (b_setRadius)
                    {
                        lblAction.Content = "Info: Der Radius des Kreis wurde gespeichert...\n" + lblAction.Content;
                        txtRadius.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Der Radius muss größer als 0 sein!", "Fehler Eingabe", MessageBoxButton.OK, MessageBoxImage.Error);

                        lblAction.Content = "Fehler: Eingegeebener Radius kleiner gleich 0...\n" + lblAction.Content;
                    }
                }
                else
                {
                    MessageBox.Show("Der Radius darf nur aus Zahlen bestehen", "Fehler Eingabe", MessageBoxButton.OK, MessageBoxImage.Error);

                    lblAction.Content = "Fehler: Falsche Eingabe des Radius...\n" + lblAction.Content;
                }
            }
        }

        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Seite A: " + cr_r1.getA() + "\nSeite B: " + cr_r1.getB() + "\n\nRadius: " + ck_k1.getRadius(), "Seitenlängen", MessageBoxButton.OK, MessageBoxImage.Information);
            
            lblAction.Content = "Info: Definierte Werte angezeigt...\n" + lblAction.Content;
        }

        private void btnFlaeche_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Rechteck: " + cr_r1.Flaeche() + "\nKreis: " + ck_k1.Flaeche(), "Fläche", MessageBoxButton.OK, MessageBoxImage.Information);

            lblAction.Content = "Info: Fläche angezeigt...\n" + lblAction.Content;
        }

        private void btnUmfang_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Rechteck: " + cr_r1.Umfang() + "\nKreis: " + ck_k1.Umfang(), "Umfang", MessageBoxButton.OK, MessageBoxImage.Information);

            lblAction.Content = "Info: Umfang angezeigt...\n" + lblAction.Content;
        }
    }
}
