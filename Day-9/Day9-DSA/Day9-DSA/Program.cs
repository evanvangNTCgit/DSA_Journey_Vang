/*
 * https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2?view=net-10.0
 * 
 * In C# THERE ARE NO DUPLICATE KEYS
 * However there can be duplicate values!
 * 
 * So if you try to to add something to a key that already exists
 * An exception occurs.
 * 
 * Thus with no duplicate keys you can access items with an indexor
 * var test = foo['bar'];
 * 
 * You can also update a value using the indexer associated with a key.
 * foo['bar'] = "Eli";
 * 
 * If the key does not exist no worries... It is simply now added to the dictionary
 * foo['Mother'] = "Jess";
 * 
 * INDEXER WILL THROW AN EXCEPTION IS REQUESTED KEY IS NOT IN THE DICT.
 * KeyNotFoundException
 * 
 * TryGetValue can be a more efficient way to get dict. values
 * as they will not throw an exception if key does not exist.
 * string value = string.empty
 * if(foo.TryGetValue('bar', out value)){
 * console.log("retrieved the value, key exists!");
 * } else {...}
 * 
 * ContainsKey is a method that can be used to test keys before inserting them.
 * if(!foo.ContainsKey('Evan')){
 * foo.Add('Evan','Vang');
 * console.log('Added Evan to Foo dictionary!');
 * }
 * 
 * When iterating over a dict. elements are retrieved as KeyValuePair obj's
 * foreach(KeyValuePair<string,string> kvp in foo){
 * console.WriteLine($"Key = {kvp.key}, Value = {kvp.value}");
 * }
 * 
 * You can retrieve purely values with the Values property.
 * Dictionary<string,string>.ValueCollection bar = foo.Values;
 * 
 * Elements in the ValueCollection are strongly typed.
 * By the defining dictionary type.
 * So notice how I used Dictionary<string,string>. Its string values!
 * 
 * And with purely key values use keys property
 * Dictionary<string,string>.KeyCollection bar = foo.Keys;
 * 
 * And lastly we can use a remove method to remove a key/value pair.
 * foo.Remove('Evan');
 * 
 * RETRIEVING A VALUE FROM THE DICTIONARY IS INCREDIBLY FAST 
 * Nearly O(1)
 * This is because it provides a mapping from a set of keys
 * to a set of values.
 * The speed of retrieval depends on the quality of the hashing algorithm of the type specified for TKey.
 */

Dictionary<int, string> table = new();

table.Add(100, "Spongebob");
table.Add(600, "Gary");
table.Add(200, "Patrick");
table.Add(300, "Sandy");
table.Add(555, "Squidward");

if(table.TryGetValue(100, out string? value))
{
    Console.WriteLine($"Found Someone!: {value}");
};

Console.WriteLine("Looping through the pairs in the dictionary...");
foreach (KeyValuePair<int,string> pair in table)
{
    Console.Write($"Key: {pair.Key}, Value: {pair.Value}, ");
}
Console.WriteLine();
Console.WriteLine("Now removing Sandy Cheeks");
table.Remove(100);

Console.WriteLine("Sandy cheeks now gone from the dictionary.");
foreach (KeyValuePair<int, string> pair in table)
{
    Console.Write($"Key: {pair.Key}, Value: {pair.Value}, ");
}

Console.WriteLine();
Console.WriteLine($"Here is the hashcode of the dictionary: {table.GetHashCode()}");


// Notes to self:

/*
 * Not being able to use the same key in a dictionary is a big noteworthy thing
 * 
 * Does not defeat the purpose of C# Dict. Because of unique keys forced, an O(1) near look up is achieved
 * 
 */