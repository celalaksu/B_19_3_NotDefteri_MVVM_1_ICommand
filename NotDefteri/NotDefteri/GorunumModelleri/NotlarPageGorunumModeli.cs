using NotDefteri.GorunumModelleri.Komutlar;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotDefteri.GorunumModelleri
{
    public class NotlarPageGorunumModeli
    {
        public NotGirisBagCommand NotGirisBagCommand { get; set; }
        

        public NotlarPageGorunumModeli()
        {
            NotGirisBagCommand = new NotGirisBagCommand(this);
            
        }

        public async void MpyeGit()
        {
            await App.Current.MainPage.Navigation.PushAsync(new NotGirisPage());
        }

        public async void SecDuzenle()
        {
            await App.Current.MainPage.Navigation.PushAsync(new NotGirisPage());
            
        }
    }
}
