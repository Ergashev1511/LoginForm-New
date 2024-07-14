using System.Windows;
using System.Windows.Controls;
using LoginForm.Models;
using LoginForm.Services;

namespace LoginForm.UI;

public partial class SignUpPage : UserControl
{
    private MainWindow _mainWindow;
    private IUserService _userService;
    public SignUpPage()
    {
        InitializeComponent();
    }

    public void SetMainWindow(MainWindow mainWindow,IUserService userService)
    {
        _mainWindow = mainWindow;
        _userService = userService;
    }

    private async void SignUp_btn_OnClick(object sender, RoutedEventArgs e)
    {
        User user = new User()
        {
            FirstName = firstname_txt.Text,
            LastName = lastname_txt.Text,
            UserName = username_txt.Text,
        };
        if (emil_txt.Text.Contains("@gmail.com"))
        {
            user.Email = emil_txt.Text;
        }
        else
        {
            MessageBox.Show("Email xato kiritildi!");
        }
        if (ContainsUppercase(PasswordBox_txt1.Password) && ContainsDigit(PasswordBox_txt1.Password) &&
            PasswordBox_txt1.Password == PasswordBox_txt2.Password && PasswordBox_txt1.Password.Length>=8)
        {
            user.Password = PasswordBox_txt1.Password;
        }
        else
        {
            MessageBox.Show("Parol qo'yish uchun kamida 1 katta harf , 1 raqam  va 8 ta belgidan kam bo'lmasligi kerak!");
        }

        await _userService.AddUser(user);
        _mainWindow.SignUpView.Visibility = Visibility.Collapsed;
        _mainWindow.LoginView.Visibility = Visibility.Visible;

    }
    
    public  bool ContainsUppercase(string str)
    {
        foreach (char c in str)
        {
            if (char.IsUpper(c))
            {
                return true;
            }
        }
        return false;
    }
    
    public  bool ContainsDigit(string str)
    {
        foreach (char c in str)
        {
            if (char.IsDigit(c))
            {
                return true;
            }
        }
        return false;
    }
}