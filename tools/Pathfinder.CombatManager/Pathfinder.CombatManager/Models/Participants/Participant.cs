using System;
namespace Pathfinder.CombatManager.Models.Participants;

public class Participant : IParticipant
{
	public Participant()
	{
	}

	public string Name { get; set; } = "";

	public int AC { get; set; }

	public int Initiative { get; set; }

	public virtual string ShowDetails()
	{
		return "";
	}
}


