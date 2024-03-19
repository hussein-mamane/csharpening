using UseCollections.Helpers;

namespace UseCollections.Models;
public struct Artwork //struct vs class interchangeable ? 
{
    public uint Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public Artwork(uint id,string name)
    {
        Id = id;
        Name = name;
    }

    public override string ToString()
    {
        return this.IsTheFirst() ? "Simply, The First Artwork We registered is a secret" : $"{Id}, {Name}";
    }
    
}