using UseCollections.Models;
namespace UseCollections.Helpers;

//Extension Methods

/*
Following points need to be considered when creating an extension method:
The class which defines an extension method must be non-generic, static and non-nested
Every extension method must be a static method
The first parameter of the extension method should use the this keyword.
*/
public static class Extensions
{
    //cannot be used if private or internal
    public static bool IsTheFirst(this Artwork artwork)
    {
        //ref keyword do not work with classes but work with structs and generics
        return artwork.Id == 1;
    }
}