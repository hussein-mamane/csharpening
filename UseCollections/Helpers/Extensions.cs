using UseCollections.Models;
namespace UseCollections.Helpers;

//Extension Methods
public static class Extensions
{
    //cannot be used if private or internal
    public static bool IsTheFirst(this Artwork artwork)
    {
        //ref keyword do not work with classes but work with structs and generics
        return artwork.Id == 1;
    }
}