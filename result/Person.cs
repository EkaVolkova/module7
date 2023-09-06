namespace result
{
    /// <summary>
    /// Класс человек
    /// Существует в абстрактном виде, чтобы никто не использовал курьера, как человека
    /// </summary>
    abstract class Person 
    {
        protected abstract string FirstName { get; set; }
        protected abstract string LastName { get; set; }
        protected abstract string PhoneNumber { get; set; }

    }
    /// <summary>
    /// Класс пользователь
    /// 
    /// </summary>
    class User : Person
    {
        protected override string FirstName { get; set; }
        protected override string LastName { get; set; }
        protected override string PhoneNumber { get; set; }

    }

}
