using Avalonia;
using Avalonia.Styling;
using CommunityToolkit.Mvvm.ComponentModel;

namespace TraningLayouts.ViewModels;

public partial class SettingsViewModel : ViewModelBase
{
    [ObservableProperty] private bool isDark = Application.Current?.ActualThemeVariant == ThemeVariant.Dark;

    partial void OnIsDarkChanged(bool value)
    {
        Application.Current!.RequestedThemeVariant = value ? ThemeVariant.Dark : ThemeVariant.Light;
    }
}
