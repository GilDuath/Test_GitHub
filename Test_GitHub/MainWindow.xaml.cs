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

namespace Test_GitHub
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int counter = 0;
        private Combat combat;

        public MainWindow()
        {
            InitializeComponent();

            combat = new Combat("Midgard", "Staufenberg");

            this.DataContext = combat;
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            counter++;
            int rest = counter % 3;

            switch (rest)
            {
                case 0:
                    combat.Name = "Doppelkopf";
                    combat.Ort = "Lollar";
                    break;
                case 1:
                    combat.Name = "Risiko";
                    combat.Ort = "Gießen";
                    break;
                case 2:
                    combat.Name = "Midgard 1880";
                    combat.Ort = "Staufenberg, Lumdatalstrasse 4";
                    break;
                default:
                    break;
            }
        }
    }
}
