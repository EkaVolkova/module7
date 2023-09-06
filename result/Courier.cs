namespace result
{
    /// <summary>
    /// Статус курьера
    /// </summary>
    enum CourierStatus
    {
        bussy,
        enable
    }

    /// <summary>
    /// Класс курьер
    /// </summary>
    class Courier : Person
    {
        protected override string FirstName { get; set; }
        protected override string LastName { get; set; }
        protected override string PhoneNumber { get; set; }

        /// <summary>
        /// Показывает, свободен ли курьер
        /// </summary>
        private CourierStatus status;

        /// <summary>
        /// Возвращает статус занятости курьера
        /// </summary>
        /// <returns></returns>
        public bool isCourierEnable()
        {
            return status == CourierStatus.enable;
        }

    }

}
