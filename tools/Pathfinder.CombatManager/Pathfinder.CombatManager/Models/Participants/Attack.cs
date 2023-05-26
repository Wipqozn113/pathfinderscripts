using System;
namespace Pathfinder.CombatManager.Models.Participants;

public class Attack : IAction
{
	public Attack()
	{
	}

	public int ActionPoints { get; set; }

	public string AttackRoll { get; set; } = "";

	public string DamageRoll { get; set; } = "";

	public string AsString()
	{
		return "";
	}
}


