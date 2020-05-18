using System;
using System.Net;
using System.IO;
namespace NetStream
{

    class Program
    {
        static void Main(string[] args)
        {
            var uriBuilder = new UriBuilder("https://www.google.com.sg");
            Uri uri = uriBuilder.Uri;
            WebRequest request = WebRequest.Create(uri);
            using (WebResponse response = request.GetResponse())
            {
                var reader = new StreamReader(response.GetResponseStream());
                string s = reader.ReadToEnd();
                Console.WriteLine(s);
            }
        }
    }
}
