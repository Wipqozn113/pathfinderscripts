class Levers:
    def __init__(self, count):
        self.count = count
        self.levers = []
        self.CreateLevers(count)

    def CreateLevers(self, count):
        lever = None
        last = None
        for n in range(count):
            if lever is not None:
                last = lever
            lever = Lever(n)  
            if last is not None:    
                lever.left = last
                last.right = lever
            self.levers.append(lever)

    def DoorOpen(self):
        for lever in self.levers:
            if lever.down:
                continue
            else:
                return False
        return True
    
    def PrintLevers(self):
        levers = None
        for lever in self.levers:
            split_lever = lever.AsciiPrint.split("\n")
            if levers is None:
                levers = split_lever
            else:
                for n in range(len(levers)):
                    levers[n] += "   " + split_lever[n]

        for lev in levers:
            print(lev)

    def PullLever(self, lever):
        self.levers[lever].PullLever()
        self.PrintLevers()
        return self.DoorOpen()
        

class Lever:
    def __init__(self, num):
        self.num = num + 1
        self.left = None
        self.right = None
        self.down = False

    @property
    def Pos(self):
        if self.down:
            return "D"
        else:
            return "U"
    
    @property
    def AsciiPrint(self):
        up = ("_____\n" 
             "|(@)|\n" 
             "| | |\n"
             "| | |\n"
             "|   |\n"
             "|   |\n"
             "|   |\n"
             "'-"+ str(self.num) +"-'")

        down = ("_____\n" 
             "|   |\n" 
             "|   |\n"
             "|   |\n"
             "| | |\n"
             "| | |\n"
             "|(@)|\n"
             "'-"+ str(self.num) +"-'")

        return down if self.down else up

    def SetNeighbours(self, left, right):
        self.left = None
        self.right = None
    
    def PullLever(self):
        # Lever already pulled
        if self.down:
            return

        self.down = True
        if self.left is not None:
            self.left.Flip()
        if self.right is not None:
            self.right.Flip()
        
        return

    def Flip(self):
        if self.down:
            self.down = False
        else:
            self.down = True
        
count = int(input("Levers to create: "))
levers = Levers(count)
levers.PrintLevers()
while True:
    num = int(input("Pull which lever:"))
    if levers.PullLever(num - 1):
        print("All levers down! Good job!")
        exit()
    
