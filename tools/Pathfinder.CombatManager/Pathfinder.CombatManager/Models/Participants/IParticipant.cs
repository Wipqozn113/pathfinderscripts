using System;
namespace Pathfinder.CombatManager.Models.Participants;

public interface IParticipant
{
    public string Name { get; set; }
    public int AC { get; set; }
    public int Initiative { get; set; }

    public string ShowDetails();
}


