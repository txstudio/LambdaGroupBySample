using DataManager;
using System;
using System.Linq;
using System.Collections.Generic;

namespace MultipleCol
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
                                .GroupBy(x => new { x.Brand, x.Quantity })
                                .Select(x => new { Brand = x.Key.Brand, Quantity = x.Key.Quantity })
                                .ToArray();

            Console.WriteLine("Qty\tBrand");
            Console.WriteLine("--------------------");
            foreach (var _item in _groupItems)
            {
                Console.WriteLine(
                    String.Format("{0}\t{1}"
                                    , _item.Quantity
                                    , _item.Brand)
                    );
            }
            Console.WriteLine("--------------------");

            Console.WriteLine("press any key to exit");
            Console.ReadKey();
        }
    }
}