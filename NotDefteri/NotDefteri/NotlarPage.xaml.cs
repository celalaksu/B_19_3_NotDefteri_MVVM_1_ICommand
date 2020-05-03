using NotDefteri.GorunumModelleri;
using NotDefteri.Modeller;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NotDefteri
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NotlarPage : ContentPage
    {
        NotlarPageGorunumModeli npGorunumModeli;

        public NotlarPage()
        {
            InitializeComponent();
            npGorunumModeli = new NotlarPageGorunumModeli();
            BindingContext = npGorunumModeli;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var notlar = new List<Notlar>();

            notlar = Notlar.NotlariListele();

            notlarListView.ItemsSource = notlar
                .OrderByDescending(d => d.NotTarih)
                .ToList();
        }
        
        private async void notlarListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                var not = e.SelectedItem as Notlar;
                await Navigation.PushAsync(new NotGirisPage(not));                
            }
        }
    }
}