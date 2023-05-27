using System;
namespace Pathfinder.CombatManager.Models.Stats;

public class Ability
{
	public Ability()
	{
	}

	public string Name { get; set; } = "";

	public int Value
	{
		get
		{
			return _value;
		}
		set
		{
			_value = value;
			Modifier = (int) Math.Floor((value - 10) / 2.0);
			
		}
	}

	private int _value;

	public int Modifier { get; set; }
}

