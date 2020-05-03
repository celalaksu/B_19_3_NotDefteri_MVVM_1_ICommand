using NotDefteri.Modeller;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace NotDefteri.GorunumModelleri.Komutlar
{
    public class SilCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private NotGirisPageGorunumModeli NotGirisPageGorunumModeli { get; set; }

        public SilCommand(NotGirisPageGorunumModeli notGirisPageGorunumModeli)
        {
            NotGirisPageGorunumModeli = notGirisPageGorunumModeli;
        }

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
            NotGirisPageGorunumModeli.Sil(not);
        }
    }
}
