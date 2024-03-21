using System.Data.Common;

namespace UseCollections;

public class GenericQueue
{
    public static void RunCode()
    {
        var genericQueue = new Queue<Person>();
        genericQueue.Enqueue(new Person(1,"Joe"));
        genericQueue.Enqueue(new Person(2,"Jack"));
        GenericEnumerablesHelpers.Print(genericQueue);
    }

    private record Person(int Id, string Name);
    /*private class Person(int id, string name)
    {
        private int Id { get; init; } = id;
        private string Name { get; init; } = name;
    }*/
}