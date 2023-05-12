using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC03Module04
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class activity05 : ContentPage
    {
        List<Contacts> contacts;
        public activity05()
        {
            InitializeComponent();
            SetupData();
            ListView.ItemsSource = contacts;
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(ListView.SelectedItem != null)
            {
                var detailPage = new detailPage();
                detailPage.BindingContext = e.SelectedItem as Contacts;
                ListView.SelectedItem = null;
                await Navigation.PushModalAsync(detailPage);

            }
        }

        void SetupData()
        {
            contacts = new List<Contacts>();
            contacts.Add(new Contacts
            {
                FullName="Im Nayeon",
                Age=28,
                Occupation= "South Korean singer",
                Country="South Korea"
            });

            contacts.Add(new Contacts
            {
                FullName = "Yoo Jeongyeon",
                Age = 28,
                Occupation = "South Korean singer",
                Country = "South Korea"
            });

            contacts.Add(new Contacts
            {
                FullName = "Hirai Momo",
                Age = 27,
                Occupation = "South Korean singer",
                Country = "South Korea"
            });

            contacts.Add(new Contacts
            {
                FullName = "Minatozaki Sana",
                Age = 27,
                Occupation = "South Korean singer",
                Country = "South Korea"
            });

            contacts.Add(new Contacts
            {
                FullName = "Park Jihyo",
                Age = 27,
                Occupation = "South Korean singer",
                Country = "South Korea"
            });

            contacts.Add(new Contacts
            {
                FullName = "Myoui Mina",
                Age = 26,
                Occupation = "South Korean singer",
                Country = "South Korea"
            });

            contacts.Add(new Contacts
            {
                FullName = "Kim Dahyun",
                Age = 24,
                Occupation = "South Korean singer",
                Country = "South Korea"
            });

            contacts.Add(new Contacts
            {
                FullName = "Son Chaeyoung",
                Age = 24,
                Occupation = "South Korean singer",
                Country = "South Korea"
            });

            contacts.Add(new Contacts
            {
                FullName = "Chou Tzuyu",
                Age = 23,
                Occupation = "South Korean singer",
                Country = "South Korea"
            });
        }

    }
}