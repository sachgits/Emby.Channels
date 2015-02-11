﻿using MediaBrowser.Model.Querying;
using ServiceStack;

namespace MediaBrowser.Channels.HockeyStreams.RestfulService
{
    [Route(Helper.LoginRoute, "GET", Summary = "Returns info of an authenticated user")]
    public class LoginToken : IReturn<QueryResult<LoginTokenResponse>>
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
