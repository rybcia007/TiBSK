using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TiBSK.Helpers.OAuth2
{
    //https://pikfiszki.wordpress.com/2016/05/24/oauth2-napiszmy-jakis-kod/

    public class FacebookAuthorization : IAuthorization
    {
        public string ClientId
        {
            get
            {
                return "";
            }
        }

        public string ClientSecret
        {
            get
            {
                return "";
            }
        }

        public string RedirectURI
        {
            get
            {
                return "";
            }
        }

        public string GetCode()
        {
            throw new NotImplementedException();
        }

        public string ExchangeCodeForToken(string code)
        {
            throw new NotImplementedException();
        }
    }
}
