import advent

readout = advent.input('2021_01')

n = 0
depthcount = 0
nmax = len(readout) - 1

while(n <= nmax):
    if readout[n] > readout[n-1]:
        depthcount = depthcount + 1
        print(readout[n])
    n = n + 1
print(readout[n])

# Wrong Answers
# 1296
# 1297