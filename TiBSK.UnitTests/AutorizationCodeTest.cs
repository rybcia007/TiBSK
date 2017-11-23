using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TiBSK.Helpers.OAuth2;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Net.Http;

namespace TiBSK.UnitTests
{
    //https://stackoverflow.com/questions/24057939/login-using-google-oauth-2-0-with-c-sharp

    [TestClass]
    public class AutorizationCodeTest
    {

        [TestMethod]
        public void RequestCode_GetRequestCode_ReturnEmptyCode()
        {
            var _obj = new FacebookAuthorization();

         

           
        }

        [TestMethod]
        public void RequestCode_GetRequestCode_ReturnCode()
        {
            var _obj = new FacebookAuthorization();

           
        }

        [TestMethod]
        [DataRow(null)]
        [ExpectedException(typeof(NullReferenceException))]
        public void ExchangeCodeForToken_CheckExchangeUserCodeForToken_ReturnNull(string code)
        {
            var _obj = new FacebookAuthorization();

            var token = _obj.ExchangeCodeForToken(code);
        }

        [TestMethod]
        [DataRow("123#Casda")]
        public void ExchangeCodeForToken_CheckExchangeUserCodeForToken_ReturnToken(string code)
        {
            var _obj = new FacebookAuthorization();

            var token = _obj.ExchangeCodeForToken(code);

            Assert.AreNotEqual(token, string.Empty);
        }
    }
}
