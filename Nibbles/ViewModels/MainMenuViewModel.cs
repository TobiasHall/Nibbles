using System;
using System.Collections.Generic;
using System.Text;

namespace Nibbles
{
    public partial class MainMenuViewModel : BaseViewModel
    {
        public MainMenuViewModel()
        {
            GameViewCommand = new RelayCommand(GetGameView, CanExecute);
        }
    }
}
