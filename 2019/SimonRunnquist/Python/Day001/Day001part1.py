import math

fuelAmount = 0


print("Reading list of star measurements. Please hold...")
print("")
file = open("Day001/StarMeasurements.txt", "r")

print("Reformatting list for my own pleasure...Don't judge me")
print("")

list_from_lines = file.read().split('\n')

print("Calculating fuel reuirement for stranded santa. Please be quiet. This process only gets longer the more you talk")
print("")

convertToInt = [int(i) for i in list_from_lines]

for position in convertToInt:
        div = position/3
        floor = math.floor(div)
        sub = floor-2
        fuelAmount=fuelAmount+sub

print(fuelAmount)
print("")

            




# print(file.read())

# print(os.getcwd())