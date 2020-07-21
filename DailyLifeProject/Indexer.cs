using System;

namespace DailyLifeProject
{

    //Generic Indexer

    class Indexer<T>
    {
        private T[] obj = new T[1000];

        public T this[int index]
        {
            get
            {
                return obj[index];
            }

            set
            {
                if (index < 0 || index >= 1000)
                    throw new IndexOutOfRangeException("Index out of range");

                obj[index] = value;
            }
        }
    }
}
