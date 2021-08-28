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

namespace OrgaNICE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() // Passiert wenn Objekt erstellt wird / Konstruktor
        {
            InitializeComponent();

            MainPage mainPage = new MainPage(); // Anzeigen von Hauptseite in Fenster
            this.Content = mainPage;
        }

    }

}
