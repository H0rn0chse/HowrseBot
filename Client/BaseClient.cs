using System;
using System.Net;

namespace HowrseBot.Client
{
    public class BaseClient : WebClient
    {
        protected CookieContainer CookieContainer;
        protected Uri ResponseUri;
        protected Uri RequestUri;

        protected override WebRequest GetWebRequest(Uri address)
        {
            base.Headers.Add("pragma", "no-cache");
            base.Headers.Add("Cache-Control", "no-cache");
            base.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; WOW64; rv:49.0) Gecko/20100101 Firefox/49.0");
            base.Headers.Add("Content-Type", "application/x-www-form-urlencoded");

            WebRequest request = base.GetWebRequest(address);
            RequestUri = request.RequestUri;
            if (request is HttpWebRequest)
            {
                (request as HttpWebRequest).CookieContainer = CookieContainer;
            }
            HttpWebRequest httpRequest = (HttpWebRequest)request;
            httpRequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            return httpRequest;
        }

        protected override WebResponse GetWebResponse(WebRequest request)
        {
            WebResponse response = base.GetWebResponse(request);
            ResponseUri = response.ResponseUri;
            if (response is HttpWebResponse)
            {
                CookieContainer.Add((response as HttpWebResponse).Cookies);
            }
            return response;
        }
    }
}
