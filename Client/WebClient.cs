using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HowrseBot.Client
{
    public sealed class Client : BaseClient
    {
        private static readonly Client instance = new Client();

        private Client() { }

        public static Client Instance
        {
            get
            {
                return instance;
            }
        }
//        public bool checkUfo { get; set; }

        public Client(bool checkUfo, string startUrl)
            : this(new CookieContainer())
        {
//            this.checkUfo = checkUfo;
            BaseAddress = startUrl;
        }

        public Client(CookieContainer cookies)
        {
            if (BaseAddress == "")
            {
                BaseAddress = "https://www.howrse.de/";
            }
            CookieContainer = cookies;
            RequestUri = new Uri(BaseAddress);
            ResponseUri = new Uri(BaseAddress);

            Proxy = null;
            UseDefaultCredentials = true;
            CachePolicy = new System.Net.Cache.RequestCachePolicy(System.Net.Cache.RequestCacheLevel.NoCacheNoStore);
            DownloadString(BaseAddress);
        }

        public string Send(string method, string url, string data)
        {
            string res = "";
            switch(method)
            {
                case "POST":
                    res = UploadString(url, "POST", Uri.EscapeUriString(data));
                    break;
                case "GET":
                    res = DownloadString(url + Uri.EscapeUriString(data));
                    break;
            }
            res.Replace("\\", "");

            return res;
        }
    }
}
