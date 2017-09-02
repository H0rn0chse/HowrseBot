using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowrseBot.Client
{
    //Multithreaded Singleton
    //https://msdn.microsoft.com/en-us/library/ff650316.aspx

    public sealed class HTMLConverter
	{
        private static volatile HTMLConverter instance;
        private static object syncRoot = new Object();

        private HTMLConverter()
        {

        }

        public static HTMLConverter Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new HTMLConverter();
                    }
                }

                return instance;
            }
        }

        internal static bool TryLogin(string name, string password)
        {
            return true;
        }
    }
}
/*private bool CheckUfo(string html)
        {
            if (HTMLConverter.ConvertToBool("UfoFound", html))
            {
                string url = HTMLConverter.ConvertToString("UfoUrl", html);
                url = (url == "" ? "/member/ufo/catch" : url);
                string reqData = "ufo=" + HTMLConverter.ConvertToString("UfoId", html);

                string res = UploadString(url, "POST", Uri.EscapeUriString(reqData));
                Log.Append(res, "Ufo" + "||" + url + "||" + reqData);
                Console.WriteLine("INFO - Ufo found");
                return true;
            }
            return false;
        }*/
