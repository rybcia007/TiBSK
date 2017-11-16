using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiBSK.Helpers.OAuth2
{
    //https://pikfiszki.wordpress.com/2016/05/24/oauth2-napiszmy-jakis-kod/

    public class AutorizationCode
    {
        private const string CLIENT_ID = "";
        private const string CLIENT_SECRET = "";
        private const string REDIRECT_URL = "https://localhost:PORT";

        public string RequestCode()
        {
            return string.Empty;
        }

        public string ExchangeCodeForToken(string code)
        {
            if (!string.IsNullOrEmpty(code))
            {
                return "ExampleToken";
            }

            throw new NullReferenceException();
        }
    }
}
