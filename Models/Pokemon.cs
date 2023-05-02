using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PokemonApi.Models;

public class Pokemon
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? MongoId { get; set; }

    [BsonElement("name")]
    public string? Name { get; init; }

    [BsonElement("abilities")]
    public List<Object>? Abilities { get; init; }

    [BsonElement("base_experience")]
    public int BaseExperience { get; init; }

    [BsonElement("height")]
    public int Height { get; init; }

    [BsonElement("id")]
    public int Id { get; init; }

    [BsonElement("order")]
    public int Order { get; init; }

    [BsonElement("species")]
    public object? Species { get; init; }

    [BsonElement("sprites")]
    public object? Sprites { get; init; }

    [BsonElement("stats")]
    public List<Object>? Stats { get; init; }

    [BsonElement("types")]
    public List<Object>? Types { get; init; }

    [BsonElement("weight")]
    public int Weight { get; init; }
}
