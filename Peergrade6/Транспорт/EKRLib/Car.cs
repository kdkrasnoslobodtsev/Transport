using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKRLib
{
    /// <summary>
    /// Класс автомобиля.
    /// </summary>
    public class Car : Transport
    {
        /// <summary>
        /// Конструктор автомобиля.
        /// </summary>
        /// <param name="model">Модель автомобиля</param>
        /// <param name="power">Мощность автомобиля</param>
        public Car(string model, uint power) : base(model, power) { }

        /// <summary>
        /// Строковое представление автомобиля.
        /// </summary>
        /// <returns>Автомобиль в виде строки</returns>
        public override string ToString()
        {
            return $"Car. {base.ToString()}";
        }

        /// <summary>
        /// Заводим двигатель автомобиля.
        /// </summary>
        /// <returns>Звук двигателя автомобиля</returns>
        public override string StartEngine()
        {
            return $"{Model}: Vroom";
        }
    }
}
