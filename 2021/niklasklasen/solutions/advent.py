import os

def input(filename):
    values = open('../input/' + filename + '.txt' , 'r')
    valuelist = values.read().splitlines()
    return valuelist