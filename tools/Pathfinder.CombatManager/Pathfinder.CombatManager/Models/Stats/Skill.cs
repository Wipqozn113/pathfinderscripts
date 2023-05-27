using System;
namespace Pathfinder.CombatManager.Models.Stats;

public class Skill
{
	public Skill()
	{
	}

	public string Name { get; set; } = "";

	public int Modifier { get; set; }

	public string Description { get; set; } = "";
}

