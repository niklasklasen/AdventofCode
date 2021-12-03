# Advernt Of Code
# Day 1

# Count the number of times a depth measurement increases from the previous measurement. 

from os import read

def input(filename):
    values = open('../input/' + filename + '.txt' , 'r')
    valuelist = values.read().splitlines()
    return valuelist

readout = input('2021_01')

for line in readout:
    print(line)