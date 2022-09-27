using System;
using System.Collections.Generic;
using System.Text;

namespace CodeQuality_CleanCode.Requirements
{
    /// <summary>
    /// Функция должна решать только ону задачу
    /// Single responsibility principle
    /// </summary>
    public class Functions
    {
        /// <summary>
        /// Не нужно создавать функции у которой больше одной ответственности
        /// </summary>
        public void MakeEveryThings()
        {
            Console.WriteLine("Поход в базу данных");

            CreateReports();

            Console.WriteLine("Печать отчета");
        }

        public void CreateReports() { }

        /// <summary>
        /// Имена должны описывать то - что функция делает
        /// Good example
        /// </summary>
        public void addMonthToDate() { }

        /// <summary>
        /// Bad example
        /// </summary>
        public void addToDate() { }


        ///Инкапсулируйте условие

        const bool IsClicked = 5 > 0;
        const bool IsNotClicked = false;

        public void AvoidNegativConditions()
        {
            // Избегайте негативных условий
            if (IsNotClicked)
            {

            }

            // Это усложняет логику понимания кода и усложняет имя функции.
            if (!IsNotClicked)
            {

            }

            // Good example
            if (IsClicked)
            {

            }

        }

        /// <summary>
        /// Идеальное количество параметров для метода - Два и меньше.
        /// Упрощается тестирование
        /// Если возникает необходимость передачи более двух параметров, то стоит задуматься
        /// О передаче этих агрументов в виде объекта.
        /// </summary>
        /// <param name="frist"></param>
        /// <param name="second"></param>
        public void PerfectAmountParameters(int frist, double second) { }


        // Удаляйте мертвый код.

    }
}
