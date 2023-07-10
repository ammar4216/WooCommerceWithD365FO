using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Text;
using System.Collections;
using WooCommerce_helper;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {


            ExampleConnectOauth exmp = new ExampleConnectOauth();

            var result = exmp.GetValuesRequestOauth("http://202.47.59.85:802/mywebsite/wp-json/wc/v3/orders", "GET");

            var jsonRes = JsonConvert.SerializeObject(result);

            OAuthContract oauthContract = JsonConvert.DeserializeObject<OAuthContract>(jsonRes);

            string OAuthHeader = String.Format("oauth_version=\"1.0\",oauth_consumer_key=\"{0}\",oauth_signature_method=\"{1}\",oauth_signature=\"{2}\",oauth_timestamp=\"{3}\",oauth_nonce=\"{4}\"", oauthContract.oauth_consumer_key, oauthContract.oauth_signature_method, oauthContract.oauth_signature, oauthContract.oauth_timestamp, oauthContract.oauth_nonce);
        }
    }
}
