namespace Less9
{
    public class MyCollection : Collection<int>
    {
        public static MyCollection operator +(MyCollection coll1, MyCollection coll2)
        {
            MyCollection result = new MyCollection();
            if (coll1.ArrLength() != coll2.ArrLength())
            {
                Console.WriteLine("Diferent length");
            }
            for (int i = 0; i < coll1.ArrLength(); i++)
            {
                result.Add(coll1[i] + coll2[i]);
            }
            return result;
        }

        public static bool operator ==(MyCollection coll1, MyCollection coll2)
        {
            if (coll1.ArrLength() != coll2.ArrLength())
            {
                Console.WriteLine("Diferent length");
            }
            for (int i = 0; i < coll1.ArrLength(); i++)
            {
                if (coll1[i] != coll2[i])
                {
                    return false;
                }
            }
            return true;
        }

        public static bool operator !=(MyCollection coll1, MyCollection coll2)
        {
            if (coll1.ArrLength() != coll2.ArrLength())
            {
                Console.WriteLine("Diferent length");
            }
            for (int i = 0; i < coll1.ArrLength(); i++)
            {
                if (coll1[i] != coll2[i])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
