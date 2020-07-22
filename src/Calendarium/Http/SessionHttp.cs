using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection;

namespace Bb.Http
{
    public class SessionHttp
    {

        public SessionHttp(Uri uriRoot)
        {

            var i = Assembly.GetEntryAssembly()?.GetName()?.Name;

            this.UserAgent = i ?? ".NET client";
            this.BaseAddress = uriRoot;
            this.Cookies = new Dictionary<string, Cookie>();
        }

        public CallHttp Get(Uri uri)
        {
            HttpWebRequest request = BuildRequest(uri);
            var c = new CallHttp();
            c.Run(this, request);
            return c;
        }

        private HttpWebRequest BuildRequest(Uri uri)
        {

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.CookieContainer = new CookieContainer();
            request.Timeout = this.Timeout;

            var headers = request.Headers;
            headers.Clear();

            request.UserAgent = this.UserAgent;

            //headers.Add(Constants.Headers.UserAgent, this.UserAgent);

            foreach (var item in this.Cookies)
                request.CookieContainer.Add(item.Value);

            return request;

        }

        public Uri BaseAddress { get; }

        public string UserAgent { get; private set; }

        public int Timeout { get; private set; } = 15000;

        public Dictionary<string, Cookie> Cookies { get; }

        //public ExtractDatas Templates { get; set; }

    }

}
