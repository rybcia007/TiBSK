using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TiBSK.Helpers.OAuth2
{
    //https://pikfiszki.wordpress.com/2016/05/24/oauth2-napiszmy-jakis-kod/
    //https://auth0.com/docs/connections/social/facebook

    public class FacebookAuthorization : IAuthorization
    {
        public string ClientId
        {
            get
            {
                return "144687559490376";
            }
        }

        public string ClientSecret
        {
            get
            {
                return "d7af3ebd0316c38c38afb508b988f522";
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
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create("https://accounts.google.com/o/oauth2/token");
            webRequest.Method = "POST";

            return string.Empty;
        }

        public string ExchangeCodeForToken(string code)
        {
            throw new NotImplementedException();
        }
    }
}
