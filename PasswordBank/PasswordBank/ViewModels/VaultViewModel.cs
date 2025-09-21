using PasswordBank.Common;

namespace PasswordBank.ViewModels;

public class VaultViewModel : ObservableObject
{
    public string SomeString { set; get; } = "Hello in the vault";
}