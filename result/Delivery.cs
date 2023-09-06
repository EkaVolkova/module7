using System;

namespace result
{
    /// <summary>
    /// Вспомогательный класс, осуществляющий подтверждение пользовтелем своей личности при выдаче заказа 
    /// </summary>
    static class Confirmation
    {
        //константы минимального и максимального кода сообщения
        const int minValueMessageCode = 0;
        const int maxValueMessageCode = 9999;

        /// <summary>
        /// Отправляет пользователю рандомное число в диапазоне от minValueMessageCode до maxValueMessageCode в формате строки из 4 цифр (прописывает незначимые нули)
        /// </summary>
        /// <returns>отправленное пользователю число в формате строки из 4 цифр</returns>
        static private string SendMessage()
        {
            Random rand = new Random();
            return rand.Next(minValueMessageCode, maxValueMessageCode).ToString("0000");
        }

        /// <summary>
        /// Получение сообщения от пользоваетеля
        /// </summary>
        /// <returns>полученное от пользователя число в формате строки из 4 цифр</returns>
        static private string GetMessage()
        {
            //замена настоящей реализации
            string message = String.Empty;
            for (int i  = 0; i < 4; i++)
            {
                message += Console.ReadKey().KeyChar;
            }
            
            return message;
        }

        /// <summary>
        /// Функция подтверждения номера телефона
        /// </summary>
        /// <returns></returns>
        static public bool IsPhoneConfirmation()
        {
            string sendCode = SendMessage();
            string recieveCode = GetMessage();
            if (sendCode == recieveCode)
                return true;
            return false;
        }
    }

    /// <summary>
    /// Перечисление статусов доставки в магазин или пункт вывоза
    /// </summary>
    enum NoHomeDeliveryStatusType
    {
        NotReady,
        Ready,
        Delivered,
        OutOfTime
    }
    /// <summary>
    /// Перечисление статусов доставки на дом
    /// </summary>
    enum HomeDeliveryStatusType
    {
        WaitCourier,
        InDelive,
        Delivered
    }

    /// <summary>
    /// Класс для адреса
    /// </summary>
    class Address
    {
        public string City { get; }
        public string StreetName { get; }
        public string BildingNum { get; }
    }

    /// <summary>
    /// Подкласс для адресса жилого помещения
    /// </summary>
    class AddressAppartment : Address
    {
        public uint AppartmentNum { get; }
        public uint FloorNum { get; }

    }

    /// <summary>
    /// Класс для доставки
    /// </summary>
    /// <typeparam name="TAddress"></typeparam>
    abstract class Delivery<TAddress, TStatus> where TAddress : Address
    {
        /// <summary>
        /// Адрес доставки
        /// </summary>
        public abstract TAddress Address { get; protected set; }

        /// <summary>
        /// данные о пользователе
        /// </summary>
        public User User;

        protected TStatus Status;

        /// <summary>
        /// Обновление статуса заказа
        /// </summary>
        abstract public void UpdateStatus();

        /// <summary>
        /// Возвращает информацию о том, получилось ли доставить заказ
        /// </summary>
        /// <returns></returns>
        public abstract bool TryGiveOutOrder();

    }

    /// <summary>
    /// Класс доставки на дом
    /// </summary>
    class HomeDelivery : Delivery<AddressAppartment, HomeDeliveryStatusType>
    {
        /// <summary>
        /// Адресс жилого помещения
        /// </summary>
        public override AddressAppartment Address { get; protected set; }

        /// <summary>
        /// Список курьеров
        /// </summary>
        static Courier[] couriers;

        /// <summary>
        /// Назначенный курьер
        /// </summary>
        Courier Courier;

        static HomeDelivery()
        {
            //Здесь должна подтягиваться информация о курьерах и записываться в список couriers
        }

        /// <summary>
        /// Поиск свободного курьера из списка
        /// </summary>
        /// <returns>Найденный курьер или null</returns>
        private Courier FindEnableCourier()
        {
            foreach (var courier in couriers)
            {
                if (courier.isCourierEnable())
                    return courier;
            }
            return null;
        }

        /// <summary>
        /// Попытка выдать заказ
        /// </summary>
        /// <returns>true - заказ выдан, false - заказ не выдан</returns>
        public override bool TryGiveOutOrder()
        {
            Courier = FindEnableCourier();
            if (Courier != null)
                return true;
            return false;
        }

        /// <summary>
        /// Обновить статус
        /// </summary>
        public override void UpdateStatus()
        {
            if (Status == HomeDeliveryStatusType.Delivered)
                return;
            if (Courier == null)
            {
                Status = HomeDeliveryStatusType.WaitCourier;
                return;
            }
            Status = HomeDeliveryStatusType.InDelive;
        }

        public HomeDelivery(User user, AddressAppartment address)
        {
            User = user;
            Address = address;
        }



    }
    /// <summary>
    /// Вспомогательный класс, который описывает общие черты доставки в магазин и в пункт вывоза
    /// 
    /// </summary>
    abstract class NoHomeDelivery : Delivery<Address, NoHomeDeliveryStatusType>
    {

        /// <summary>
        /// Последний день хранения
        /// </summary>
        protected DateTime LastDay { get; set; }

        /// <summary>
        /// Адресс пункта выдачи или магазина
        /// </summary>
        public override Address Address { get; protected set; }

        /// <summary>
        /// Время хранения/резервирования заказа после поступления
        /// </summary>
        protected const int storagePeriodInDays = 3;

        /// <summary>
        /// Список адресов доставки
        /// </summary>
        public static Address[] addresses;



        /// <summary>
        /// Установить статус заказа Выдано
        /// </summary>
        protected void SetDeliveredStatus()
        {
            Status = NoHomeDeliveryStatusType.Delivered;
        }
    }


    /// <summary>
    /// Доставка в пункт выдачи
    /// </summary>
    class PickPointDelivery : NoHomeDelivery
    {
        
        /// <summary>
        /// День привоза заказа в пункт выдачи
        /// </summary>
        public DateTime FirstDay { get; }

        /// <summary>
        /// Время, через которое заказ попадает в пункт
        /// </summary>
        const int deliveryInDays = 2;

        static PickPointDelivery()
        {
            //Тут типа должны из файла парситься адреса пунктов выдачи в массив addresses, но мне было лень
        }

        /// <summary>
        /// Назначает параметры доставки
        /// </summary>
        /// <param name="indexAddress">Индекс массива адрессов</param>
        public PickPointDelivery(int indexAddress)
        {
            //Через сколько доставят
            FirstDay = DateTime.Today.AddDays(deliveryInDays);

            //Через сколько увезут обратно
            LastDay = FirstDay.AddDays(storagePeriodInDays);

            //Присваивает адресс
            //Не придумала другого способа запретить назначать адреса не из списка
            Address = indexAddress < addresses.Length ? addresses[indexAddress] : addresses[0];
        }

        /// <summary>
        /// Попытка отдать заказ
        /// </summary>
        /// <returns>true - заказ выдан, false - заказ не выдан</returns>
        public override bool TryGiveOutOrder()
        {
            if (DateTime.Today > LastDay)
            {
                return false;
            }

            if (DateTime.Today < FirstDay)
            {
                return false;
            }

            if (Confirmation.IsPhoneConfirmation())
            {
                SetDeliveredStatus();
                return true;
            }
            return false;
        }

        /// <summary>
        /// Обновить статус
        /// </summary>
        public override void UpdateStatus()
        {
            if (Status == NoHomeDeliveryStatusType.Ready)
                return;

            if (DateTime.Today > LastDay)
            {
                Status = NoHomeDeliveryStatusType.OutOfTime;
                return;
            }

            if (DateTime.Today < FirstDay)
            {
                Status = NoHomeDeliveryStatusType.NotReady;
                return;
            }

            Status = NoHomeDeliveryStatusType.Ready;
        }
    }

    /// <summary>
    /// Доставка в магазин
    /// </summary>
    class ShopDelivery : NoHomeDelivery
    {
        /// <summary>
        /// О,новить статус
        /// </summary>
        public override void UpdateStatus()
        {

            //Поскольку выдача определяется 
            if (Status == NoHomeDeliveryStatusType.Ready)
                return;

            if (DateTime.Today > LastDay)
            {
                Status = NoHomeDeliveryStatusType.OutOfTime;
                return;
            }


            Status = NoHomeDeliveryStatusType.Ready;
        }

        /// <summary>
        /// Попытка отдать заказ
        /// </summary>
        /// <returns>true - заказ выдан, false - заказ не выдан</returns>
        public override bool TryGiveOutOrder()
        {
            if (DateTime.Today > LastDay)
            {
                return false;
            }

            if (Confirmation.IsPhoneConfirmation())
            {
                SetDeliveredStatus();
                return true;
            }
            return false;
        }
    }
}