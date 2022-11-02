using Less9;

Collection<int> coll = new Collection<int>();
coll.Add(1);
coll.Add(2);
coll.Add(3);
coll.Add(4);
coll.Add(5);
coll.Remove(3);
Console.WriteLine("Collection length: " + coll.Count());

for (int i = 0; i < coll.Count(); i++)
{
    Console.WriteLine(coll.GetItem(i));
}