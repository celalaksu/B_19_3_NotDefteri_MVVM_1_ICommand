using NotDefteri.Modeller;
using System;
using System.Windows.Input;

namespace NotDefteri.GorunumModelleri.Komutlar
{
    public class KaydetCommand : ICommand
    {
        private NotGirisPageGorunumModeli NotGirisPageGorunumModeli { get; set; }

        public KaydetCommand(NotGirisPageGorunumModeli notGirisPageGorunumModeli)
        {
            NotGirisPageGorunumModeli = notGirisPageGorunumModeli;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            Notlar not = (Notlar)parameter;
            if (not != null)
            {
                if (string.IsNullOrEmpty(not.NotMetni))
                {
                    return false;
                }
                return true;
            }
            return false;
           
        }

        public void Execute(object parameter)
        {
            Notlar not = (Notlar)parameter;
            NotGirisPageGorunumModeli.Kaydet(not);
        }
    }
}
