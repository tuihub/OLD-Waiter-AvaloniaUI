using Avalonia.Controls;
using Avalonia.ReactiveUI;
using ReactiveUI;
using System.Threading.Tasks;
using Waiter.ViewModels;

namespace Waiter.Views
{
    public partial class MainWindow : ReactiveWindow<MainWindowViewModel>
    {
        public MainWindow()
        {
            InitializeComponent();
            this.WhenActivated(d => d(ViewModel!.ShowDialog.RegisterHandler(DoShowDialogAsync)));
        }

        private async Task DoShowDialogAsync(InteractionContext<MainWindowViewModel, LoginWindowViewModel?> interaction)
        {
            var loginDialog = new LoginWindow();
            //loginDialog.DataContext = interaction.Input;
            loginDialog.DataContext = new LoginWindowViewModel();

            var result = await loginDialog.ShowDialog<LoginWindowViewModel>(this);
            interaction.SetOutput(result);
        }
    }
}
