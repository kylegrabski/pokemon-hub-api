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

    [HttpGet]
    public async Task<List<Pokemon>> Get() =>
        await _pokemonService.GetAsync();

    [HttpGet("{Name}")]
    public async Task<ActionResult<Pokemon>> Get(string name)
    {
        var pokemon = await _pokemonService.GetAsync(name);

        if (pokemon is null)
        {
            return NotFound();
        }

        return pokemon;
    }
}