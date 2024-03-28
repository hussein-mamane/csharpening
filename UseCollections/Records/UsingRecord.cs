using System.Globalization;
using System.Security.Cryptography;

namespace UseCollections.Records;
//Record and classes  are references types
//Structs are value type  they get copied when you change or assign them, use 16bytes maximum is better
public class UsingRecord
{
    
    /*Records for Immutability :
        Date
        Invoices
        Time Interval
        Configuration Objects*/
    public static void Runcode()
    {
        var Ali = new Person(1,"Sani");
        Person Sani = new(1,"Sani");
        var NewSani = Sani with { name = "NewSani" };
        Person joe = new(2,null);
        Console.WriteLine(Ali==Sani);//Compiler generate value Equality
        Console.WriteLine(Ali);//Compiler generate value ToString
        Console.WriteLine(Sani);
        Console.WriteLine(NewSani);
        // GC.Collect();
        Console.WriteLine(Sani);

        Animal animal = new(Name: "Cat", Id:1);// Inversed
    }

     record Person(int Id, string? name);//Positional arguments record
     //you can create record like classes and add methods
     class Animal  {
         public int Id { get; set; }
         public string? Name { get; set; }

         public Animal(int Id,string Name)
         {
             this.Name = Name;
             this.Id = Id;
         }
     }
}