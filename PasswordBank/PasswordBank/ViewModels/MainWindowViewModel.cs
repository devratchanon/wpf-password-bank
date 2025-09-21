using PasswordBank.Common;

namespace PasswordBank.ViewModels;

public class MainWindowViewModel : ObservableObject
{
    private object _currentViewModel;
    public object CurrentViewModel
    {
        get => _currentViewModel;
        private set => SetProperty(ref _currentViewModel, value);
    }

    
    public MainWindowViewModel()
    {
        CurrentViewModel = new LoginViewModel(onSuccessLogin: NavigateToVault);
    }

    
    private void NavigateToLogin()
    {
        CurrentViewModel = new LoginViewModel(onSuccessLogin: NavigateToVault);
    }
    
    private void NavigateToVault()
    {
        CurrentViewModel = new VaultViewModel();
    }
}