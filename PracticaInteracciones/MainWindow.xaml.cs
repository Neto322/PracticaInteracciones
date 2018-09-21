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

namespace PracticaInteracciones
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void sldPorcentajePropina_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int slida = ((int)(sldPorcentajePropina.Value));
            lblPorcentajePropina.Text = slida.ToString() + "%";

            float cuenta = float.Parse(txtCuenta.Text);

            float montoPropina = slida / 100.0f * cuenta;

            float total = cuenta + montoPropina;

            lblTotalConPropina.Text = total.ToString();
        }
    }
}
