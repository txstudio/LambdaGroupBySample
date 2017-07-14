using DataManager;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SingleCol
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderManager _manager;
            IEnumerable<OrderDetail> _details;


            _manager = new OrderManager();
            _details = _manager.GetOrderDetail();
            
            var _groupItems = _details
                            .GroupBy(x => x.Brand)
                            .Select(x=> new { Brand = x.Key })
                            .ToArray();

            foreach (var _item in _groupItems)
            {
                Console.WriteLine(_item.Brand);
            }

            Console.WriteLine("press any key to exit");
            Console.ReadKey();
        }
    }
}