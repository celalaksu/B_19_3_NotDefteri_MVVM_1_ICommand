using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace NotDefteri.GorunumModelleri.Komutlar
{
    public class SecDuzenleCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public NotlarPageGorunumModeli NotlarPageGM { set; get; }

        public SecDuzenleCommand(NotlarPageGorunumModeli notlarPageGM)
        {
            NotlarPageGM = notlarPageGM;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            NotlarPageGM.SecDuzenle();
        }
    }
}
