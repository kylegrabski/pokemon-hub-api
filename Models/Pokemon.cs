using MongoDB.Bson.Serialization.Attributes;

namespace PokemonApi.Models;

public class Pokemon
{
    [BsonElement("name")]
    public string? Name { get; init; }

    [BsonElement("abilities")]
    public string[]? Abilities { get; init; }

    [BsonElement("base_experience")]
    public int BaseExperience { get; init; }

    [BsonElement("forms")]
    public string[]? Forms { get; init; }

    [BsonElement("game_indices")]
    public string[]? GameIndices { get; init; }

    [BsonElement("height")]
    public int Height { get; init; }

    [BsonElement("held_items")]
    public string[]? HeldItems { get; init; }

    [BsonElement("id")]
    public int Id { get; init; }

    [BsonElement("is_default")]
    public bool IsDefault { get; init; }

    [BsonElement("location_area_encounters")]
    public string? LocationAreaEncounters { get; init; }

    [BsonElement("moves")]
    public string[]? Moves { get; init; }

    [BsonElement("order")]
    public int Order { get; init; }

    [BsonElement("past_types")]
    public string[]? PastTypes { get; init; }

    [BsonElement("species")]
    public string? Species { get; init; }

    [BsonElement("sprites")]
    public string? Sprites { get; init; }

    [BsonElement("stats")]
    public string[]? Stats { get; init; }

    [BsonElement("types")]
    public string[]? Types { get; init; }

    [BsonElement("weight")]
    public int Weight { get; init; }
}

public class SpeciesObject
{
    [BsonElement("name")]
    public string? Name { get; init; }

    [BsonElement("url")]
    public string? Url { get; init; }
}

public class SpritesObject
{
    [BsonElement("back_default")]
    public string? BackDefault { get; init; }

    [BsonElement("front_default")]
    public string? FrontDefault { get; init; }
}
