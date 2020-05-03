using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace NotDefteri.GorunumModelleri.Komutlar
{
    public class NotGirisBagCommand : ICommand
    {
        public NotlarPageGorunumModeli NotlarPageGM {set; get;}

        public NotGirisBagCommand(NotlarPageGorunumModeli  notlarPageGM)
        {
            NotlarPageGM = notlarPageGM;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            NotlarPageGM.MpyeGit();
        }
    }
}
