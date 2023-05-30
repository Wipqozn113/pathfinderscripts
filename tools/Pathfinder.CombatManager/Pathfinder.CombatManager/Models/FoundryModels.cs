using System;
using System.Text.Json.Serialization;

namespace Pathfinder.CombatManager.Models.Foundry;

// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);



public class AbilitiesFoundry
{
    [JsonPropertyName("cha")]
    public Cha Cha { get; set; }

    [JsonPropertyName("con")]
    public Con Con { get; set; }

    [JsonPropertyName("dex")]
    public Dex Dex { get; set; }

    [JsonPropertyName("int")]
    public Int Int { get; set; }

    [JsonPropertyName("str")]
    public Str Str { get; set; }

    [JsonPropertyName("wis")]
    public Wis Wis { get; set; }
}

public class Ability
{
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

public class Ac
{
    [JsonPropertyName("details")]
    public string Details { get; set; }

    [JsonPropertyName("value")]
    public int Value { get; set; }
}

public class Actions
{
    [JsonPropertyName("value")]
    public int? Value { get; set; }
}

public class ActionType
{
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

public class Alignment
{
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

public class AllSaves
{
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

public class Area
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("value")]
    public int Value { get; set; }
}

public class Attack
{
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

public class AttackEffects
{
    [JsonPropertyName("custom")]
    public string Custom { get; set; }

    [JsonPropertyName("value")]
    public List<object> Value { get; set; }
}

public class Attributes
{
    [JsonPropertyName("ac")]
    public Ac Ac { get; set; }

    [JsonPropertyName("allSaves")]
    public AllSaves AllSaves { get; set; }

    [JsonPropertyName("hp")]
    public Hp Hp { get; set; }

    [JsonPropertyName("immunities")]
    public List<Immunity> Immunities { get; set; }

    [JsonPropertyName("initiative")]
    public Initiative Initiative { get; set; }

    [JsonPropertyName("perception")]
    public Perception Perception { get; set; }

    [JsonPropertyName("speed")]
    public Speed Speed { get; set; }
}

public class AutoHeightenLevel
{
    [JsonPropertyName("value")]
    public object Value { get; set; }
}

public class Bonus
{
    [JsonPropertyName("value")]
    public int Value { get; set; }
}

public class Cha
{
    [JsonPropertyName("mod")]
    public int Mod { get; set; }
}

public class Components
{
    [JsonPropertyName("focus")]
    public bool Focus { get; set; }

    [JsonPropertyName("material")]
    public bool Material { get; set; }

    [JsonPropertyName("somatic")]
    public bool Somatic { get; set; }

    [JsonPropertyName("verbal")]
    public bool Verbal { get; set; }
}

public class Con
{
    [JsonPropertyName("mod")]
    public int Mod { get; set; }
}

public class Core
{
    [JsonPropertyName("sourceId")]
    public string SourceId { get; set; }
}

public class Cost
{
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

public class Damage
{
    [JsonPropertyName("value")]
    public Value Value { get; set; }
}

public class DamageRoll
{
    [JsonPropertyName("damage")]
    public string Damage { get; set; }

    [JsonPropertyName("damageType")]
    public string DamageType { get; set; }
}

public class Description
{
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

public class Details
{
    [JsonPropertyName("alignment")]
    public Alignment Alignment { get; set; }

    [JsonPropertyName("blurb")]
    public string Blurb { get; set; }

    [JsonPropertyName("creatureType")]
    public string CreatureType { get; set; }

    [JsonPropertyName("level")]
    public Level Level { get; set; }

    [JsonPropertyName("privateNotes")]
    public string PrivateNotes { get; set; }

    [JsonPropertyName("publicNotes")]
    public string PublicNotes { get; set; }

    [JsonPropertyName("source")]
    public Source Source { get; set; }
}

public class Dex
{
    [JsonPropertyName("mod")]
    public int Mod { get; set; }
}

public class DisplayLevels
{
}

public class Dq8lzosuv0ip9h0eih47
{
    [JsonPropertyName("damage")]
    public string Damage { get; set; }

    [JsonPropertyName("damageType")]
    public string DamageType { get; set; }
}

public class Duration
{
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

public class Flags
{
    [JsonPropertyName("core")]
    public Core Core { get; set; }
}

public class Focus
{
    [JsonPropertyName("max")]
    public int Max { get; set; }

    [JsonPropertyName("value")]
    public int Value { get; set; }
}

public class Fortitude
{
    [JsonPropertyName("saveDetail")]
    public string SaveDetail { get; set; }

    [JsonPropertyName("value")]
    public int Value { get; set; }
}

public class Gdbiome7pgw9uzmtjkao
{
    [JsonPropertyName("damage")]
    public string Damage { get; set; }

    [JsonPropertyName("damageType")]
    public string DamageType { get; set; }
}

public class HasCounteractCheck
{
    [JsonPropertyName("value")]
    public bool Value { get; set; }
}

public class Hp
{
    [JsonPropertyName("details")]
    public string Details { get; set; }

    [JsonPropertyName("max")]
    public int Max { get; set; }

    [JsonPropertyName("temp")]
    public int Temp { get; set; }

    [JsonPropertyName("value")]
    public int Value { get; set; }
}

public class Immunity
{
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

public class Initiative
{
    [JsonPropertyName("statistic")]
    public string Statistic { get; set; }
}

public class Int
{
    [JsonPropertyName("mod")]
    public int Mod { get; set; }
}

public class Item
{
    [JsonPropertyName("_id")]
    public string Id { get; set; }

    [JsonPropertyName("img")]
    public string Img { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("sort")]
    public int Sort { get; set; }

    [JsonPropertyName("system")]
    public System System { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("flags")]
    public Flags Flags { get; set; }
}

public class Languages
{
    [JsonPropertyName("custom")]
    public string Custom { get; set; }

    [JsonPropertyName("selected")]
    public List<object> Selected { get; set; }

    [JsonPropertyName("value")]
    public List<string> Value { get; set; }
}

public class Level
{
    [JsonPropertyName("value")]
    public int Value { get; set; }
}

public class Location
{
    [JsonPropertyName("heightenedLevel")]
    public int HeightenedLevel { get; set; }

    [JsonPropertyName("value")]
    public string Value { get; set; }
}

public class Materials
{
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

public class Mod
{
    [JsonPropertyName("value")]
    public int Value { get; set; }
}

public class OtherSpeed
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("value")]
    public int Value { get; set; }
}

public class Perception
{
    [JsonPropertyName("value")]
    public int Value { get; set; }
}

public class Prepared
{
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

public class Primarycheck
{
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

public class Proficiency
{
    [JsonPropertyName("value")]
    public int Value { get; set; }
}

public class Proficient
{
    [JsonPropertyName("value")]
    public int Value { get; set; }
}

public class Range
{
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

public class Reflex
{
    [JsonPropertyName("saveDetail")]
    public string SaveDetail { get; set; }

    [JsonPropertyName("value")]
    public int Value { get; set; }
}

public class Requirements
{
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

public class Resources
{
    [JsonPropertyName("focus")]
    public Focus Focus { get; set; }
}

public class CreatureFoundry
{
    [JsonPropertyName("_id")]
    public string Id { get; set; }

    [JsonPropertyName("img")]
    public string Img { get; set; }

    [JsonPropertyName("items")]
    public List<Item> Items { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("system")]
    public SystemFoundry System { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }
}

public class Rule
{
    [JsonPropertyName("key")]
    public string Key { get; set; }

    [JsonPropertyName("predicate")]
    public List<object> Predicate { get; set; }

    [JsonPropertyName("selector")]
    public string Selector { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("value")]
    public int Value { get; set; }

    [JsonPropertyName("radius")]
    public int? Radius { get; set; }

    [JsonPropertyName("slug")]
    public string Slug { get; set; }

    [JsonPropertyName("traits")]
    public List<string> Traits { get; set; }

    [JsonPropertyName("domain")]
    public string Domain { get; set; }

    [JsonPropertyName("option")]
    public string Option { get; set; }

    [JsonPropertyName("toggleable")]
    public bool? Toggleable { get; set; }

    [JsonPropertyName("outcome")]
    public List<string> Outcome { get; set; }

    [JsonPropertyName("text")]
    public string Text { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }
}

public class Save
{
    [JsonPropertyName("basic")]
    public string Basic { get; set; }

    [JsonPropertyName("value")]
    public string Value { get; set; }
}

public class Saves
{
    [JsonPropertyName("fortitude")]
    public Fortitude Fortitude { get; set; }

    [JsonPropertyName("reflex")]
    public Reflex Reflex { get; set; }

    [JsonPropertyName("will")]
    public Will Will { get; set; }
}

public class School
{
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

public class Secondarycasters
{
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

public class Secondarycheck
{
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

public class Senses
{
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

public class ShowSlotlessLevels
{
    [JsonPropertyName("value")]
    public bool Value { get; set; }
}

public class ShowUnpreparedSpells
{
    [JsonPropertyName("value")]
    public bool Value { get; set; }
}

public class Size
{
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

public class Slot0
{
    [JsonPropertyName("max")]
    public int Max { get; set; }

    [JsonPropertyName("prepared")]
    public List<object> Prepared { get; set; }

    [JsonPropertyName("value")]
    public int Value { get; set; }
}

public class Slot1
{
    [JsonPropertyName("max")]
    public int Max { get; set; }

    [JsonPropertyName("prepared")]
    public List<object> Prepared { get; set; }

    [JsonPropertyName("value")]
    public int Value { get; set; }
}

public class Slot10
{
    [JsonPropertyName("max")]
    public int Max { get; set; }

    [JsonPropertyName("prepared")]
    public List<object> Prepared { get; set; }

    [JsonPropertyName("value")]
    public int Value { get; set; }
}

public class Slot11
{
    [JsonPropertyName("max")]
    public int Max { get; set; }

    [JsonPropertyName("prepared")]
    public List<object> Prepared { get; set; }

    [JsonPropertyName("value")]
    public int Value { get; set; }
}

public class Slot2
{
    [JsonPropertyName("max")]
    public int Max { get; set; }

    [JsonPropertyName("prepared")]
    public List<object> Prepared { get; set; }

    [JsonPropertyName("value")]
    public int Value { get; set; }
}

public class Slot3
{
    [JsonPropertyName("max")]
    public int Max { get; set; }

    [JsonPropertyName("prepared")]
    public List<object> Prepared { get; set; }

    [JsonPropertyName("value")]
    public int Value { get; set; }
}

public class Slot4
{
    [JsonPropertyName("max")]
    public int Max { get; set; }

    [JsonPropertyName("prepared")]
    public List<object> Prepared { get; set; }

    [JsonPropertyName("value")]
    public int Value { get; set; }
}

public class Slot5
{
    [JsonPropertyName("max")]
    public int Max { get; set; }

    [JsonPropertyName("prepared")]
    public List<object> Prepared { get; set; }

    [JsonPropertyName("value")]
    public int Value { get; set; }
}

public class Slot6
{
    [JsonPropertyName("max")]
    public int Max { get; set; }

    [JsonPropertyName("prepared")]
    public List<object> Prepared { get; set; }

    [JsonPropertyName("value")]
    public int Value { get; set; }
}

public class Slot7
{
    [JsonPropertyName("max")]
    public int Max { get; set; }

    [JsonPropertyName("prepared")]
    public List<object> Prepared { get; set; }

    [JsonPropertyName("value")]
    public int Value { get; set; }
}

public class Slot8
{
    [JsonPropertyName("max")]
    public int Max { get; set; }

    [JsonPropertyName("prepared")]
    public List<object> Prepared { get; set; }

    [JsonPropertyName("value")]
    public int Value { get; set; }
}

public class Slot9
{
    [JsonPropertyName("max")]
    public int Max { get; set; }

    [JsonPropertyName("prepared")]
    public List<object> Prepared { get; set; }

    [JsonPropertyName("value")]
    public int Value { get; set; }
}

public class Slots
{
    [JsonPropertyName("slot0")]
    public Slot0 Slot0 { get; set; }

    [JsonPropertyName("slot1")]
    public Slot1 Slot1 { get; set; }

    [JsonPropertyName("slot10")]
    public Slot10 Slot10 { get; set; }

    [JsonPropertyName("slot11")]
    public Slot11 Slot11 { get; set; }

    [JsonPropertyName("slot2")]
    public Slot2 Slot2 { get; set; }

    [JsonPropertyName("slot3")]
    public Slot3 Slot3 { get; set; }

    [JsonPropertyName("slot4")]
    public Slot4 Slot4 { get; set; }

    [JsonPropertyName("slot5")]
    public Slot5 Slot5 { get; set; }

    [JsonPropertyName("slot6")]
    public Slot6 Slot6 { get; set; }

    [JsonPropertyName("slot7")]
    public Slot7 Slot7 { get; set; }

    [JsonPropertyName("slot8")]
    public Slot8 Slot8 { get; set; }

    [JsonPropertyName("slot9")]
    public Slot9 Slot9 { get; set; }
}

public class Source
{
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

public class Speed
{
    [JsonPropertyName("otherSpeeds")]
    public List<OtherSpeed> OtherSpeeds { get; set; }

    [JsonPropertyName("value")]
    public int Value { get; set; }
}

public class Spelldc
{
    [JsonPropertyName("dc")]
    public int Dc { get; set; }

    [JsonPropertyName("mod")]
    public int Mod { get; set; }

    [JsonPropertyName("value")]
    public int Value { get; set; }
}

public class SpellType
{
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

public class Str
{
    [JsonPropertyName("mod")]
    public int Mod { get; set; }
}

public class Sustained
{
    [JsonPropertyName("value")]
    public bool Value { get; set; }
}

public class SystemFoundry
{
    [JsonPropertyName("autoHeightenLevel")]
    public AutoHeightenLevel AutoHeightenLevel { get; set; }

    [JsonPropertyName("description")]
    public Description Description { get; set; }

    [JsonPropertyName("displayLevels")]
    public DisplayLevels DisplayLevels { get; set; }

    [JsonPropertyName("prepared")]
    public Prepared Prepared { get; set; }

    [JsonPropertyName("proficiency")]
    public Proficiency Proficiency { get; set; }

    [JsonPropertyName("rules")]
    public List<Rule> Rules { get; set; }

    [JsonPropertyName("showSlotlessLevels")]
    public ShowSlotlessLevels ShowSlotlessLevels { get; set; }

    [JsonPropertyName("showUnpreparedSpells")]
    public ShowUnpreparedSpells ShowUnpreparedSpells { get; set; }

    [JsonPropertyName("slots")]
    public Slots Slots { get; set; }

    [JsonPropertyName("slug")]
    public string Slug { get; set; }

    [JsonPropertyName("source")]
    public Source Source { get; set; }

    [JsonPropertyName("spelldc")]
    public Spelldc Spelldc { get; set; }

    [JsonPropertyName("tradition")]
    public Tradition Tradition { get; set; }

    [JsonPropertyName("ability")]
    public Ability Ability { get; set; }

    [JsonPropertyName("area")]
    public Area Area { get; set; }

    [JsonPropertyName("category")]
    public object Category { get; set; }

    [JsonPropertyName("components")]
    public Components Components { get; set; }

    [JsonPropertyName("cost")]
    public Cost Cost { get; set; }

    [JsonPropertyName("damage")]
    public Damage Damage { get; set; }

    [JsonPropertyName("duration")]
    public Duration Duration { get; set; }

    [JsonPropertyName("hasCounteractCheck")]
    public HasCounteractCheck HasCounteractCheck { get; set; }

    [JsonPropertyName("level")]
    public Level Level { get; set; }

    [JsonPropertyName("location")]
    public Location Location { get; set; }

    [JsonPropertyName("materials")]
    public Materials Materials { get; set; }

    [JsonPropertyName("primarycheck")]
    public Primarycheck Primarycheck { get; set; }

    [JsonPropertyName("range")]
    public Range Range { get; set; }

    [JsonPropertyName("save")]
    public Save Save { get; set; }

    [JsonPropertyName("school")]
    public School School { get; set; }

    [JsonPropertyName("secondarycasters")]
    public Secondarycasters Secondarycasters { get; set; }

    [JsonPropertyName("secondarycheck")]
    public Secondarycheck Secondarycheck { get; set; }

    [JsonPropertyName("spellType")]
    public SpellType SpellType { get; set; }

    [JsonPropertyName("sustained")]
    public Sustained Sustained { get; set; }

    [JsonPropertyName("target")]
    public Target Target { get; set; }

    [JsonPropertyName("time")]
    public Time Time { get; set; }

    [JsonPropertyName("traditions")]
    public Traditions Traditions { get; set; }

    [JsonPropertyName("traits")]
    public Traits Traits { get; set; }

    [JsonPropertyName("attack")]
    public Attack Attack { get; set; }

    [JsonPropertyName("attackEffects")]
    public AttackEffects AttackEffects { get; set; }

    [JsonPropertyName("bonus")]
    public Bonus Bonus { get; set; }

    [JsonPropertyName("damageRolls")]
    public List<DamageRoll> DamageRolls { get; set; }

    [JsonPropertyName("weaponType")]
    public WeaponType WeaponType { get; set; }

    [JsonPropertyName("actionType")]
    public ActionType ActionType { get; set; }

    [JsonPropertyName("actions")]
    public Actions Actions { get; set; }

    [JsonPropertyName("requirements")]
    public Requirements Requirements { get; set; }

    [JsonPropertyName("trigger")]
    public Trigger Trigger { get; set; }

    [JsonPropertyName("weapon")]
    public Weapon Weapon { get; set; }

    [JsonPropertyName("mod")]
    public Mod Mod { get; set; }

    [JsonPropertyName("proficient")]
    public Proficient Proficient { get; set; }

    [JsonPropertyName("abilities")]
    public AbilitiesFoundry Abilities { get; set; }

    [JsonPropertyName("attributes")]
    public Attributes Attributes { get; set; }

    [JsonPropertyName("details")]
    public Details Details { get; set; }

    [JsonPropertyName("resources")]
    public Resources Resources { get; set; }

    [JsonPropertyName("saves")]
    public Saves Saves { get; set; }
}

public class Target
{
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

public class Time
{
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

public class Tradition
{
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

public class Traditions
{
    [JsonPropertyName("value")]
    public List<string> Value { get; set; }
}

public class Traits
{
    [JsonPropertyName("rarity")]
    public string Rarity { get; set; }

    [JsonPropertyName("value")]
    public List<string> Value { get; set; }

    [JsonPropertyName("languages")]
    public Languages Languages { get; set; }

    [JsonPropertyName("senses")]
    public Senses Senses { get; set; }

    [JsonPropertyName("size")]
    public Size Size { get; set; }
}

public class Trigger
{
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

public class Value
{
}

public class Vprnzuh2ttwq46ty7aej
{
    [JsonPropertyName("damage")]
    public string Damage { get; set; }

    [JsonPropertyName("damageType")]
    public string DamageType { get; set; }
}

public class Weapon
{
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

public class WeaponType
{
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

public class Will
{
    [JsonPropertyName("saveDetail")]
    public string SaveDetail { get; set; }

    [JsonPropertyName("value")]
    public int Value { get; set; }
}

public class Wis
{
    [JsonPropertyName("mod")]
    public int Mod { get; set; }
}

