using System;
using Pathfinder.CombatManager.Models.Foundry;
namespace Pathfinder.CombatManager.Models.View.Creatures;

public class Abilities
{
    public Abilities()
    {

    }

    public Abilities(AbilitiesFoundry abilities)
    {
        Cha = abilities.Cha.Mod;
        Con = abilities.Con.Mod;
        Dex = abilities.Dex.Mod;
        Int = abilities.Int.Mod;
        Str = abilities.Str.Mod;
        Wis = abilities.Wis.Mod;
    }

    public int Cha { get; set; }

    public int Con { get; set; }

    public int Dex { get; set; }

    public int Int { get; set; }

    public int Str { get; set; }

    public int Wis { get; set; }
}

