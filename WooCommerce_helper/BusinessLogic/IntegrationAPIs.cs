using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WooCommerce_helper.Models;

namespace WooCommerce_helper.BusinessLogic
{
    public class IntegrationAPIs
    {
        public string WooCommerceGetOrders_RespSerialize(Root jsonObj)
        {
            return JsonConvert.SerializeObject(jsonObj);
        }

        public Root WooCommerceGetOrders_RespDeserialize(string jsonString)
        {
            return JsonConvert.DeserializeObject<Root>(jsonString);
        }

        public string BillingSerialize(Billing jsonObj)
        {
            return JsonConvert.SerializeObject(jsonObj);
        }

        public Billing BillingDeserialize(string jsonString)
        {
            return JsonConvert.DeserializeObject<Billing>(jsonString);
        }

        public string CollectionSerialize(Collection jsonObj)
        {
            return JsonConvert.SerializeObject(jsonObj);
        }

        public Collection CollectionDeserialize(string jsonString)
        {
            return JsonConvert.DeserializeObject<Collection>(jsonString);
        }

        public string CustomerSerialize(Customer jsonObj)
        {
            return JsonConvert.SerializeObject(jsonObj);
        }

        public Customer CustomerDeserialize(string jsonString)
        {
            return JsonConvert.DeserializeObject<Customer>(jsonString);
        }

        public string ImageSerialize(Image jsonObj)
        {
            return JsonConvert.SerializeObject(jsonObj);
        }

        public Image ImageDeserialize(string jsonString)
        {
            return JsonConvert.DeserializeObject<Image>(jsonString);
        }

        public string LineItemSerialize(LineItem jsonObj)
        {
            return JsonConvert.SerializeObject(jsonObj);
        }

        public LineItem LineItemDeserialize(string jsonString)
        {
            return JsonConvert.DeserializeObject<LineItem>(jsonString);
        }

        public string LinksSerialize(Links jsonObj)
        {
            return JsonConvert.SerializeObject(jsonObj);
        }

        public Links LinksDeserialize(string jsonString)
        {
            return JsonConvert.DeserializeObject<Links>(jsonString);
        }

        public string MetaDataSerialize(MetaData jsonObj)
        {
            return JsonConvert.SerializeObject(jsonObj);
        }

        public MetaData MetaDataDeserialize(string jsonString)
        {
            return JsonConvert.DeserializeObject<MetaData>(jsonString);
        }

        public string SelfSerialize(Self jsonObj)
        {
            return JsonConvert.SerializeObject(jsonObj);
        }

        public Self SelfDeserialize(string jsonString)
        {
            return JsonConvert.DeserializeObject<Self>(jsonString);
        }

        public string ShippingSerialize(Shipping jsonObj)
        {
            return JsonConvert.SerializeObject(jsonObj);
        }

        public Shipping ShippingDeserialize(string jsonString)
        {
            return JsonConvert.DeserializeObject<Shipping>(jsonString);
        }

        public string ShippingLineSerialize(ShippingLine jsonObj)
        {
            return JsonConvert.SerializeObject(jsonObj);
        }

        public ShippingLine ShippingLineDeserialize(string jsonString)
        {
            return JsonConvert.DeserializeObject<ShippingLine>(jsonString);
        }

        public string TaxisSerialize(Taxis jsonObj)
        {
            return JsonConvert.SerializeObject(jsonObj);
        }

        public Taxis TaxisDeserialize(string jsonString)
        {
            return JsonConvert.DeserializeObject<Taxis>(jsonString);
        }

        public string TaxLineSerialize(TaxLine jsonObj)
        {
            return JsonConvert.SerializeObject(jsonObj);
        }

        public TaxLine TaxLineDeserialize(string jsonString)
        {
            return JsonConvert.DeserializeObject<TaxLine>(jsonString);
        }
    }
}
