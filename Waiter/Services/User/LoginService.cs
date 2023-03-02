using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Waiter.Models;
using WaiterLibrary;

namespace Waiter.Services.User
{
    public static class LoginService
    {
        public static async Task DoLogin(Login login)
        {
            try
            {
                await Sephirah.GetTokenAsync(login.Username, login.Password);
            }
            catch (RpcException ex)
            {
                var messageBox = MessageBox.Avalonia.MessageBoxManager.GetMessageBoxStandardWindow(
                    "Error", $"Exception: {ex.Message}");
                await messageBox.Show();
                return;
            }
            catch (Exception)
            {
                throw;
            }
            var messageBox1 = MessageBox.Avalonia.MessageBoxManager.GetMessageBoxStandardWindow(
                    "Login result", "Success");
            await messageBox1.Show();
        }
    }
}
