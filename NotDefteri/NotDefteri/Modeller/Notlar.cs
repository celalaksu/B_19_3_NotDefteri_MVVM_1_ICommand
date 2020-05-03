using System;
using System.Collections.Generic;
using System.IO;

namespace NotDefteri.Modeller
{
    public class Notlar //: INotifyPropertyChanged
    {
        //public event PropertyChangedEventHandler PropertyChanged;

        public string DosyaAdi { get; set; }
        public DateTime NotTarih { get; set; }

        private string notMetni;

        public string NotMetni
        {
            get { return notMetni; }
            set
            {
                notMetni = value;
               // OnPropertyChanged(nameof(NotMetni));
            }
        } 

        public static async void NotuKaydet(Notlar not)
        {
            if (string.IsNullOrWhiteSpace(not.DosyaAdi))
            {
                // Kaydet
                var dosyaAdi = Path.Combine(App.DosyaYolu, $"{Path.GetRandomFileName()}.notlar.txt");
                File.WriteAllText(dosyaAdi, (not.notMetni).ToString());
            }
            else
            {
                // Güncelle
                File.WriteAllText(not.DosyaAdi, (not.notMetni).ToString());
            }

            await App.Current.MainPage.Navigation.PopAsync();
        }

        public static async void NotuSil(Notlar not)
        {
            if (File.Exists(not.DosyaAdi))
            {
                File.Delete(not.DosyaAdi);
            }
            await App.Current.MainPage.Navigation.PopAsync();
        }

        public static List<Notlar> NotlariListele()
        {
            var notlar = new List<Notlar>();

            var dosyalar = Directory.EnumerateFiles(App.DosyaYolu, "*.notlar.txt");
            foreach (var dosyaadi in dosyalar)
            {
                notlar.Add(new Notlar
                {
                    DosyaAdi = dosyaadi,
                    NotMetni = File.ReadAllText(dosyaadi),
                    NotTarih = File.GetCreationTime(dosyaadi)
                });
            }

            return notlar;
        }
        /*
        protected void OnPropertyChanged(string ozellikAdi)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(ozellikAdi));
            }
        }
        */
    }
}
