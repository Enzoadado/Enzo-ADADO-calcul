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

namespace Enzo_ADADO_calcul
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // variablesint no1 = 0;

        int no2 = 0;

        int result = 0;

        Char opp = 'a';




        public MainWindow()

        {


            InitializeComponent();

        }



        public void BTN_1_Click(object sender, RoutedEventArgs e)

        {

            display_num("1");

        }


        public void BTN_2_Click(object sender, RoutedEventArgs e)

        {

            display_num("2");

        }


        public void BTN_3_Click(object sender, RoutedEventArgs e)

        {

            display_num("3");

        }


        public void BTN_4_Click(object sender, RoutedEventArgs e)

        {

            display_num("4");

        }


        public void BTN_5_Click(object sender, RoutedEventArgs e)

        {

            display_num("5");

        }


        public void BTN_6_Click(object sender, RoutedEventArgs e)

        {

            display_num("6");

        }


        public void BTN_7_Click(object sender, RoutedEventArgs e)

        {

            display_num("7");

        }


        public void BTN_8_Click(object sender, RoutedEventArgs e)

        {

            display_num("8");

        }


        public void BTN_9_Click(object sender, RoutedEventArgs e)

        {
            display_num("9");

        }


        public void BTN_0_Click(object sender, RoutedEventArgs e)

        {
            display_num("0");

        }


        public void BTN_Plus_Click(object sender, RoutedEventArgs e)

        {

            TB_Display.Text += "+";

        }


        public void BTN_moin_Click(object sender, RoutedEventArgs e)

        {

            TB_Display.Text += "-";

        }


        public void BTN_fois_Click(object sender, RoutedEventArgs e)

        {

            TB_Display.Text += "*";

        }


        public void BTN_div_Click(object sender, RoutedEventArgs e)

        {

            TB_Display.Text += "/";

        }


        public void BTN_egale_Click(object sender, RoutedEventArgs e)

        {

            TB_Display.Text += "=";

        }


        public void BTN_CLR_Click(object sender, RoutedEventArgs e)

        {

            TB_Display.Text = "";

        }


        private void BTN_2_Click_1(object sender, RoutedEventArgs e)

        {


        }


        private void BTN_3_Click_1(object sender, RoutedEventArgs e)

        {


        }


        private void BTN_4_Click_1(object sender, RoutedEventArgs e)

        {


        }


        private void BTN_Plus_Click_1(object sender, RoutedEventArgs e)

        {


        }


        private void BTN_5_Click_1(object sender, RoutedEventArgs e)

        {


        }


        private void BTN_6_Click_1(object sender, RoutedEventArgs e)

        {


        }

        private void display_num(string picknum)
        {
            if (TB_Display.Text == "0")
            {
                TB_Display.Text = picknum;
            }
            else
            {
                TB_Display.Text += picknum;
            }

        }

    }
}

        
    

