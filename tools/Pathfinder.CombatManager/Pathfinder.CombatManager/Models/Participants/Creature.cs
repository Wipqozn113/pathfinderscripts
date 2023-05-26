using System;
namespace Pathfinder.CombatManager.Models.Participants;

public class Creature : Participant
{
	public Creature()
	{
	}

	public List<Attack> Attacks { get; set; } = new List<Attack>();

    public override string ShowDetails()
    {
        var details = "";

        Attacks.ForEach(attack => details += attack.AsString());

        return details;
    }
}


