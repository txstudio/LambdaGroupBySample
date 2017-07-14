using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataManager
{
    public sealed class OrderDetail
    {
        public int No { get; set; }

        public string Brand { get; set; }
        public string Name { get; set; }
        public string SpecName { get; set; }

        public int Quantity { get; set; }
        public Nullable<Decimal> UnitPrice { get; set; }
    }


    public sealed class OrderManager
    {
        const string encoding_name = "utf-8";
        const string json_path = "order.json";

        private Encoding _encoding;

        public OrderManager()
        {
            this._encoding = Encoding.GetEncoding(encoding_name);
        }
        


        public IEnumerable<OrderDetail> GetOrderDetail()
        {
            var _json = this.Json;
            var _items = JsonConvert.DeserializeObject<IEnumerable<OrderDetail>>(_json);

            return _items;
        }

        private string Json
        {
            get
            {
                return @"[
  {
    ""No"": 1,
    ""Name"": ""Intel Core i7 7700K"",
    ""Brand"": ""Intel"",
    ""SpecName"": ""PCS"",
    ""Quantity"": 2,
    ""UnitPrice"": 11500
  },
  {
    ""No"": 2,
    ""Name"": ""Intel Core i9 7900X"",
    ""Brand"": ""Intel"",
    ""SpecName"": ""PCS"",
    ""Quantity"": 1,
    ""UnitPrice"": 33490
  },
  {
    ""No"": 3,
    ""Name"": ""Intel Core i5 7400"",
    ""Brand"": ""Intel"",
    ""SpecName"": ""PCS"",
    ""Quantity"": 3,
    ""UnitPrice"": 6300
  },
  {
    ""No"": 4,
    ""Name"": ""AMD Ryzen 7-1700"",
    ""Brand"": ""AMD"",
    ""SpecName"": ""PCS"",
    ""Quantity"": 1,
    ""UnitPrice"": 11550
  },
  {
    ""No"": 5,
    ""Name"": ""AMD Ryzen 5-1600"",
    ""Brand"": ""AMD"",
    ""SpecName"": ""PCS"",
    ""Quantity"": 3,
    ""UnitPrice"": 6300
  },
  {
    ""No"": 6,
    ""Name"": ""Kingston 8GB DDR3 1600"",
    ""Brand"": ""Kingston"",
    ""SpecName"": ""PCS"",
    ""Quantity"": 4,
    ""UnitPrice"": 1799
  },
  {
    ""No"": 7,
    ""Name"": ""Micron Curcial DDR4 2400/8GB"",
    ""Brand"": ""Micron"",
    ""SpecName"": ""PCS"",
    ""Quantity"": 4,
    ""UnitPrice"": 1799
  },
  {
    ""No"": 8,
    ""Name"": ""Kingston 4GB DDR3 1333"",
    ""Brand"": ""Kingston"",
    ""SpecName"": ""PCS"",
    ""Quantity"": 2,
    ""UnitPrice"": 1049
  },
  {
    ""No"": 9,
    ""Name"": ""Transcend JetRam 4GB DDR3 1600"",
    ""Brand"": ""Transcend"",
    ""SpecName"": ""PCS"",
    ""Quantity"": 2,
    ""UnitPrice"": 899
  }
]";
            }
        }


    }
}
