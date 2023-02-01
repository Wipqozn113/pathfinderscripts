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

class Player:
    Initiative = 0

class Tracker:
    Participants = []

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
            inp = input("Command: ")
            if inp == "next":
                pass
            elif inp == "delay":
                delays.append(participant)

            # Increment or restart
            n += 1
            if n == len(self.Participants):
                n = 0
                delays.clear()
