using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace _6TTI_DPMAEL_WPF1EVENT
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            boutonCalculer.Click += Calculer;

            TxtA.PreviewTextInput += VerifTextInput;
            TxtB.PreviewTextInput += VerifTextInput;
            TxtC.PreviewTextInput += VerifTextInput;

            boutonV.Visibility = Visibility.Hidden;

            boutonCalculer.MouseEnter += (s, e) =>
            {
                boutonV.Visibility = Visibility.Visible;
                boutonV.Background = Brushes.Red;
            };

            boutonCalculer.MouseLeave += (s, e) =>
            {
                boutonV.Visibility = Visibility.Hidden;
            };
        }

        private void VerifTextInput(object sender, TextCompositionEventArgs e)
        {
            TextBox zone = (TextBox)sender;

            if (e.Text == ",")
            {
                if (zone.Text.Contains(","))
                {
                    e.Handled = true; 
                }
            }
            else
            {
                int nombre;
                bool estUnEntier = int.TryParse(e.Text, out nombre);

                if (estUnEntier == false)
                {
                    e.Handled = true;
                }
            }
        }

        private void Calculer(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(TxtA.Text, out double a)
                || !double.TryParse(TxtB.Text, out double b)
                || !double.TryParse(TxtC.Text, out double c))
            {
                MessageBox.Show("Entre trois nombres valides.");
                return;
            }

            ResoudTrinome(a, b, c, out string message);
            MessageBox.Show(message);
        }

        static void ResoudTrinome(double a, double b, double c, out string message)
        {
            double delta = Math.Pow(b, 2) - 4 * a * c;
            if (delta < 0)
            {
                message = "Il n'y a pas de solution réelle";

            }
            else if (delta == 0)
            {
                double x1 = -b / (2 * a);
                message = "Il y a une solution " + x1;
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                message = "Il y a deux solutions " + x1 + " et " + x2;
            }
        }
    }
}