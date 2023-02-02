class Stats:
    Strength = 0
    Dexterity = 0
    Constitution = 0
    Intelligence = 0
    Wisdom = 0
    Charisma = 0
    HP = 0
    AC = 15


class Monster:
    Stats = Stats()
    Name = ""
    Initiative = 0
    HP = 0
    Lines = []
    AcLine = ""
    HpLine = ""
    AblAtkLines = ""
    HasResistances = False
    Resistances = ""

    @property
    def BasicInfo(self):
        print(self.Name)
        print(self.AcLine)
        print(self.HpLine)
        print(self.AblAtkLines)   


    def Parse(self, input):
        self.Lines = input
        self.Name = input[0]
        for inp in input:
            if inp.startswith("HP"):
                self.HpLine = inp
                line = inp.split(" ")
                self.HP = int(line[1])
            elif inp.startswith("AC"):
                self.AcLine = inp
            elif self.HP > 0:
                self.AblAtkLines += inp + "\n"

    def Damage(self, damage):
        try:
            dmg = int(damage)
            if self.HasResistances:
                inp = input("{} has the following resistances: {}. Amount to reduce damage by: ".format(self.Name, self.Resistances))
                if inp != "":
                    dmg -= int(inp)
                    if dmg <= 0:
                        return self.HP

            self.HP -= dmg
            return self.HP
        except:
            return self.HP


class Player:
    Initiative = 0

class Tracker:
    Participants = []
    Monsters = []

    def DamageMonster(self, mon, dmg):
        monster = self.Monsters[mon]
        hp = monster.Damage(dmg)
        if hp <= 0:
            print("{} has been killed!".format(monster.Name))
            self.Monsters.remove(monster)
        else:
            print("{} has {} HP left.".format(monster.Name, monster.HP))

    def Run(self):
        delays = []
        n = 0
        while True:
            if len(delays) > 0:
                delay = input("Would a delay player like to act?")
                if delay == "y":
                    dplays = "Who wants to act: "
                    dn = 0
                    for d in delays:
                        dplays += "({dn}) {} ".format(dn, d.Name)
                    delay = input(dplays)
                    participant = delays[delay]
                    delays.remove(participant)
                    self.Participants.remove(participant)
                    self.Participants.insert(n, participant)
            else:
                participant = self.Participants[n]

            while True:
                inp = input("Command: ")
                if inp == "next":
                    break
                elif inp == "delay":
                    delays.append(participant)
                    break
                elif inp.startswith("dmg") and " " in inp:
                    dmg = inp.split(" ")[1]
                    mon = input("To which enemy?")
                    self.DamageMonster(mon, dmg)
                elif inp == "list":
                    for monster in self.Monsters:
                        monster.BasicInfo


                

            # Increment or restart
            n += 1
            if n == len(self.Participants):
                n = 0
                delays.clear()
