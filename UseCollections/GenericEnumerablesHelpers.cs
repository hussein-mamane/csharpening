namespace UseCollections;
// this static is not needed for execution, even without it, you don't need an instance
// to execute static methods, all members of static class must be statics
// "Extension method can only be declared in non-generic, non-nested static class"


public static class GenericEnumerablesHelpers
{
    
    
    //public is needed for extensions in their own class
    public static void PrintExtension<T>(this IEnumerable<T> myIEnumerable)
    {
        Console.WriteLine("Printing Using the Extension Method");
        foreach (T obj in myIEnumerable)
        {
            Console.Write(obj+" --> ");
        }
    }
    
    //public is needed for helpers in their own class
    public static void Print<T>(IEnumerable<T> myIEnumerable)
    {
        foreach (T obj in myIEnumerable)
        {
            Console.Write(obj+" --> ");
        }
    }
}