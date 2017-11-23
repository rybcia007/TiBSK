using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiBSK.Helpers.OAuth2
{
    public interface IAuthorization
    {
        String ClientId { get; }
        String ClientSecret { get; }
        String RedirectURI { get; }
        String GetCode();
        String ExchangeCodeForToken(string code);
    }
}
