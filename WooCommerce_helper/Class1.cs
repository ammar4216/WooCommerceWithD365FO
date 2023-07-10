using simple_client_oauth1;
using simple_client_oauth1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WooCommerce_helper
{
    public class ExampleConnectOauth
    {
        private readonly GenerateValuesRequest aouth1;

        public ExampleConnectOauth()
        {
            aouth1 = new GenerateValuesRequest("ck_707caa7a22d6e99ec26ef5c289fc5facb81dc83a", "cs_09f529496888dac95250e90d69bbb4109da95e48", "", "", SignatureTypes.HMAC_SHA1, true, "1.0");
        }
        public Dictionary<string, string> GetValuesRequestOauth(string url, string method)
        {
            return aouth1.GetParametersRequest(url, method);
        }

        public string GetUrlCompleteOauth(string url, string method)
        {
            return aouth1.GetHttpClienteUrl(url, method);
        }
    }
}
