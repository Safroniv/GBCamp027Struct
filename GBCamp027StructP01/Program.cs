//GB - Буткемп 027 Структуры данных C#

using AnotherLib.BootCamp;

SampleData sampleData = new SampleData();
sampleData.Id = 1;

int i = 10;


List <int> list = new List<int> ();
list.Add(i);
list.Add(20);
list.Add(9);
list.Add(10);
list.Add(11);

foreach (var item in list)
{
    Console.WriteLine(item);
}
//IEnumerable<int> enumerator = list.GetEnumerator();

//while(enumerator.MoveNext())

for (int o=0; o<list.Count; o++)
{
    int current = list [o];
    Console.WriteLine (current);
}
string foo = "Hello World!";
//Dictionary<TKey, TValue>

/*
 * key | Value
 * 0   | Hello World!
 * 1   | Hello space!
 * 2   | Hello OLADUSHKE
 */
//словарь - dictionary
Dictionary<int, string> index = new Dictionary<int, string> ();
index.Add(0, foo);
index.Add(1, "Hello space!");
index.Add(2, "Hello OLADUSHKE");

if(index.ContainsKey(2))
{
    string helloOladushke = index[2];
}

Dictionary<string, string> indexByString = new Dictionary<string, string>();
indexByString.Add("Vasiliy", "Pupkin");
indexByString.Add("Vasiliy1", "Pupkin1");
indexByString.Add("Vasiliy2", "Pupkin2");

if (indexByString.ContainsKey("Vasiliy1"))
{
    string helloOladushke = indexByString["Vasiliy1"];
}

SpecialKey f1 = new SpecialKey();
//customIndex.Add(f1, "bla-bla-bla");

public class SpecialKey
{
    public string? Name { get; set; }
}