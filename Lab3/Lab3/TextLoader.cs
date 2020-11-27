using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    static class TextLoader
    {
        public static Stream GetStream(string path, out long length)
        {
            Stream result;

            var uri = new Uri(path);

            if (uri.IsFile)
            {
                length = new FileInfo(path).Length;
                result = new FileStream(path, FileMode.Open);
            }

            var webReq = WebRequest.Create(uri);
            using (var wr = webReq.GetResponse())
                length = long.Parse(wr.Headers.Get("Content-Length"));

            result = new WebClient().OpenRead(path);

            return result;
        }
    }
}
