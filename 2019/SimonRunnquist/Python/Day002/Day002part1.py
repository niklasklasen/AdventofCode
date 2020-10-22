import math

file = open("Day002/ComputerProgram.txt", "r")

def Multiply(x, y):
    sumOfNumbers = x * y
    return sumOfNumbers

def Add(x, y):
    sumOfNumbers = x + y
    return sumOfNumbers


numbers = file.read().split(",")
convertToInt = [int(i) for i in numbers]

convertToInt[1] = 12
convertToInt[2] = 2

tempPos = 0
sum = 0

for position in convertToInt:
    position = 0 + tempPos
    print(convertToInt[position])

    if convertToInt[position] == 1:
     sum = convertToInt[position + 3]     
     tempPos = tempPos + 4
     convertToInt[sum] = Add(convertToInt[convertToInt[position+1]], convertToInt[convertToInt[position+2]])

    elif convertToInt[position] == 2:
     sum = convertToInt[position + 3]
     tempPos = tempPos + 4
     convertToInt[sum] = Multiply(convertToInt[convertToInt[position+1]], convertToInt[convertToInt[position+2]])

    elif convertToInt[position] == 99:
     print(convertToInt[0])
     break
    else:
     print("No number defined for the software")

print(convertToInt)