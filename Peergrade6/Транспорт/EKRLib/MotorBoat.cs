using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKRLib
{
    /// <summary>
    /// Класс моторной лодки.
    /// </summary>
    public class MotorBoat: Transport
    {
        /// <summary>
        /// Конструктор моторной лодки.
        /// </summary>
        /// <param name="model">Модель моторной лодки</param>
        /// <param name="power">Мощность моторной лодки</param>
        public MotorBoat(string model, uint power): base(model, power) { }

        /// <summary>
        /// Строковое представление моторной лодки.
        /// </summary>
        /// <returns>Моторная лодка в виде строки</returns>
        public override string ToString()
        {
            return $"MotorBoat. {base.ToString()}";
        }

        /// <summary>
        /// Заводим двигатель моторной лодки.
        /// </summary>
        /// <returns>Звук двигателя моторной лодки</returns>
        public override string StartEngine()
        {
            return $"{Model}: Brrrbrr";
        }
    }
}
