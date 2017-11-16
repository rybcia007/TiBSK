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
        public string RequestCode()
        {
            return "ExampleCode";
        }

        public void DoOAuth()
        {
            throw new NotImplementedException();
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
