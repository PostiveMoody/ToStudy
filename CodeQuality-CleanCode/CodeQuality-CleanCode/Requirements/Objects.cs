using System;
using System.Collections.Generic;
using System.Text;

namespace CodeQuality_CleanCode.Requirements
{
    public class Objects
    {
        /// <summary>
        /// Используйте приватные свойства
        /// </summary>
        private string _property { get; }

        /// <summary>
        /// Используйте геттеры и сеттеры
        /// Лучше всего для доступа к разным свойствам класса использовать именно 
        /// Геттеры и Сеттеры
        /// Возможность добавление валидации, логирования изменений
        /// </summary>
        public string UseThis { get; set; }
    }
}
