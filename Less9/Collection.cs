namespace Less9
{
    public class Collection<T>
    {
        T[] array = Array.Empty<T>();
        public T this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
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

        public int ArrLength()
        {
            return array.Length;
        }
    }
}

