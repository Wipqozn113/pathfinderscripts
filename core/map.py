# Basic map class
# Intended to be extended so I can easily keep track of a dungeon state
# For example, coud be extended so I could keep track of which doors are locked/unlocked.
from enum import Enum

class Direction(Enum):
    NORTH = 1
    EAST = 2
    SOUTH = 3
    WEST = 4  

class Coord:
    def __init__(self, x, y, z = 0):
        self.x = x
        self.y = y
        self.z = z

class Door:
    def __init__(self, room1, room2):
        self.map = map
        self.room1 = room1
        self.room2 = room2

    # Figure out direction from coordinates
    def _AssignDoors(self):
        pass

class Room:
    def __init__(self, map, coord, door = None):
        self.coord = coord
        self.doors = {} # This will need to be handled

    def CreateDoor(self, direction):
        # Door already exists!
        if direction in self.doors:
            return True
        
    def _AssignDoor(self, direction, door):
        self.doors[direction] = door
        
class Map:
    def __init__(self):    
        start_coord = Coord(0,0)
        start_room = Room(self, start_coord)    
        self.rooms = {start_coord : start_room}

    def AddRoom(self, coord, from_room):
        # Room exists, so just retrieve it
        if coord in self.rooms:
            to_room = self.rooms[coord]
        # Room doens't exist so we need to create it
        else:
            to_room = Room(self, coord)
        
        # Room exists now, so create the door
        door = Door(from_room, to_room)

