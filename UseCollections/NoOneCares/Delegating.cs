//delegate in the same file using block scoped namespaces


//must learn : Func, Action, Event Delegate  IAmTimCorey Youtube: "Delegates in C# - A practical demonstration"
namespace UseCollections.NoOneCares // block scoped namespace, no using directive needed if in the same file
{
    
    // block scoped namespace are not hard to use
    public static class Delegating
    {
        static bool ContainsChecker(ContainsAOrZ del,string[] arr)
        {
            return del(arr);
        }

        public static bool ContainsZ(string[] arr)
        {
            return arr.Contains("Z");
        }
       
        public static void RunCode()
        {
            string[] arr = ["A","Z","E"];
            string[] arr2 = ["B","C","E"];
            // Redundant lambda parameter explicit type specification
            ContainsAOrZ forA = (string[] arrParam) => { return arr.Contains("A") ? true : false; };//Redundant conditional ternary expression usage
            // ContainsAOrZ forZ = (string[] arrParam) => arr.Contains("Z");
            ContainsAOrZ forZ = ContainsZ;
            Console.WriteLine(ContainsChecker(forA,arr));
            Console.WriteLine(ContainsChecker(forZ,arr));
            Console.WriteLine(ContainsChecker(forZ,arr2));
        }

        
    }
    public delegate bool ContainsAOrZ(string[] strings);    
}




