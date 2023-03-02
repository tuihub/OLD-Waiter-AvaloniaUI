using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuiHub.Protos.Librarian.Sephirah.V1;
using static TuiHub.Protos.Librarian.Sephirah.V1.LibrarianSephirahService;

namespace WaiterLibrary
{
    public static partial class Sephirah
    {
        public static async Task GetTokenAsync(string username, string password)
        {
            var client = new LibrarianSephirahServiceClient(Global.Channel);
            await client.GetTokenAsync(new GetTokenRequest
            {
                Username = username,
                Password = password
            });
        }
    }
}
