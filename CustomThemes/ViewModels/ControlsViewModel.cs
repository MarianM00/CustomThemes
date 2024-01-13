using CustomThemes.Commands;
using System.Windows;
using System.Windows.Input;

namespace CustomThemes.ViewModels
{
    public class ControlsViewModel : ViewModelBase
    {
        public ICommand CloseCommand { get; }
        public ICommand AutoMinimizeCommand { get; }
        public ICommand MinimizeCommand { get; }

        public ControlsViewModel()
        {
            CloseCommand = new RelayCommand(CloseWindow);
            AutoMinimizeCommand = new RelayCommand(AutoMinimize);
            MinimizeCommand = new RelayCommand(Minimize);
        }

        private void CloseWindow(object parameter)
        {
            if (parameter is Window window)
                window.Close();
        }

        private void AutoMinimize(object parameter)
        {
            if (parameter is Window window)
                MaximizeRestore(window);
        }

        private void Minimize(object parameter)
        {
            if (parameter is Window window)
                window.WindowState = WindowState.Minimized;
        }

        private void MaximizeRestore(Window window)
        {
            if (window == null)
                return;

            switch (window.WindowState)
            {
                case WindowState.Normal:
                    window.WindowState = WindowState.Maximized;
                    break;
                case WindowState.Minimized:
                case WindowState.Maximized:
                    window.WindowState = WindowState.Normal;
                    break;
            }
        }

    }
}
