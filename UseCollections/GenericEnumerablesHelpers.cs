namespace UseCollections;

public class GenericEnumerablesHelpers
{
    
    // Extension method can only be declared in non-generic, non-nested static class
    /*private static void Print(this IEnumerable<T> myIEnumerable)
    {}*/
    //public is needed for helpers
    public static void Print<T>(IEnumerable<T> myIEnumerable)
    {
        foreach (T obj in myIEnumerable)
        {
            Console.Write(obj+" --> ");
        }
    }
}