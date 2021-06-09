using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Windows;

namespace Nibbles
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public MainWindow Main = (MainWindow)Application.Current.MainWindow;

        #region Commands
        public ICommand MainMenuViewCommand { get; set; }
        public ICommand ExitGameCommand { get; set; }
        public ICommand GameViewCommand { get; set; }

        #endregion


        public void GetMainMenuView(object parameter)
        {
            Main.Content = new MainMenuView();
        }
        public void CloseApplication(object parameter)
        {
            Main.Close();
        }
        public void GetGameView(object parameter)
        {
            Main.Content = new GameView();
        }

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public virtual bool CeckIfCanExecute(object parameter)
        {
            return false;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }
    }
}
