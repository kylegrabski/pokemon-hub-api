using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PokemonApi.Models;

// @TODO FINISH MAPPING THIS MODEL!!!
public class Pokemon
{
    // [BsonId]
    // [BsonRepresentation(BsonType.ObjectId)]
    // public string? MongoId { get; set; }

    // [BsonElement("name")]
    // public string? Name { get; init; }

    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? MongoId { get; set; }

    [BsonElement("name")]
    public string? Name { get; init; }

    [BsonElement("abilities")]
    public AbilityObject[]? Abilities { get; init; }

    [BsonElement("base_experience")]
    public int BaseExperience { get; init; }

    [BsonElement("height")]
    public int Height { get; init; }

    [BsonElement("id")]
    public int Id { get; init; }

    [BsonElement("moves")]
    public object[]? Moves { get; init; }

    [BsonElement("order")]
    public int Order { get; init; }

    [BsonElement("species")]
    public object? Species { get; init; }

    [BsonElement("sprites")]
    public object? Sprites { get; init; }
    // public SpritesObject? Sprites { get; init; }

    [BsonElement("stats")]
    public List<Object>? Stats { get; init; }

    [BsonElement("types")]
    public List<Object>? Types { get; init; }
    // public Array[]? Types { get; init; }

    [BsonElement("weight")]
    public int Weight { get; init; }
}

public class AbilityObject
{
    [BsonElement("ability")]
    public object? Ability { get; init; }

    [BsonElement("is_hidden")]
    public bool? IsHidden { get; init; }
    [BsonElement("slot")]
    public int? Slot { get; init; }
}
// public class MovesObject
// {
//     [BsonElement("move")]
//     public object? Move { get; init; }

//     [BsonElement("is_hidden")]
//     public bool? IsHidden { get; init; }
//     [BsonElement("slot")]
//     public int? Slot { get; init; }
// }
public class SpritesObject
{
    [BsonElement("back_default")]
    public string? BackDefault { get; init; }

    [BsonElement("front_default")]
    public string? FrontDefault { get; init; }

    [BsonElement("back_female")]
    public string? BackFemale { get; init; }
}
