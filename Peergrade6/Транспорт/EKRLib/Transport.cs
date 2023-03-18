using System;

namespace EKRLib
{
    /// <summary>
    /// Класс транспорта.
    /// </summary>
    abstract public class Transport
    {
        /// <summary>
        /// Поле для модели транспорта.
        /// </summary>
        string model;

        /// <summary>
        /// Поле для мощности транспорта.
        /// </summary>
        uint power;

        /// <summary>
        /// Свойство модели транспорта.
        /// </summary>
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                foreach (char ch in value)
                {
                    if(!('A' <= ch && ch <= 'Z' || '0' <= ch && ch <= '9'))
                    {
                        throw new TransportException($"Недопустимая модель {value}");
                    }
                }
                model = value;
            } 
        }

        /// <summary>
        /// Свойство мощности транспорта.
        /// </summary>
        public uint Power
        {
            get
            {
                return power;
            }
            set
            {
                if(value < 20)
                {
                    throw new TransportException("Мощность не может быть меньше 20 л.с.");
                }
                power = value;
            }
        }


        /// <summary>
        /// Вывод транспорта в виде строки.
        /// </summary>
        /// <returns>Строка с информацией о транспорте</returns>
        public override string ToString()
        {
            return $"Model: {Model}, Power: {Power}";
        }

        /// <summary>
        /// Воспроизводит звук двигателя.
        /// </summary>
        /// <returns>Звук двигателя</returns>
        public abstract string StartEngine();


        /// <summary>
        /// Конструктор транспорта.
        /// </summary>
        /// <param name="model">Модель транспорта</param>
        /// <param name="power">Мощность транспорта</param>
        public Transport(string model, uint power)
        {
            (Model, Power) = (model, power);
        }
    }
}