using System;
using System.Collections.Generic;
using System.Text;

namespace CodeQuality_CleanCode.Requirements
{
    /// <summary>
    /// Требования к переменным
    /// </summary>
    public class Variables
    {

        /// <summary>
        /// Bad example
        /// </summary>
        const string yyyymmdstr = "27.09.2022";

        /// <summary>
        /// Good example
        /// </summary>
        const string currentDate = "28.09.2022";


        /// <summary>
        /// Bad example
        /// </summary>
        public void GetUserInfo() { }
        public void GetClientData() { }
        public void GetCustomerRecord() { }


        /// <summary>
        /// Используйте одну функцию для получения одного типа данных.
        /// (Одних и тех же данных)
        /// </summary>
        public void GetUser() { }


        /// <summary>
        /// Не используйте магические числа в коде
        /// </summary>
        public void ExecuteTimeOut()
        {
            //Bad
            SetTimeOut(8640000);

            //Good
            SetTimeOut(MILLISECONDS_IN_A_DAY);
        }

        public void SetTimeOut(int milliseconds) { }

        /// <summary>
        /// Объявите их как именнованные константы с заглавной буквы
        /// </summary>
        const int MILLISECONDS_IN_A_DAY = 8640000;



        public void Foreach()
        {
            string[] locations = { "Moscow", "Kyiv", "Minsk" };

            //Избегайте интуитивных маппингов
            foreach (var i in locations)
            {
                Console.WriteLine(i);
            }

            // Не используйте одну букву в качестве переменной
            foreach (var location in locations)
            {
                Console.WriteLine(location);
            }
        }

    }

    /// <summary>
    /// Не добавляйте не нужны контекст, Car.carMake
    /// </summary>
    public class Car
    {
        public string carMake { get; set; }
        public string carModel { get; set; }
        public string carColor { get; set; }

    }

    /// <summary>
    /// Нужно делать вот так
    /// </summary>
    public class Ccar
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
    }

    // Если условие или переменная используется в коде более двух раз
    // Вынесите ее в глобальную переменную.



}
