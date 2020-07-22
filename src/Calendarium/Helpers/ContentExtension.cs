using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Bb.Helpers
{

    internal static class ContentExtension
    {


        public static string LoadContentFromUrl(HttpWebRequest request)
        {

            string fileContents = string.Empty;
            System.Text.Encoding encoding = null;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = null;

                if (String.IsNullOrWhiteSpace(response.CharacterSet))
                {

                    readStream = new StreamReader(receiveStream);

                    //Ude.CharsetDetector cdet = new Ude.CharsetDetector();
                    //cdet.Feed(readStream);
                    //cdet.DataEnd();
                    //if (cdet.Charset != null)
                    //    encoding = System.Text.Encoding.GetEncoding(cdet.Charset);
                    //else
                    //    encoding = System.Text.Encoding.UTF8;
                    //fs.Position = 0;

                }
                else
                    readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));

                string data = readStream.ReadToEnd();

                response.Close();
                readStream.Close();
            }



            if (fileContents.StartsWith("ï»¿"))
                fileContents = fileContents.Substring(3);

            if (encoding != System.Text.Encoding.UTF8)
            {
                var datas = System.Text.Encoding.UTF8.GetBytes(fileContents);
                fileContents = System.Text.Encoding.UTF8.GetString(datas);
            }

            return fileContents;

        }


        public static HttpContent Serialize(this object self)
        {
            var payload = Newtonsoft.Json.JsonConvert.SerializeObject(self);
            HttpContent c = new StringContent(payload, Encoding.UTF8, Application.Json);
            return c;
        }

        public static void AddHeader(this HttpRequestHeaders self, Dictionary<string, object> dictionary)
        {

            foreach (var item in dictionary)
                if (item.Value != null)
                    self.Add(item.Key, item.Value.ToString());

        }


    }


}
