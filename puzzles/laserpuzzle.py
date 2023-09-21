import numpy

class Coord:
     def __init__(self, x, y):
          self.x = x
          self.y = y

class Mirror:
    def __init__(self, facing, coord):
        self.facing = facing
        self.coord = coord

    def Rotate(self):
            self.facing *= -1  

    @property
    def X(self):
         return self.coord.x 
    
    @property
    def Y(self):
         return self.coord.y

class Grid:
    def __init__(self, size=10, mirrors=[]):
         self.grid = numpy.zeros((size,size))
         self._populateGrid(mirrors)

    def _populateGrid(self, mirrors):
         for mirror in mirrors:
              self.grid[mirror.x][mirror.y] = mirror

     def Draw

test = Grid()