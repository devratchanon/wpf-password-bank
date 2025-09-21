using System.Windows.Input;
using PasswordBank.Common;

namespace PasswordBank.ViewModels;

public class LoginViewModel : ObservableObject
{
    private readonly Action _onSuccessLogin;
    
    
    public ICommand LoginCommand { get; }
    
    
    public LoginViewModel(Action onSuccessLogin)
    {
        _onSuccessLogin = onSuccessLogin;

        LoginCommand = new RelayCommand(_ => Login());
    }


    private void Login()
    {
        _onSuccessLogin();
    }
}