using System.Collections;
using System.Collections.Generic;
namespace UseCollections; // file scoped namespaces
using UseCollections.Models;
using NoOneCares; //how to use other namespace in the project
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;


internal class Program
{
    public static void Main(string[] args)
    {
        /*Artwork[] artworks =
        [
            new Artwork(1, "Mona Lisa"),
            new (2,"The Thinker"),
            new (3,"I, Robot")
        ];
        //explicit array
        (int, string)[] array =
        {
            (1, "Mona Lisa"),
            (2, "The Thinker"),
            (3, "I, Robot")
        };
        LinkedList<Artwork> linkedListArtworks = new(artworks);
        foreach (var artwork in artworks)
        {
            Console.WriteLine(artwork);
        }*/
        // UseList.RunCode();
        TimeManagement.RunCode();
    }
}