using UseCollections.Models;
namespace UseCollections.Helpers;

public static class Extensions
{
    public static bool IsTheFirst(this Artwork artwork)
    {
        //ref keyword do not work with classes but work with structs and generics
        return artwork.Id == 1;
    }
}