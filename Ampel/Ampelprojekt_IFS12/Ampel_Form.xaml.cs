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
using System.Windows.Shapes;

namespace Ampelprojekt_IFS12
{
    /// <summary>
    /// Interaktionslogik für Ampel_Form.xaml
    /// </summary>
    public partial class Ampel_Form : Window
    {
        public Ampel_Form(int x=500, int y=50)
        {
            InitializeComponent();
            this.Left = x;
            this.Top = y;
            this.RotAus();
            this.GelbAus();
            this.GruenAus();
            this.Show();
        }

        public void RotEin()
        {
            ellRot.Fill = new SolidColorBrush(Colors.Red);
        }
        public void RotAus()
        {
            ellRot.Fill = new SolidColorBrush(Colors.Black);
        }

        public void GelbEin()
        {
            ellGelb.Fill = new SolidColorBrush(Colors.Yellow);
        }
        public void GelbAus()
        {
            ellGelb.Fill = new SolidColorBrush(Colors.Black);
        }
        public void GruenEin()
        {
            ellGruen.Fill = new SolidColorBrush(Colors.Green);
        }
        public void GruenAus()
        {
            ellGruen.Fill = new SolidColorBrush(Colors.Black);
        }
    }
}
