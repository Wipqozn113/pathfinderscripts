class Player:
    def __init__(self, name):
        self.name = name

class Door:
    def __init__(self, room):
        self.room = room
    
    @property
    def feature(self):
        return self.room.feature
    
    def MovePlayer(self, player):
        self.room.AddPlayer(player)

class Room:
    def __init__(self, line):
         ln = line.split("|")
         self.id = ln[0]
         self.feature = ln[1]
         self.doors = ln[2].split(" ")
         self.players = []
    
    def AddPlayer(self, player):
        self.players.append(player)

    def CreateDoors(self, rooms):
        for i in range(len(rooms)):
            self.doors[i] = Door(rooms[i])

    def MovePlayer(self, player, door):
        ply = self.players[player]
        self.players.remove(ply)
        self.door.MovePlayer(ply)

    def PrintRoom(self):
        print(f"{self.id}:{self.feature}")
        
        players = 'players: ' 
        for i in range(len(self.players)):
            players += f'({i}) {self.players[i].name} '
        print(players)

        doors = 'doors: ' 
        for i in range(len(self.doors)):
            doors += f'({i}) {self.doors[i].feature} '
        print(doors)
        print("")
        

