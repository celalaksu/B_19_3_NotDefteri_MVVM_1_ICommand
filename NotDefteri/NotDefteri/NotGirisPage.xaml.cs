using NotDefteri.GorunumModelleri;
using NotDefteri.Modeller;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NotDefteri
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NotGirisPage : ContentPage
    {
        //NotGirisPageGorunumModeli gorunumModeli = new NotGirisPageGorunumModeli();
        NotGirisPageGM2 gorunumModeli = new NotGirisPageGM2();

        public NotGirisPage(Notlar gelenNot)
        {
            InitializeComponent(); 
            if (gelenNot != null)
            {
                gorunumModeli.NotMetni = gelenNot.NotMetni;                
                gorunumModeli.DosyaAdi = gelenNot.DosyaAdi;
            }
            BindingContext = gorunumModeli;
        }

        public NotGirisPage()
        {
            InitializeComponent();
            BindingContext = gorunumModeli;
        }
    }
}