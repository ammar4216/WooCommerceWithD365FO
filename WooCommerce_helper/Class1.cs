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

        public string consumer_key;
        public string consumer_secret;

        public string getConsumerKey(string key)
        {
            consumer_key = key;
            return consumer_key;
        }

        public string getConsumerSecret(string key)
        {
            consumer_secret = key;
            return consumer_secret;
        }


        public ExampleConnectOauth()
        {
            aouth1 = new GenerateValuesRequest(consumer_key, consumer_secret, "", "", SignatureTypes.HMAC_SHA1, true, "1.0");
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
