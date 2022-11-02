namespace Less9
{
    class Collection<T>
    {
        T[] array;
        public Collection()
        {
            array = new T[0];
        }

        public void Add(T item)
        {
            T[] newArr = new T[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                newArr[i] = array[i];
            }
            newArr[array.Length] = item;
            array = newArr;
        }

        public void Remove(T item)
        {
            int index = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(item))
                {
                    index = i;
                    break;
                }
            }
            if (index > -1)
            {
                T[] newArr = new T[array.Length - 1];
                for (int i = 0, j = 0; i < array.Length; i++)
                {
                    if (i == index) continue;
                    newArr[j] = array[i];
                    j++;
                }
                array = newArr;
            }
        }

        public T GetItem(int index)
        {
            return array[index];
        }

        public int Count()
        {
            return array.Length;
        }
    }
}

