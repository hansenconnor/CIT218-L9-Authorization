using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DotNetOpenAuth.GoogleOAuth2;
using Microsoft.AspNet.Membership.OpenAuth;

namespace MVCDemo.App_Start
{
    public static class AuthConfig
    {
        public static void RegisterAuth()
        {
            GoogleOAuth2Client clientGoog = new GoogleOAuth2Client("628865352789-oomk71j3u8url8u7odav2jh6ogrgo88m.apps.googleusercontent.com", "f7FucqlP0BKch8NmbCVoX1Ky");
        IDictionary<string, string> extraData = new Dictionary<string, string>();
            OpenAuth.AuthenticationClients.Add("google", () => clientGoog, extraData);
        }
    }
}