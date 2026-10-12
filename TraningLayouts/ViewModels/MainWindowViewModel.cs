using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TraningLayouts.Windows;

namespace TraningLayouts.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty] private string fullName = "";
    [ObservableProperty] private ViewModelBase currentViewModel = new HomeViewModel();
    [ObservableProperty] private string currentPage = "Home";

    public MainWindowViewModel(string fullName)
    {
        this.fullName = fullName;
    }

    public MainWindowViewModel()
    {
    }

    private void Open(string page, ViewModelBase viewModel)
    {
        CurrentPage = page;
        CurrentViewModel = viewModel;
    }

    [RelayCommand] private void Home() => Open("Home", new HomeViewModel());
    [RelayCommand] private void Projects() => Open("Projects", new ProjectsViewModel());
    [RelayCommand] private void Tasks() => Open("Tasks", new TasksViewModel());
    [RelayCommand] private void Calendar() => Open("Calendar", new CalendarViewModel());
    [RelayCommand] private void Teams() => Open("Teams", new TeamViewModel());
    [RelayCommand] private void Options() => Open("Options", new SettingsViewModel());
    [RelayCommand] private void Profile() => Open("Profile", new ProfileViewModel());

    [RelayCommand]
    private void Exit()
    {
        if (Application.Current?.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            var mainWindow = desktop.MainWindow;
            desktop.MainWindow = new LoginWindow()
            {
                DataContext = new LoginViewModel(),
            };
            desktop.MainWindow.Show();
            mainWindow?.Close();
        }
    }
}
