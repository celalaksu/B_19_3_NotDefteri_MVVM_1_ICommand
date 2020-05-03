using NotDefteri.Modeller;
using System.Windows.Input;
using Xamarin.Forms;

namespace NotDefteri.GorunumModelleri
{
    public class NotGirisPageGM2 : TemelGorunumModeli
    {
        public string DosyaAdi { get; set; }

        private string notMetni;

        public string NotMetni
        {
            get { return notMetni; }
            set
            {
                notMetni = value;
                Notum = new Notlar()
                {
                    DosyaAdi = this.DosyaAdi,
                    NotMetni = this.NotMetni

                };
                OnPropertyChanged(nameof(NotMetni));
            }
        }

        private Notlar notum;

        public Notlar Notum
        {
            get { return notum; }
            set
            {
                notum = value;
                OnPropertyChanged(nameof(Notum));
            }
        }

        public ICommand KaydetCommand { get; }
        public ICommand SilCommand { get; }

        public NotGirisPageGM2()
        {
            KaydetCommand = new Command(() => Kaydet(Notum));
            SilCommand = new Command(() => Sil(Notum));
        }        

        public static void Kaydet(Notlar not)
        {
            Notlar.NotuKaydet(not);
        }

        public static void Sil(Notlar not)
        {
            Notlar.NotuSil(not);
        }
    }
}
