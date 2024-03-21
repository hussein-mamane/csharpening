namespace UseCollections;

public class GenericStack
{
    public static void RunCode()
    {
        Stack<string> genericStack = new Stack<string>();
        genericStack.Push("How Are you ?");
        genericStack.Push("Hello,");
        /*foreach (var obj in genericStack)
        {
            Console.WriteLine(obj);
        }*/
        //externalized helpers are better than nested private class helpers, only when they are numerous(2 or more)
        //GenericEnumerablesHelpers.Print<string>(genericStack); //Type argument specification is redundant
        genericStack.PrintExtension();
    }
}