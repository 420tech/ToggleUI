namespace ToggleUI.ViewModels;

public partial class MainViewModel : BaseViewModel
{
    [ObservableProperty]
    bool isAddingUser;



    [RelayCommand]
    void ToggleEdit()
    {
        if (!IsAddingUser)
        {
            IsAddingUser = true;

        }
        else
        {
            IsAddingUser = false;

        }

        Debug.WriteLine($"Value of IsAddingUser = {IsAddingUser}");
    }
}
