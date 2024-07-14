using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using LoginForm.Services;

namespace LoginForm.UI;

public partial class LoginPage : UserControl
{
    private MainWindow _mainWindow { get; set; }
    private IUserService _userService;
    public LoginPage()
    {
        InitializeComponent();
    }

    public void SetMainWindow(MainWindow mainWindow,IUserService userService)
    {
        _mainWindow = mainWindow;
        _userService = userService;
    }

    private async void Login_btn_OnClick(object sender, RoutedEventArgs e)
    {
        if (username_txt.Text != "" && password_txt.Password != "")
        {
            try
            {
                    if (await _userService.Login(username_txt.Text, password_txt.Password))
                    {
                        
                        // Keyingi page o'tamiz
                        MessageBox.Show("Welcome next page!");
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        else
        {
            MessageBox.Show("Iltimos maydonlarni to'ldiring!");
        }
    }
    

    private void SignUp_btn_OnClick(object sender, RoutedEventArgs e)
    {
        _mainWindow.LoginView.Visibility = Visibility.Collapsed;
        _mainWindow.SignUpView.Visibility = Visibility.Visible;
    }

 


    private void Show_btn_OnChecked(object sender, RoutedEventArgs e)
    {
        password_textbox.Text = password_txt.Password;
        password_txt.Visibility = Visibility.Collapsed;
        password_textbox.Visibility = Visibility.Visible;
    }

    private void Show_btn_OnUnchecked(object sender, RoutedEventArgs e)
    {
        password_txt.Password = password_textbox.Text;
        password_txt.Visibility = Visibility.Visible;
        password_textbox.Visibility = Visibility.Collapsed;
    }
}
