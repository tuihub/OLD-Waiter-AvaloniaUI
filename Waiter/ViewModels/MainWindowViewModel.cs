using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Text;
using System.Windows.Input;
using Waiter.Views;

namespace Waiter.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string Greeting => "Welcome to Avalonia!";
        public MainWindowViewModel()
        {
            ShowDialog = new Interaction<MainWindowViewModel, LoginWindowViewModel?>();
            UserCommand = ReactiveCommand.Create(async () =>
            {
                var result = await ShowDialog.Handle(this);
            });
        }

        public ICommand UserCommand { get; }
        public Interaction<MainWindowViewModel, LoginWindowViewModel?> ShowDialog { get; }
    }
}
