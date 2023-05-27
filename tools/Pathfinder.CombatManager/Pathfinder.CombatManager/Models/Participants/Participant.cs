using System;
using Pathfinder.CombatManager.Enums;
namespace Pathfinder.CombatManager.Models.Participants;

public class Participant : IParticipant
{
	public Participant()
	{
	}

	public int Wisdom { get; set; }

	public string Name { get; set; } = "";

	public int Level { get; set; }

	public int AC { get; set; }

	public int Initiative
	{
		get
		{
			return Perception;
		}
	}

	public int Perception
	{
		get
		{
			return Wisdom + Proficiency(PerceptionTraining);
		}
	}

	public TrainingLevel PerceptionTraining { get; set; } = TrainingLevel.Trained;

	public int MaxHp { get; set; }

	public int CurrentHp { get; set; }

	public List<Attack> Attacks { get; set; }

	public virtual string ShowDetails()
	{
		return "";
	}

	private int Proficiency(TrainingLevel trainingLevel = TrainingLevel.Untrained)
	{
		if (trainingLevel == TrainingLevel.Untrained)
			return 0;

        // This works since if you're trained, expert, master, or legendary,
		// your proficiency bonus equals your level plus 2, 4, 6, or 8.
		// Since Enums Int value is 0, 1, 2, etc, we're able to perform this
		// operation so long as the Enum is defined with the proper ordering.
        return Level + ((int)trainingLevel * 2);
	}
}


