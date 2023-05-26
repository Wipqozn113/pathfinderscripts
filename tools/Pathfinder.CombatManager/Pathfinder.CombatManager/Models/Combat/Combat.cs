using System;
using Pathfinder.CombatManager.Models.Participants;

namespace Pathfinder.CombatManager.Models.Combat;

public class Combat
{
	public Combat()
	{
	}

	List<IParticipant> Participants { get; set; } = new List<IParticipant>();
}


