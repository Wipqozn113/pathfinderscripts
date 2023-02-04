from math import sqrt

class Tile:
    num = 0
    north = 0
    south = 0
    west = 0
    east = 0
    rotate = 0

    def __init__(self, num, rotate, north, east, south, west):
        self.num = num
        self.rotate = rotate
        self.north = north
        self.east = east
        self.south = south
        self.west = west

    @property
    def Label(self):
        return "    {}    ".format(self.num)

    @property
    def HasOpenSide(self):
        return 1 in [self.north, self.east, self.south, self.west]

    def Rotate(self):
        # Doesn't rotate
        if self.rotate == 0:
            return
        
        # Rotate right
        if self.rotate == 1:
            north = self.west
            east = self.north
            south = self.east
            west = self.south
            self.rotate = -1
        # Rotate left
        elif self.rotate == -1:
            north = self.east
            east = self.south
            south = self.west
            west = self.north
            self.rotate = 1

        # Update directions
        self.north = north
        self.east = east
        self.south = south
        self.west = west

    def Draw(self):
        for row in range(5):
            print(self.CreateRow(row))
    
    def CreateRow(self, row):
        if row == 0:
            return "*********" if self.north == 0 else "***   ***" 
        
        if row in [0, 1]:
            return "*********" if self.north == 0 else "***   ***" 

        if row == 2:            
            if not self.HasOpenSide:
                return "*********"
            row = ""
            row += "***" if self.west == 0 else "   "
            row += "   "
            row += "***" if self.east == 0 else "   "
            return row


        if row in [3, 4]:
            return "*********" if self.south== 0 else "***   ***"

def CreateTiles(fname = "mbp.in"):
    tiles = []

    # rotate north east south west
    with open("inputs/" + fname) as file:
        for line in file:
            ln = line.strip().split(" ")
            tiles.append(Tile(len(tiles) + 1, int(ln[0]), int(ln[1]), int(ln[2]), int(ln[3]), int(ln[4])))

    return tiles

def PrintTiles(tiles):
    dimensions = sqrt(len(tiles))
    if not dimensions.is_integer():
        print('ERROR: Number of tiles must be a perfect square.')
        exit(1)
    dim = int(dimensions)
    start = 0
    while start < len(tiles):
        end = start + dim
        labels = ""
        for rw in range(start, end):
            labels += tiles[rw].Label + "     "
        print(labels)
            
        for row in range(5):
            r = ""
            for rw in range(start, end):
                r += tiles[rw].CreateRow(row) + "     "
            print(r)
        start += dim

while True:
    tiles = CreateTiles()
    PrintTiles(tiles)

    # Keep looping until exited
    while True:
        try:
            inp = input("Rotate which tile?  ")
            print(inp.strip())
            # Done, exit program
            if inp.strip() == "exit":
                exit()

            # They're quite confused, so let's restart
            if inp.strip() == "reset":
                break        

            tile = int(inp.strip())
            tiles[tile - 1].Rotate()
            PrintTiles(tiles)
        except ValueError:
            print("Incorrect input entered! No action taken.")





