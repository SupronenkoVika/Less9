using Less9;

Collection<int> coll = new Collection<int>();
coll.Add(1);
coll.Add(2);
coll.Add(3);
coll.Add(4);
coll.Add(5);
Console.WriteLine("Collection length: " + coll.ArrLength());

for (int i = 0; i < coll.ArrLength(); i++)
{
    Console.WriteLine(coll.GetItem(i));
}


MyCollection coll1 = new MyCollection();
MyCollection coll2 = new MyCollection();
coll1.Add(5);
coll1.Add(2);
coll1.Add(9);
coll1.Add(4);
coll1.Add(3);

coll2.Add(15);
coll2.Add(16);
coll2.Add(13);
coll2.Add(19);
coll2.Add(22);

var coll3 = coll1 + coll2;
Console.WriteLine("New collection: ");
for (int i = 0; i < coll3.ArrLength(); i++)
{
    Console.WriteLine(coll3[i]);
}

Console.WriteLine("Elements equality: " + (coll1 == coll2));
