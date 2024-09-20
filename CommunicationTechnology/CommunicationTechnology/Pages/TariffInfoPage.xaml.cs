using CommunicationTechnology.Models;
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

namespace CommunicationTechnology.Pages
{
    /// <summary>
    /// Логика взаимодействия для TariffInfoPage.xaml
    /// </summary>
    public partial class TariffInfoPage : Page
    {
        Core db = new Core();
        List<Tariffs> arrayTariff;
        List<Services> arrayServices;
        public TariffInfoPage()
        {
            InitializeComponent();
            arrayTariff = db.context.Tariffs.ToList();
            TariffDataGrid.ItemsSource = arrayTariff;
        }
    }
}
