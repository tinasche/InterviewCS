using System.Runtime.InteropServices;

var myOrders = new Order[]
{
    new Order("sadza and beef stew", 3, 80),
    new Order("rice and beef stew", 2, 85),
    new Order("chips and chicken", 1, 43),
    new Order("rice and truffles", 1, 80),
    new Order("spaghetti and white sauce", 4, 70),
    new Order("samp and turkey", 2, 64)
};

var ordersSpan = CollectionsMarshal.AsSpan<Order>();

var lessThan2Orders = from orderItem in myOrders
                      where orderItem.quantity >= 2
                      orderby orderItem.orderName
                      select orderItem;

foreach (var item in lessThan2Orders)
{
    Console.WriteLine(item);
}


record Order(string orderName, byte quantity, float nutValue);
