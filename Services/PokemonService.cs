using PokemonApi.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace PokemonApi.Services;

public class PokemonService
{
    private readonly IMongoCollection<Pokemon> _pokemonCollection;

    public PokemonService(IOptions<PokemonDatabaseSettings> pokemonDatabaseSettings)
    {
        var mongoClient = new MongoClient(
            pokemonDatabaseSettings.Value.ConnectionString);

        var mongoDatabase = mongoClient.GetDatabase(
            pokemonDatabaseSettings.Value.DatabaseName);

        _pokemonCollection = mongoDatabase.GetCollection<Pokemon>(
            pokemonDatabaseSettings.Value.CollectionName);
    }

    // Get All Pokemon
    public async Task<List<Pokemon>> GetAllPokemon()
    {
        Console.WriteLine("Get Paginated HIT");
        return await _pokemonCollection.Find(_ => true).ToListAsync();
    }

    // Get 51 Pokemon at a time
    public async Task<List<Pokemon>> GetPaginatedPokemon() 
    {
        Console.WriteLine("Get Paginated HIT");
        return await _pokemonCollection.Find(_ => true).ToListAsync();
    }

    // Get Pokemon by Name
    public async Task<Pokemon?> GetPokemonByName(string name)
    {
        Console.WriteLine("Get Name HIT");
        return await _pokemonCollection.Find(x => x.Name == name).FirstOrDefaultAsync();
    }

}
