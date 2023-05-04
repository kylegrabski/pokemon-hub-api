using PokemonApi.Models;
using PokemonApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace PokemonApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PokemonController : ControllerBase
{
    private readonly PokemonService _pokemonService;

    public PokemonController(PokemonService pokemonService) => 
        _pokemonService = pokemonService;

    // [HttpGet]
    // public async Task<List<Pokemon>> Get() =>
    //     await _pokemonService.GetAsync();
    [HttpGet("{pageNumber}/{pageSize}")]
    public async Task<ActionResult<IEnumerable<Pokemon>>> Get(int pageNumber, int pageSize)
    {
        Console.WriteLine($"{pageNumber} - {pageSize}");
        var pokemon = await _pokemonService.GetAllPokemon();

        var pagedPokemon = pokemon.Skip((pageNumber - 1) * pageSize).Take(pageSize);

        return Ok(pagedPokemon);
    }

    [HttpGet("{Name}")]
    public async Task<ActionResult<Pokemon>> Get(string name)
    {
        var pokemon = await _pokemonService.GetPokemonByName(name);

        if (pokemon is null)
        {
            return NotFound();
        }

        return pokemon;
    }
}
