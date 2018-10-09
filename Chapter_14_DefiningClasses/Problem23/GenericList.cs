using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter_14_DefiningClasses.Problem23
{
    class GenericList<T>:IEnumerable<T>
        where T:IComparable<T>
    {
        private const int InitialCapacity = 16;

        private int length;
        private T[] data;

        public GenericList(int capacity)
        {
            this.data = new T[InitialCapacity];
        }

        public GenericList()
            :this(InitialCapacity)
        {
        }

        public GenericList(T[] list)
        {
            this.data = list;
        }

        public T[] Elements
        {
            get
            {
                return this.data.Take(this.length).ToArray(); ;
            }
            private  set
            {
                this.data = value;
            }
        }

        public void Add(T element)
        {
            if (this.length == this.data.Length)
            {
                this.data = this.data.Concat(new T[this.length]).ToArray();
            }
            this.data[length] = element;

            this.length++;
        }

        public void Insert(T element, int index)
        {
            if (index < 0 || index > this.data.Length)
            {
                throw new IndexOutOfRangeException();
            }

            T[] tempArray = new T[this.length + 1];

            for (int i = 0; i < index; i++)
            {
                tempArray[i] = this.data[i];
            }

                tempArray[index] = element;

                for (int i = index + 1; i < tempArray.Length; i++)
                {
                    tempArray[i] = data[i - 1];
                }

                this.data = tempArray;
        }

        public T this[int index]
        {
            get
            {
                return this.data[index];
            }
        }

        public bool Contains(T element)
        {
            bool haveElement = false;

            for (int i = 0; i < this.length; i++)
            {
                if (this.data[i].CompareTo(element) == 0)
                {
                    return true;
                }
            }

            return haveElement;
        }

        public void RemoveAt(int index)
        {
            IndexValidation(index);

            T element = this.data[index];

            this.data = this.data.Take(index).Concat(this.data.Skip(index + 1)).ToArray();

            this.length--;
        }

        private void IndexValidation(int index)
        {
            if (index < 0 || index >= this.data.Length)
            {
                throw new IndexOutOfRangeException();
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.length; i++)
            {
                yield return this.data[i];
            }
        }

        public T GetByIndex(int index)
        {
            IndexValidation(index);

            return this.data[index];
        }
        public void Clear()
        {
            this.data = new T[InitialCapacity];
        }

        public override string ToString()
        {
            return string.Join(", ",this.data);
        }
    }
}
