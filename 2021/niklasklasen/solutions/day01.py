import advent

readout = advent.input('2021_01')

n = 0
depthcount = []
nmax = len(readout) - 1

while(n <= nmax):
    if readout[n] > readout[n-1]:
        depthcount.append(int(readout[n]))
    n = n + 1
print(len(depthcount))

# Wrong Answers
# 1296
# 1297