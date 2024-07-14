using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LoginForm.Services;

namespace LoginForm;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private IUserService _userService; 
    public MainWindow(IUserService userService)
    {
        _userService = userService;
        
        InitializeComponent();
        
        
        loginPage.SetMainWindow(this,userService);
        SignUpPage.SetMainWindow(this,userService);
    }
}