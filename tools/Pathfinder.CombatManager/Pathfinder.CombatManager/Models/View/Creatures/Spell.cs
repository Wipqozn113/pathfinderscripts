using System;
using Pathfinder.CombatManager.Models.Foundry;
namespace Pathfinder.CombatManager.Models.View.Creatures;

public class Spell
{
	public Spell(SystemFoundry spell)
	{
	}

	public string Name { get; set; } = "";

	public string Range { get; set; } = "";

    public string Area { get; set; } = "";

    public string Description { get; set; } = "";

	public string Duration { get; set; } = "";

	public int Level { get; set; }


}

