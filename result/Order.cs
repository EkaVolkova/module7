using System;

namespace result
{

    /// <summary>
    /// Описание товара
    /// </summary>
    class Product
    {
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; }
        public double Price { get; }
    }

    /// <summary>
    /// Класс заказа
    /// </summary>
    /// <typeparam name="TDelivery"></typeparam>
    class Order<TDelivery> where TDelivery : Delivery<Address, Enum>
    {
        /// <summary>
        /// Доставка
        /// </summary>
        public TDelivery Delivery;

        /// <summary>
        /// Номер заказа
        /// </summary>
        public uint Number { get; }

        /// <summary>
        /// Общее количество заказов
        /// </summary>
        static private uint CountOrders = 0;

        /// <summary>
        /// состав заказа
        /// </summary>
        public Product[] Goods;

        /// <summary>
        /// конструктор, принимающий состав заказа и способ доставки
        /// </summary>
        /// <param name="goods">список товаров</param>
        /// <param name="delivery">данные о доставке</param>
        public Order(Product[] goods, TDelivery delivery)
        {
            Goods = (Product[])goods.Clone();
            CountOrders++;
            Number = CountOrders;
            Delivery = delivery;
        }

        /// <summary>
        /// Вывод адреса в консоль
        /// </summary>
        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);
        }

        
    }
}
