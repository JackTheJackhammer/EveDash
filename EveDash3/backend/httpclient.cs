using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Diagnostics;
namespace EveDash3.backend.httpclient
{
    public static class LocalWebClient
    {
        public static readonly HttpClient client = new HttpClient();
    }
}
