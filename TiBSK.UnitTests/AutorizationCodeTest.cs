using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TiBSK.Helpers.OAuth2;

namespace TiBSK.UnitTests
{
    [TestClass]
    public class AutorizationCodeTest
    {

        [TestMethod]
        public void RequestCode_GetRequestCode_ReturnEmptyCode()
        {
            var _obj = new AutorizationCode();

            string code = _obj.RequestCode();

            Assert.AreEqual(code, string.Empty);
        }

        [TestMethod]
        public void RequestCode_GetRequestCode_ReturnCode()
        {
            var _obj = new AutorizationCode();

            string code=_obj.RequestCode();

            //Assert.AreNotEqual(code, string.Empty);  od komentować gdy będzie już ciało metody zwracające/nie zawracające kodu
        }

        [TestMethod]
        [DataRow(null)]
        [ExpectedException(typeof(NullReferenceException))]
        public void ExchangeCodeForToken_CheckExchangeUserCodeForToken_ReturnNull(string code)
        {
            var _obj = new AutorizationCode();

            var token = _obj.ExchangeCodeForToken(code);
        }

        [TestMethod]
        [DataRow("123#Casda")]
        public void ExchangeCodeForToken_CheckExchangeUserCodeForToken_ReturnToken(string code)
        {
            var _obj = new AutorizationCode();

            var token = _obj.ExchangeCodeForToken(code);

            Assert.AreNotEqual(token, string.Empty);
        }
    }
}
