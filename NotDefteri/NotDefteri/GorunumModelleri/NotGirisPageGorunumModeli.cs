using NotDefteri.Modeller;
using NotDefteri.GorunumModelleri.Komutlar;
using System.ComponentModel;

namespace NotDefteri.GorunumModelleri
{
    public class NotGirisPageGorunumModeli : INotifyPropertyChanged
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

        public KaydetCommand KaydetCommand { get; set; }

        public SilCommand SilCommand { get; set; }

        public NotGirisPageGorunumModeli()
        {
            KaydetCommand = new KaydetCommand(this);
            SilCommand = new SilCommand(this);
            
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
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
