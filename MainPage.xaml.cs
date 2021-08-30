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
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();

            // Datum und Wochentag Anzeige
            var time = DateTime.Today;
            var weekday = time.DayOfWeek;
            DatumBox.Text = weekday + ", " + time.ToShortDateString();

            // Kalender-Datum Default = Heute
            Calendar.SelectedDate = DateTime.Today;
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ButtonZurueck_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonVor_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

    }
}
