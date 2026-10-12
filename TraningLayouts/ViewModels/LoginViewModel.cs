using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TraningLayouts.Windows;

namespace TraningLayouts.ViewModels;

public partial class LoginViewModel : ViewModelBase
{
    [ObservableProperty] private string _email = "";
    [ObservableProperty] private string _password = "";

    // Без БД: войти можно с любыми данными, ФИО = введённый email
    [RelayCommand]
    private void Login()
    {
        if (Application.Current?.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            var loginWindow = desktop.MainWindow;
            desktop.MainWindow = new MainWindow()
            {
                DataContext = new MainWindowViewModel(Email),
            };
            desktop.MainWindow.Show();
            loginWindow?.Close();
        }
    }
}
