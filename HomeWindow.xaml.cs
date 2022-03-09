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

namespace OrgaNICE
{
    /// <summary>
    /// Interaction logic for HomeWindow.xaml
    /// </summary>
    public partial class HomeWindow : Window
    {
        public HomeWindow()
        {
            InitializeComponent();

            // Datum und Wochentag Anzeige
            var time = DateTime.Today;
            var weekday = time.DayOfWeek;
            DatumBox.Text = weekday + ", " + time.ToShortDateString();

            // Kalender-Datum Default = Heute
            Calendar.SelectedDate = DateTime.Today;

            // Anzeigen von Hauptseite in Fenster
            MainPage mainPage = new MainPage(); 
            this.Content = mainPage;


        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ButtonZurueck_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonVor_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonSpeichern_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonLoeschen_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
