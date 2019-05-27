using System;
using System.Collections.Generic;
using System.Text;

namespace AliSendboxLogin
{
    public class AuthLoginRequest
    {
        public string grant_type
        {
            get; set;
        }

        public string code
        {
            get; set;
        }

        public string refresh_token
        {
            get; set;
        }

        public string method
        {
            get; set;
        }
    }
}
