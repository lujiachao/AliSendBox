using Aop.Api;
using Aop.Api.Request;
using Aop.Api.Response;
using Newtonsoft.Json;
using System;

namespace AliSendboxLogin
{
    class Program
    {
        public static string _merchantPriviateKey = @"MIIEpQIBAAKCAQEA1aCRkwKfJY2Fh6KLvNsTMUvAfmKR3YmKPBDP32Siz4OPtk/jkrumwfDzJ2Gbl17XvJwnyGpsh0nzrRh4hPMc3ohk9MuKFP+BEPNAnQgr+KL3hO9YLsJdXCc4BU0fD7164KM7weCFtiOQG+1WDg94SIlrxhfjgXlb9YTcXMxLSjcmYUNgFKcVxmXcjPNcr7fsqOcyQVbUjXuVH4BUJcAP4K4dtt/VQl7/95KbgoHEUW0Hwbe3eZwUl2X5CwdB+cleFKKRJ8eC14xWIh3M4XFs/YeSSuwoJM+mhJMIQZOVZ/ciCMXFTtnvvIKwOJR63nTKMdK4oP3ZtMKATlTQh6o+EQIDAQABAoIBACuWg513X3mOErzGEbULDjN0vWYMPq7xLV9sHr36Dq5ArcYJLun1l+TigPp8E/8ivuohAo0GCfbgw/OBlrWp1S4irla0YQw/xdnriDeCP1aQCej53QhNaDcxWWDbh4bypmvHYp4AbcfoIbNRDcn4phZG09KrdSQp2vWRklTs6j/N+Xsnc+Mz9d0XvrfLmYxlyp1L+OQcz6EYFvu/q9nEqNJ0vypSiyadnGs1ZTPhpm5btduxhVxYqk9aG8k1id2J7npZqPDjrliSBPwKQZHkk1I6VckK3IHJaM6tew3vtYZipehFu6mb4O/2x1kvvwOXDOhPvOpywh4Rg98D42n4SAECgYEA6/k4NBQjTKw3Ycech4nmWBBrT+sDtFj4w677paD7sXO86AGldsxC4vOkCbvMoc61hYxA3xFy/3t82PH3yhSRsIx7kqCFajgg4bn/nE1+bfWw7oWIBxTwCXGks/KIvB189/mhplpIfUBdMsFFGEbZprVfWUY0EoJiwwUOjmr5wvECgYEA58HaBvbK1FbM7ESk1vxTebv3cGM72d6/xc2Cd/ezZUIHT02CP1k5sN8jyIFF+dj6qc+gov8OiR/O4CsbgkBFxJOPTpR+h+K5iNBHSAIG9bYFgVKqPq9s2aU6Qu/NmMWwEc367FmVTc6gVZHSyfwwm/SWzffHeE5BYJ3lzNXv7SECgYEAh5eK/hHcPsBuilcC0LcijtPQdfmbBVRijT7NBt08Azl4APCBPYQdov9Q8O7ipM98aqKu2/7Qz5ELqjVPpuSu2n2+vABU6TYbXtlb0VqOHW0iH8zG3xre2u5cL7Jbc4yWNH9SrZ4PLTmA1BtOMqbzheGOSmQWo9QcH+eV96vsnGECgYEA5uT2IAwOhcC4xweYpuubCuRfICRtg6FttFcMDhPFMjO3bqXNBuoRFQsq7l8E5WfsS/QkmV+9DpaXGDU6YelA2RkeJG7DJQSYThsbeT0zy+b90xsVrABAVRJNWlTpo7QIt6Rcws55dpxOlxICTOQpVac3+5pJq61jayvEv+/A6qECgYEA6BlYrfyFxcTupOvAzWduaDVi33G7Bm6X0pElwhy7JNgvMwTn/EEjw0gwK4pnu9ZGTEeWSiVP0kEVTzXt7d+LHEbEs7joB6YAfU9bs0zOaygDfYEewzU83vx8d+XHWlmZNkyCGFJStLKYsDslXjPyWbaZiC+eu9MqBQh1LBQl1xQ=";

        public static string _aliPublicKey = @"MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAsHDM6dhs5ozgID+GGRnRWp+oa9+neMr/dH0lCJMTNJ8xLWy7zHt+RUxcq/CQ8BRnLULg4M5nD0b77CJwprXHYChsyTI0Yqz3v2Y33AokzweeRH+yip8xOCEon2L5WEE8mLOlTr1sN45mYUJDEsbRb/oFkFSwt0QSdTaWVM0PVQbmFFdnZ8xplhl+HO6a/SPk+I3u5hqORBWI1s1jDcONFnlD98gJIrU5CCnyNJCO5OUYKjRr8Isc4qrX1an6JREuiJm637xzTiD1Im99kEK6iB1pOp6Fj/pc6/gSZ2Hv4oxAfCIcqNl/vYtcDePIEXKSpHZWvCSJPOm8jSB2HypP4wIDAQAB";
        static void Main(string[] args)
        {
            IAopClient client = new DefaultAopClient("https://openapi.alipaydev.com/gateway.do", "2016091400507039", _merchantPriviateKey, "json", "1.0", "RSA2", _aliPublicKey, "utf-8", false);
            AuthInfo(client);
            //实例化具体API对应的request类,类名称和接口名称对应,当前调用接口名称如：alipay.open.public.template.message.industry.modify 

            Console.WriteLine("Hello World!");
        }

        //public async Task<string> GetAliAccessToken(string appId, string method, string timestamp, string forma = "JSON",string charset = "utf-8",string sign_type = "RSA2", string version = "1.0")        {

        //}

        public static void AuthInfo(IAopClient client)
        {
            AlipayUserInfoAuthRequest request = new AlipayUserInfoAuthRequest();
            InfoAuth infoAuth = new InfoAuth()
            {
                Scopes = "auth_base",
                State = Convert.ToBase64String(System.Text.Encoding.Default.GetBytes(Guid.NewGuid().ToString())),
                Is_Mobile = "true",
                Auth_Type = "Identity",
                Cert_Type = "IDENTITY_CARD",
                Cert_No = "",
                Real_Name = ""
            };
            request.BizContent = JsonConvert.SerializeObject(infoAuth);
            AlipayUserInfoAuthResponse response = client.Execute(request);
            Console.WriteLine(response.Body);
        }

        public static void OauthToken(IAopClient client)
        {
            AlipayOpenPublicTemplateMessageIndustryModifyRequest request = new AlipayOpenPublicTemplateMessageIndustryModifyRequest();
            //SDK已经封装掉了公共参数，这里只需要传入业务参数
            //此次只是参数展示，未进行字符串转义，实际情况下请转义
            AuthLoginRequest authLoginRequest = new AuthLoginRequest()
            {
                grant_type = "authorization_code",
                code = string.Empty,
                refresh_token = string.Empty,
                method = "alipay.system.oauth.token"
            };
            request.BizContent = JsonConvert.SerializeObject(authLoginRequest);
            AlipayOpenPublicTemplateMessageIndustryModifyResponse response = client.Execute(request);
        }
    }
}
