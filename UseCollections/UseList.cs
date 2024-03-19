using System.Collections.ObjectModel;

namespace UseCollections;

public static class UseList
{
    public static void RunCode()
    {
        //Collection Expression, so neat
        List<int> intList =  [1,2,3];
        //Classic syntax
        List<string> stringList = new List<string>()
        {
            "Hello",
            "Hey",
            "Hey",
            "Hello"
        };//IList<> does not offer RemoveAll
        stringList.Insert(2,"Hola!");
        Console.WriteLine(stringList.FindAll(x => x.EndsWith('!')));
        Console.WriteLine(stringList.IndexOf("Hello"));
        Console.WriteLine(stringList.LastIndexOf("Hello"));
        //stringList.RemoveAll(x=>x.Equals("Hey"));
        /*foreach (var str in stringList)
        {
            Console.WriteLine(str);
        }*/
    }
}