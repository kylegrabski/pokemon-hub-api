using PokemonApi.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace PokemonApi.Services;

public class PokemonService
{
    private readonly IMongoCollection<Pokemon> _pokemonCollection;

    public PokemonService(
        IOptions<PokemonDatabaseSettings> pokemonDatabaseSettings)
    {
        var mongoClient = new MongoClient(
            pokemonDatabaseSettings.Value.ConnectionString);

        var mongoDatabase = mongoClient.GetDatabase(
            pokemonDatabaseSettings.Value.DatabaseName);

        _pokemonCollection = mongoDatabase.GetCollection<Pokemon>(
            pokemonDatabaseSettings.Value.CollectionName);
    }

    // TODO Change task to something pokemon related
    // ORRR Is task the usual name for this???
    public async Task<List<Pokemon>> GetAsync() =>
        await _pokemonCollection.Find(_ => true).ToListAsync();

}