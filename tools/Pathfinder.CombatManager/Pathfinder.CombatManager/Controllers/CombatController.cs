using System;
using Microsoft.AspNetCore.Mvc;
using Pathfinder.CombatManager.Models.Participants;

namespace Pathfinder.CombatManager.Controllers;

[ApiController]
[Route("[controller]")]
public class CombatController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<CombatController> _logger;

    public CombatController(ILogger<CombatController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<Participant> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new Participant
        {
            Name = $"Monster {index}",
            AC = Random.Shared.Next(10, 20),
            CurrentHp = Random.Shared.Next(20, 40),
        })
        .ToArray();
    }
}

