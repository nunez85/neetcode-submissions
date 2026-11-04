class DynamicArray:
    capacity: int
    length: int
    arrList: list[int]
    
    def __init__(self, capacity: int):
        self.capacity = capacity
        self.length = 0
        self.arrList = [None] * capacity


    def get(self, i: int) -> int:
        return self.arrList[i]


    def set(self, i: int, n: int) -> None:
        self.arrList[i] = n


    def pushback(self, n: int) -> None:
        if (self.length == self.capacity):
            self.resize()

        self.arrList[self.length] = n
        self.length += 1


    def popback(self) -> int:
        if (self.length > 0):
            self.length -= 1

        return self.arrList[self.length]
 

    def resize(self) -> None:
        self.capacity *= 2
        newArr = [0] * self.capacity

        for index, val in enumerate(self.arrList):
            newArr[index] = val
        
        self.arrList = newArr


    def getSize(self) -> int:
        return self.length
        
    
    def getCapacity(self) -> int:
        return self.capacity
