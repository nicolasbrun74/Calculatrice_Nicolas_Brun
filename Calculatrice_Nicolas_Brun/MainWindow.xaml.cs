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

namespace Calculatrice_Nicolas_Brun
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double premierNombre = 0;

        string operation = "";
        //test git 
        public MainWindow()
        {
            InitializeComponent();
        }
        private void BTN_0_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Display.Text == "0 =" || TB_Display.Text == "0")
            {
                TB_Display.Text = "";
            }

            TB_Display.Text = TB_Display.Text + "0";

        }

        private void BTN_1_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Display.Text == "0 =" || TB_Display.Text == "0")
            {
                TB_Display.Text = "";
            }

            TB_Display.Text = TB_Display.Text + "1";

        }

        private void BTN_2_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Display.Text == "0 =" || TB_Display.Text == "0")
            {
                TB_Display.Text = "";
            }

            TB_Display.Text = TB_Display.Text + "2";

        }

        private void BTN_3_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Display.Text == "0 =" || TB_Display.Text == "0")
            {
                TB_Display.Text = "";
            }

            TB_Display.Text = TB_Display.Text + "3";

        }

        private void BTN_4_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Display.Text == "0 =" || TB_Display.Text == "0")
            {
                TB_Display.Text = "";
            }

            TB_Display.Text = TB_Display.Text + "4";

        }

        private void BTN_5_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Display.Text == "0 =" || TB_Display.Text == "0")
            {
                TB_Display.Text = "";
            }

            TB_Display.Text = TB_Display.Text + "5";

        }

        private void BTN_6_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Display.Text == "0 =" || TB_Display.Text == "0")
            {
                TB_Display.Text = "";
            }

            TB_Display.Text = TB_Display.Text + "6";

        }

        private void BTN_7_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Display.Text == "0 =" || TB_Display.Text == "0")
            {
                TB_Display.Text = "";
            }

            TB_Display.Text = TB_Display.Text + "7";

        }

        private void BTN_8_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Display.Text == "0 =" || TB_Display.Text == "0")
            {
                TB_Display.Text = "";
            }

            TB_Display.Text = TB_Display.Text + "8";

        }

        private void BTN_9_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Display.Text == "0 =" || TB_Display.Text == "0")
            {
                TB_Display.Text = "";
            }

            TB_Display.Text = TB_Display.Text + "9";

        }
        private void BTN_Fois_Click(object sender, RoutedEventArgs e)
        {
            premierNombre = Convert.ToDouble(TB_Display.Text);
            operation = "*";
            TB_Display.Text = "0";
        }

        private void BTN_Plus_Click(object sender, RoutedEventArgs e)
        {

            premierNombre = Convert.ToDouble(TB_Display.Text);
            operation = "+";
            TB_Display.Text = "0";


        }

        private void BTN_Moins_Click(object sender, RoutedEventArgs e)
        {
            premierNombre = Convert.ToDouble(TB_Display.Text);
            operation = "-";
            TB_Display.Text = "0";

        }
        private void BTN_DIV_Click(object sender, RoutedEventArgs e)
        {
            premierNombre = Convert.ToDouble(TB_Display.Text);
            operation = "/";
            TB_Display.Text = "0";

        }

        private void BTN_CLR_Click(object sender, RoutedEventArgs e)
        {
            TB_Display.Text = "0 =";
            premierNombre = 0;
            operation = "";

        }

        private void BTN_egale_Click(object sender, RoutedEventArgs e)
        {
            double deuxiemeNombre = 0;
            double resultat = 0;

            if (operation == "sqrt")
            {
                if (premierNombre < 0)
                {
                    TB_Display.Text = "Erreur";
                    operation = "";
                    return;
                }
                resultat = Math.Sqrt(premierNombre);
            }
            else if (operation == "carre")
            {
                resultat = premierNombre * premierNombre;
            }
            else if (operation == "sin")
            {
                resultat = Math.Sin(premierNombre * Math.PI / 180);
            }
            else if (operation == "cos")
            {
                resultat = Math.Cos(premierNombre * Math.PI / 180);
            }
            else if (operation == "tan")
            {
                resultat = Math.Tan(premierNombre * Math.PI / 180);
            }
            else if (operation == "pi")
            {
                if (operation == "*" || operation == "+" ||
                        operation == "-" || operation == "/")
                {
                    // On garde l'opération en cours
                    premierNombre = Convert.ToDouble(TB_Display.Text);
                    TB_Display.Text = Math.PI.ToString();
                }
                else
                {
                    // Affiche pi directement
                    TB_Display.Text = Math.PI.ToString();
                }
            }
            else if (operation == "plusoumoins")
            {
                resultat = -premierNombre;
            }
            else if (operation == "log")
            {
                if (premierNombre <= 0)
                {
                    TB_Display.Text = "Erreur";
                    operation = "";
                    return;
                }
                resultat = Math.Log10(premierNombre);
            }
            else
            {
                deuxiemeNombre = Convert.ToDouble(TB_Display.Text);


                if (operation == "+")
            {
                resultat = premierNombre + deuxiemeNombre;
            }

            else if (operation == "-")
            {
                resultat = premierNombre - deuxiemeNombre;
            }

            else if (operation == "*")
            {
                resultat = premierNombre * deuxiemeNombre;
            }

            else if (operation == "/")
            {
                resultat = premierNombre / deuxiemeNombre;

            }
        }
            TB_Display.Text = resultat.ToString();
            operation = "";
        }


        private void BTN_Sin_Click(object sender, RoutedEventArgs e)
        {
            premierNombre = Convert.ToDouble(TB_Display.Text);
            operation = "sin";
        }

        private void BTN_Tan_Click(object sender, RoutedEventArgs e)
        {
            premierNombre = Convert.ToDouble(TB_Display.Text);
            operation = "tan";
        }

        private void BTN_Cos_Click(object sender, RoutedEventArgs e)
        {
            premierNombre = Convert.ToDouble(TB_Display.Text);
            operation = "cos";
        }

        private void BTN_carre_Click(object sender, RoutedEventArgs e)
        {
            premierNombre = Convert.ToDouble(TB_Display.Text);
            operation = "carre";
        }

        private void BTN_sqrt_Click(object sender, RoutedEventArgs e)
        {
            premierNombre = Convert.ToDouble(TB_Display.Text);
            operation = "sqrt";
        }

        private void BTN_pi_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "+" || operation == "-" ||
        operation == "*" || operation == "/")
            {
                TB_Display.Text = Math.PI.ToString();
            }
            else
            {
                TB_Display.Text = Math.PI.ToString();
            }
        }

        private void BTN_plusoumoins_Click(object sender, RoutedEventArgs e)
        {
            premierNombre = Convert.ToDouble(TB_Display.Text);
            operation = "plusoumoins";
        }

        private void BTN_log_Click(object sender, RoutedEventArgs e)
        {
            premierNombre = Convert.ToDouble(TB_Display.Text);
            operation = "log";
        }

        private void BTN_virgule_Click(object sender, RoutedEventArgs e)
        {
            if (!TB_Display.Text.Contains(",") &&
                !TB_Display.Text.Contains("."))
            {
                TB_Display.Text += ",";
            }
    }
}
}