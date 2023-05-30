using System;
using System.Linq;
using Pathfinder.CombatManager.Models.Foundry;

namespace Pathfinder.CombatManager.Models.View.Creatures;


public class Creature
{
    public Creature()
    { }

    public Creature(CreatureFoundry creatureFoundry)
    {        
        Abilities = new Abilities(creatureFoundry.System.Abilities);
        Name = creatureFoundry.Name;
        AC = creatureFoundry.System.Attributes.Ac.Value;
        HP = creatureFoundry.System.Attributes.Hp.Max;
    }

    public string Name { get; set; } = "";

    public Abilities Abilities { get; set; } = new Abilities();

    public int AC { get; set; }

    public int HP { get; set; }
             
}
