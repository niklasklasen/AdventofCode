#!/usr/bin/env python
import array

from functions import *


for line in open('2019-12-02-python/input.txt'):
    ram = array.array("I")

    for stuff in line.split(","):
        
        ram.append(int(stuff))
        
    #x
    SetValueInPosition(12, 1, ram)
    SetValueInPosition(2, 2, ram)

    pos = 0
    while ExecuteOptcode(pos, ram):
        pos += 4

    print("Pos 0: ", ReadValueInPosition(0, ram))
