using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace krestik_nolic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Base();

        }

        private void knop_Click(object sender, RoutedEventArgs e)
        {
            knop.Content = "0";
            knop.IsHitTestVisible = false;
            robot();

        }

        private void Base()
        {
            knop.IsHitTestVisible = false;
            knop2.IsHitTestVisible = false;
            knop3.IsHitTestVisible = false;
            knop4.IsHitTestVisible = false;
            knop5.IsHitTestVisible = false;
            knop6.IsHitTestVisible = false;
            knop7.IsHitTestVisible = false;
            knop8.IsHitTestVisible = false;
            knop9.IsHitTestVisible = false;
        }

        private void nach_Click(object sender, RoutedEventArgs e)
        {
            knop.Content = "";
            knop2.Content = "";
            knop3.Content = "";
            knop4.Content = "";
            knop5.Content = "";
            knop6.Content = "";
            knop7.Content = "";
            knop8.Content = "";
            knop9.Content = "";
            text.Text = "";

            knop.IsHitTestVisible = true;
            knop2.IsHitTestVisible = true;
            knop3.IsHitTestVisible = true;
            knop4.IsHitTestVisible = true;
            knop5.IsHitTestVisible = true;
            knop6.IsHitTestVisible = true;
            knop7.IsHitTestVisible = true;
            knop8.IsHitTestVisible = true;
            knop9.IsHitTestVisible = true;
        }

        private void robot()
        {
            
            Random rnd = new Random();
            int a = rnd.Next(1, 9);
            switch(a){
                case 1:
                    if (knop.IsHitTestVisible == true)
                    {
                        
                        knop.Content = "X";
                        knop.IsHitTestVisible = false;
                    }
                    else
                        robot();
                    break;
                case 2:
                    if (knop2.IsHitTestVisible == true)
                    {
                        knop2.Content = "X";
                        knop2.IsHitTestVisible = false;
                    }
                    else
                        robot();
                    break;
                case 3:
                    if (knop3.IsHitTestVisible == true)
                    {
                        knop3.Content = "X";
                        knop3.IsHitTestVisible = false;
                    }
                    else
                        robot();
                    break;
                case 4:
                    if (knop4.IsHitTestVisible == true)
                    {
                        knop4.Content = "X";
                        knop4.IsHitTestVisible = false;
                    }
                    else
                        robot();
                    break;
                case 5:
                    if (knop5.IsHitTestVisible == true)
                    {
                        knop5.Content = "X";
                        knop5.IsHitTestVisible = false;
                    }
                    else
                        robot();
                    break;
                case 6:
                    if (knop6.IsHitTestVisible == true)
                    {
                        knop6.Content = "X";
                        knop6.IsHitTestVisible = false;
                    }
                    else
                        robot();
                    break;
                case 7:
                    if (knop7.IsHitTestVisible == true)
                    {
                        knop7.Content = "X";
                        knop7.IsHitTestVisible = false;
                    }
                    else
                        robot();
                    break;
                case 8:
                    if (knop8.IsHitTestVisible == true)
                    {
                        knop8.Content = "X";
                        knop8.IsHitTestVisible = false;
                    }
                    else
                        robot();
                    break;
                case 9:
                    if (knop9.IsHitTestVisible == true)
                    {
                        knop9.Content = "X";
                        knop9.IsHitTestVisible = false;
                    }
                    else
                        robot();
                    break;
            }
        }

        private void proverka()
        {
            if ((knop.Content.ToString() == "0" && knop2.Content.ToString() == "0" && knop3.Content.ToString() == "0") ||
                (knop4.Content.ToString() == "0" && knop5.Content.ToString() == "0" && knop6.Content.ToString() == "0") ||
                (knop7.Content.ToString() == "0" && knop8.Content.ToString() == "0" && knop9.Content.ToString() == "0") ||
                (knop.Content.ToString() == "0" && knop5.Content.ToString() == "0" && knop9.Content.ToString() == "0") ||
                (knop3.Content.ToString() == "0" && knop5.Content.ToString() == "0" && knop7.Content.ToString() == "0") ||
                (knop.Content.ToString() == "0" && knop4.Content.ToString() == "0" && knop7.Content.ToString() == "0") ||
                (knop2.Content.ToString() == "0" && knop5.Content.ToString() == "0" && knop8.Content.ToString() == "0") ||
                (knop3.Content.ToString() == "0" && knop6.Content.ToString() == "0" && knop9.Content.ToString() == "0"))
            {
                text.Text = "Победа ноликов!";
                Base();
            }
            else if ((knop.Content.ToString() == "X" && knop2.Content.ToString() == "X" && knop3.Content.ToString() == "X") ||
                (knop4.Content.ToString() == "X" && knop5.Content.ToString() == "X" && knop6.Content.ToString() == "X") ||
                (knop7.Content.ToString() == "X" && knop8.Content.ToString() == "X" && knop9.Content.ToString() == "X") ||
                (knop.Content.ToString() == "X" && knop5.Content.ToString() == "X" && knop9.Content.ToString() == "X") ||
                (knop3.Content.ToString() == "X" && knop5.Content.ToString() == "X" && knop7.Content.ToString() == "X") ||
                (knop.Content.ToString() == "X" && knop4.Content.ToString() == "X" && knop7.Content.ToString() == "X") ||
                (knop2.Content.ToString() == "X" && knop5.Content.ToString() == "X" && knop8.Content.ToString() == "X") ||
                (knop3.Content.ToString() == "X" && knop6.Content.ToString() == "X" && knop9.Content.ToString() == "X"))
            {
                text.Text = "Победа крестиков!";
                Base();
            }
            else if ((!String.IsNullOrWhiteSpace(knop.Content.ToString())) && (!String.IsNullOrWhiteSpace(knop2.Content.ToString())) &&
                    (!String.IsNullOrWhiteSpace(knop3.Content.ToString())) && (!String.IsNullOrWhiteSpace(knop4.Content.ToString())) &&
                    (!String.IsNullOrWhiteSpace(knop5.Content.ToString())) && (!String.IsNullOrWhiteSpace(knop6.Content.ToString())) &&
                    (!String.IsNullOrWhiteSpace(knop7.Content.ToString())) && (!String.IsNullOrWhiteSpace(knop8.Content.ToString())) &&
                    (!String.IsNullOrWhiteSpace(knop9.Content.ToString())))
            {
                text.Text = "Ничья!";
                Base();
            }
            else
                robot();
        }

        private void knop2_Click(object sender, RoutedEventArgs e)
        {
            knop2.Content = "0";
            knop2.IsHitTestVisible = false;
            proverka();
        }
        private void knop3_Click(object sender, RoutedEventArgs e)
        {
            knop3.Content = "0";
            knop3.IsHitTestVisible = false;
            proverka();
        }

        private void knop4_Click(object sender, RoutedEventArgs e)
        {
            knop4.Content = "0";
            knop4.IsHitTestVisible = false;
            proverka();
        }

        private void knop5_Click(object sender, RoutedEventArgs e)
        {
            knop5.Content = "0";
            knop5.IsHitTestVisible = false;
            proverka();
        }

        private void knop6_Click(object sender, RoutedEventArgs e)
        {
            knop6.Content = "0";
            knop6.IsHitTestVisible = false;
            proverka();
        }

        private void knop7_Click(object sender, RoutedEventArgs e)
        {
            knop7.Content = "0";
            knop7.IsHitTestVisible = false;
            proverka();
        }

        private void knop8_Click(object sender, RoutedEventArgs e)
        {
            knop8.Content = "0";
            knop8.IsHitTestVisible = false;
            proverka();
        }

        private void knop9_Click(object sender, RoutedEventArgs e)
        {
            knop9.Content = "0";
            knop9.IsHitTestVisible = false;
            proverka();
        }
    }
}
