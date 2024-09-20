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
    /// Логика взаимодействия для TariffPage.xaml
    /// </summary>
    public partial class TariffPage : Page
    {
        Core db = new Core();
        List<Tariffs> arrayTariff;
        public TariffPage()
        {
            InitializeComponent();
            arrayTariff = db.context.Tariffs.ToList();
            TariffCombobox.ItemsSource = arrayTariff;
            TariffCombobox.DisplayMemberPath = "TarifName";
            TariffCombobox.SelectedValuePath = "IdTarif";
        }
        private void TariffButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new TariffPage());
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int idActiveTariff = Convert.ToInt32(TariffCombobox.SelectedValue);
            Console.WriteLine(idActiveTariff);
            int internetTariff, countMinutesTariff, countSMSTariff, salaryTariff;
            //internetTariff - инфа об интернете по выбранному тарифу
            //countMinutesTariff - инфа о кол-ве минут по тарифу
            //countSMSTariff - инфа о кол-ве смс по тарифу
            //salaryTariff - инфа о стоимости тарифа
            foreach (var item in arrayTariff)
            {
                if (item.IdTarif == idActiveTariff)
                {
                    internetTariff = Convert.ToInt32(item.Internet);
                    countMinutesTariff = Convert.ToInt32(item.CountMinutes);
                    countSMSTariff = Convert.ToInt32(item.CountSMS);
                    salaryTariff = Convert.ToInt32(item.Salary);
                    InternetSlider.Value= internetTariff;
                    CountBellSlider.Value= countMinutesTariff;
                    SmsSlider.Value= countSMSTariff;
                    PriceLabel.Content = $"{ salaryTariff} руб";
                }
            }
        }
    }
}
