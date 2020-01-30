using System;

namespace LinkedList.Model
{
    /// <summary>
    /// Ячейка списка.
    /// </summary>
    public class Item<T>
    {
        private T _data;

        /// <summary>
        /// Данные хранимые в ячейке списка.
        /// </summary>
        public T Data
        {
            get => _data;
            set
            {
                if (value != null)
                    _data = value;
                else
                    throw new ArgumentNullException(nameof(value)); }
        }

        /// <summary>
        /// Следующая ячейка списка
        /// </summary>
        public Item<T> Next { get; set; }

        public Item(T data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
