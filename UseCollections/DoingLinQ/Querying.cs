namespace UseCollections.DoingLinQ;
using System.Linq;
public class Querying
{
    
    private class Hero{
        public int Id;
        public string Name;
        public Universe Universe;
     
        public Hero(int id,string name, Universe universe)
        {
            Id = id;
            Name = name;
            Universe = universe;
        }
    }
    public static void RunCode()
    {
        Hero[] heroes=
        [
            new Hero(1,"Superman",Universe.Dc),
            new(2,"Batman",Universe.Dc),
            new(3,"Thor",Universe.Marvel)
        ];
	
        var result = from hero in heroes 
            where ! hero.Universe.Equals(Universe.Marvel)
            select hero.Name;
        foreach (var obj in result)
        {
            Console.WriteLine(obj);
        }
        //IEnumerator also work for this and HashTable and Other things even if foreach is preferred
        var enumerator = result.GetEnumerator();
        while (enumerator.MoveNext())
        {
            Console.WriteLine(enumerator.Current);
        }
        enumerator.Dispose();//Free
    }
    
}