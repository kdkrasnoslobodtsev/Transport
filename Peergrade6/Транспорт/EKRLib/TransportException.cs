using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKRLib
{
    /// <summary>
    /// Класс транпортного исключения.
    /// </summary>
    [Serializable]
    public class TransportException: Exception
    {
        /// <summary>
        /// Конструктор исключение без параметров.
        /// </summary>
        public TransportException(): base() { }

        /// <summary>
        /// Конструктор с одним параметром
        /// </summary>
        /// <param name="message">Сообщение</param>
        public TransportException(string message): base(message) { }

        /// <summary>
        /// Конструктор с двумя параметрами.
        /// </summary>
        /// <param name="message">Сообщение</param>
        /// <param name="inner">Исключение</param>
        public TransportException(string message, Exception inner) : base(message, inner) { }

        /// <summary>
        /// Конструктор сериализации.
        /// </summary>
        /// <param name="info">Информация/param>
        /// <param name="context">Контекст</param>
        protected TransportException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
