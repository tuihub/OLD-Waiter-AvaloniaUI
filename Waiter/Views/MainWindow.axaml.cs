using Avalonia.Controls;

namespace Waiter.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public async void UserCommand()
        {
            var loginWindow = new LoginWindow();
            await loginWindow.ShowDialog(this);
        }
    }
}
