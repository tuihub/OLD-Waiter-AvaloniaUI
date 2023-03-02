using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Waiter.Models;
using Waiter.Services.User;

namespace Waiter.ViewModels
{
    public class LoginWindowViewModel : ViewModelBase
    {
        private readonly Login _login;
        public LoginWindowViewModel()
        {
            _login = new Login("", "");
            LoginCommand = ReactiveCommand.Create(async () => await LoginService.DoLogin(_login));
        }
        public string Username => _login.Username;
        public string Password => _login.Password;

        public ICommand LoginCommand { get; }
    }
}
