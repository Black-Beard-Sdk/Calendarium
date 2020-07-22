using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace Bb.Http
{
    public class CallHttp
    {

        public CallHttp()
        {
            this.Headers = new Dictionary<string, string>();
        }

        public void Run(SessionHttp context, HttpWebRequest request)
        {

            //this.RequestUri = request.RequestUri;
            //this.RequestMethod = request.Method;
            //this.RequestMethod = request.ContentType;
            //this.RequestMethod = request.Headers;
            //this.RequestMethod = request.Accept;
            //this.RequestMethod = request.AllowAutoRedirect;
            //this.RequestMethod = request.AuthenticationLevel;
            //this.RequestMethod = request.AutomaticDecompression;
            //this.RequestMethod = request.CachePolicy;
            //this.RequestMethod = request.ClientCertificates;
            //this.RequestMethod = request.Connection;
            //this.RequestMethod = request.ConnectionGroupName;
            //this.RequestMethod = request.ContentLength;
            //this.RequestMethod = request.ContentType;
            //this.RequestMethod = request.ContinueDelegate;
            //this.RequestMethod = request.ContinueTimeout;
            //this.RequestMethod = request.CookieContainer;
            //this.RequestMethod = request.ContentType;
            //this.RequestMethod = request.Date;
            //this.RequestMethod = request.Expect;
            //this.RequestMethod = request.Headers;
            //this.RequestMethod = request.ImpersonationLevel;
            //this.RequestMethod = request.KeepAlive;
            //this.RequestMethod = request.MaximumAutomaticRedirections;
            //this.RequestMethod = request.MaximumResponseHeadersLength;
            //this.RequestMethod = request.MediaType;
            //this.RequestMethod = request.Pipelined;
            //this.RequestMethod = request.PreAuthenticate;
            //this.RequestMethod = request.ProtocolVersion;
            //this.RequestMethod = request.Proxy;
            //this.RequestMethod = request.ReadWriteTimeout;
            //this.RequestMethod = request.Referer;
            //this.RequestMethod = request.SendChunked;
            //this.RequestMethod = request.ServerCertificateValidationCallback;
            //this.RequestMethod = request.ServicePoint;
            //this.RequestMethod = request.SupportsCookieContainer;
            //this.RequestMethod = request.Timeout;
            //this.RequestMethod = request.TransferEncoding;
            //this.RequestMethod = request.UnsafeAuthenticatedConnectionSharing;
            //this.RequestMethod = request.UseDefaultCredentials;
            //this.RequestMethod = request.UserAgent;

            HttpWebResponse response = null;

            try
            {
                response = (HttpWebResponse)request.GetResponse();
            }
            catch (Exception)
            {

                throw;
            }



            this.Result = response.StatusCode;
            this.CharacterSet = response.CharacterSet;
            this.ContentEncoding = response.ContentEncoding;

            if (response.StatusCode == HttpStatusCode.OK)
            {

                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = null;

                if (String.IsNullOrWhiteSpace(response.CharacterSet))
                {
                    readStream = new StreamReader(receiveStream);
                }
                else
                    readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));

                this.ResultBodyText = new StringBuilder(readStream.ReadToEnd());

                foreach (string headerKey in response.Headers.AllKeys)
                    this.Headers.Add(headerKey, response.Headers[headerKey]);

                foreach (Cookie cookie in response.Cookies)
                {
                    var c = new Cookie(cookie.Name, cookie.Value, cookie.Path, cookie.Domain)
                    {
                        Comment = cookie.Comment,
                        CommentUri = cookie.CommentUri,
                        Discard = cookie.Discard,
                        Expired = cookie.Expired,
                        HttpOnly = cookie.HttpOnly,
                        Expires = cookie.Expires,
                        Port = cookie.Port,
                        Secure = cookie.Secure,
                    };
                    if (context.Cookies.ContainsKey(c.Name))
                        context.Cookies[c.Name] = c;
                    else
                        context.Cookies.Add(c.Name, c);
                }

                response.Close();
                readStream.Close();

            }
        }

        public StringBuilder ResultBodyText { get; private set; }

        public HttpStatusCode Result { get; private set; }

        public string CharacterSet { get; private set; }

        public string ContentEncoding { get; private set; }

        public Dictionary<string, string> Headers { get; private set; }

    }

}
